using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace OrderService.Models
{
     public class ItemOrder
    {
        public ObjectId Id { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
    }

}

