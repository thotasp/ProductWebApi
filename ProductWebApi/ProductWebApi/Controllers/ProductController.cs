using ProductWebApi.DataAccess;
using ProductWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class ProductController : ApiController
    {
        public string HealthCheck()
        {
            return "thumbs up!";
        }

        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var query = from p in ctx.Products select new ProductModel() { ProductId = p.ProductID, Name = p.Name, ProductNumber = p.ProductNumber, ListPrice = p.ListPrice };
                return query.ToList();
            }
        }

        public ProductModel Get(int id)
        {
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var query = from p in ctx.Products where p.ProductID == id select new ProductModel() { ProductId = p.ProductID, Name = p.Name, ProductNumber = p.ProductNumber, ListPrice = p.ListPrice };
                return query.FirstOrDefault();
            }
        }
    }
}
