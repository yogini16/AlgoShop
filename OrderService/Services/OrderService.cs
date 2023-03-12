using Grpc.Core;
using MongoDB.Driver;
using MongoDBDataAccess;
using OrderService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Services
{
    public class OrderService : Order.OrderBase
    {
        private readonly IMongoCollection<ItemOrder> _orders;
        private readonly IMongoCollection<Product> _productStocks;
        private readonly IAlgoShopDataAccess _algoShopDataAccess;

        public OrderService(IMongoCollection<ItemOrder> orders, IMongoCollection<Product> productStocks, IAlgoShopDataAccess algoShopDataAccess)
        {
            _orders = orders;
            _productStocks = productStocks;
            _algoShopDataAccess = algoShopDataAccess;
        }

        public override async Task<OrderResponse> PlaceOrder(OrderRequest request, ServerCallContext context)
        {
            var orderTotal = 0.0;
            var insufficientStock = new List<int>();

            foreach (var product in request.Products)
            {
                var productStock = _algoShopDataAccess.GetStockForProduct(product.ProductId).Result;

                if (productStock == null || productStock.Quantity < product.Quantity)
                {
                    insufficientStock.Add(product.ProductId);
                }
                else
                {
                    orderTotal += (double)product.Quantity * 10.0; // assuming all products have the same price
                }
            }

            if (insufficientStock.Any())
            {
                return new OrderResponse
                {
                    Success = false,
                    Message = $"Insufficient stock for products: {string.Join(", ", insufficientStock)}"
                };
            }
            else
            {
                // reserve stock for products
                foreach (var product in request.Products)
                {
                    _algoShopDataAccess.UpdateProductStock(new MongoDBDataAccess.Models.Product
                    {
                        ProductId = product.ProductId,
                        Quantity = product.Quantity
                    });
                }

                // create new order document
               
                var products = request.Products.Select(p => new Product
                {
                    ProductId = p.ProductId,
                    Quantity = p.Quantity
                }).ToList();

                var order = new ItemOrder
                {
                    Products = products,
                    Total = orderTotal
                };

                await _orders.InsertOneAsync(order);

                return new OrderResponse
                {
                    Success = true,
                    Message = "Order placed successfully"
                };
            }
        }
    }

}
