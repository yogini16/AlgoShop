using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using StocksService.Models;
using StocksService.Protos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StocksService.Services
{
    public class StockService : Stock.StockBase
    {

            private readonly ILogger<StockService> _logger;

            // You can replace this with your own database implementation
            private readonly IDictionary<int, int> _productStock = new Dictionary<int, int>();

            public StockService(ILogger<StockService> logger)
            {
                _logger = logger;
            }

  
            public override Task<StockResponse> GetStock(ProductRequest request, ServerCallContext context)
            {
                // Implement your logic to get the stock for the given product ID
                var productStock = GetProductStock(request.ProductId);

                return Task.FromResult(new StockResponse
                {
                    Success = true,
                    Message = $"The current stock for product ID {request.ProductId} is {productStock}."
                });
            }

            public override Task<StockResponse> IncreaseStock(ProductRequest request, ServerCallContext context)
            {
                // Implement your logic to increase the stock for the given product ID
                var success = IncreaseProductStock(request.ProductId, request.Quantity);

                return Task.FromResult(new StockResponse
                {
                    Success = success,
                    Message = success ? $"The stock for product ID {request.ProductId} has been increased by {request.Quantity}." : $"Failed to increase stock for product ID {request.ProductId}."
                });
            }

            public override Task<StockResponse> DecreaseStock(ProductRequest request, ServerCallContext context)
            {
                // Implement your logic to decrease the stock for the given product ID
                var success = DecreaseProductStock(request.ProductId, request.Quantity);

                return Task.FromResult(new StockResponse
                {
                    Success = success,
                    Message = success ? $"The stock for product ID {request.ProductId} has been decreased by {request.Quantity}." : $"Failed to decrease stock for product ID {request.ProductId}."
                });
            }

            // Helper method to get the current stock for the given product ID
            private int GetProductStock(int productId)
            {
                // Implement your logic to get the current stock for the given product ID
                return 10;
            }

            // Helper method to increase the stock for the given product ID
            private bool IncreaseProductStock(int productId, int quantity)
            {
                // Implement your logic to increase the stock for the given product ID
                return true;
            }

            // Helper method to decrease the stock for the given product ID
            private bool DecreaseProductStock(int productId, int quantity)
            {
                // Implement your logic to decrease the stock for the given product ID
                return true;
            }
        }
    }

 

