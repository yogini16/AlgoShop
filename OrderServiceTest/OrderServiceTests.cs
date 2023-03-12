using Grpc.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderService;
using System.Threading.Tasks;

namespace OrderServiceTest
{
    [TestClass] 
    public class OrderServiceTests
    {

        private Order.OrderClient _client;

         [TestInitialize]
            public void Setup()
            {
                var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
                _client = new Order.OrderClient(channel);
            }

            [TestMethod]
            public async Task PlaceOrder_WithSufficientStock_ReturnsSuccess()
            {
                // Arrange
                var request = new OrderRequest
                {
                    Products =
                {
                    new ProductRequest { ProductId = 1, Quantity = 2 },
                    new ProductRequest { ProductId = 2, Quantity = 1 }
                }
                };

                // Act
                var response = await _client.PlaceOrderAsync(request);

                // Assert
                Assert.IsTrue(response.Success);
                Assert.AreEqual("Order placed successfully", response.Message);
            }

            [TestMethod]
            public async Task PlaceOrder_WithInsufficientStock_ReturnsFailure()
            {
                // Arrange
                var request = new OrderRequest
                {
                    Products =
                {
                    new ProductRequest { ProductId = 1, Quantity = 100 },
                    new ProductRequest { ProductId = 2, Quantity = 50 }
                }
                };

                // Act
                var response = await _client.PlaceOrderAsync(request);

                // Assert
                Assert.IsFalse(response.Success);
                Assert.AreEqual("Insufficient stock for products: 1, 2", response.Message);
            }
        }
    }
