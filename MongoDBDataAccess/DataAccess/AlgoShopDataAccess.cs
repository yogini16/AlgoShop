using MongoDB.Driver;
using MongoDBDataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBDataAccess.DataAccess
{
    public class AlgoShopDataAccess :IAlgoShopDataAccess
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "AlgoShop";
        private const string ProductCollection = "Product";
        private const string OrderCollection = "Order";
        
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<Product> GetStockForProduct(int productID)
        {
            var product = ConnectToMongo<Product>(ProductCollection);
            //var productStock = await _productStocks.Find(p => p.ProductId == product.ProductId).FirstOrDefaultAsync();
            var result = await product.Find(p=>p.ProductId == productID).FirstOrDefaultAsync(); 
            return result;
        }

        public async Task  UpdateProductStock(Product product)
        {
            var stocks = ConnectToMongo<Product>(ProductCollection);
            var filter = Builders<Product>.Filter.Eq(p => p.ProductId, product.ProductId);
            var update = Builders<Product>.Update.Inc(p => p.Quantity, -product.Quantity);
            await stocks.UpdateOneAsync(filter, update);
        }
    }
}
