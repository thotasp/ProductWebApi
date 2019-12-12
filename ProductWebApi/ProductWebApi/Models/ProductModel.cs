using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApi.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public decimal ListPrice { get; set; }
    }
}