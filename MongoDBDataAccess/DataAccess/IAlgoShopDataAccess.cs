using MongoDBDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDataAccess
{
    public interface IAlgoShopDataAccess
    {
        Task<Product> GetStockForProduct(int productID);
        Task UpdateProductStock(Product product);

    }
}
