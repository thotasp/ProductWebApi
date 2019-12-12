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
        public List<ProductDto> GetAllProducts()
        {
            using (AbcCompanyEntities ctx = new AbcCompanyEntities())
            {
                var query = from p in ctx.Products select new ProductDto() { Id = p.Id, ProductName = p.ProductName, Package = p.Package, UnitPrice = p.UnitPrice, IsDiscontinued = p.IsDiscontinued, SupplierId = p.SupplierId };
                return query.ToList();
            }
        }

        public ProductDto Get(int id)
        {
            using (AbcCompanyEntities ctx = new AbcCompanyEntities())
            {
                var query = from p in ctx.Products  where p.Id == id select new ProductDto() { Id = p.Id, ProductName=p.ProductName,Package = p.Package, UnitPrice=p.UnitPrice, IsDiscontinued=p.IsDiscontinued, SupplierId = p.SupplierId };
                return query.FirstOrDefault();
            }
        }
    }
}
