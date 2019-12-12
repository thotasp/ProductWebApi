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
                var query = from p in ctx.Products select new ProductDto() { Id = p.Id, ProductName = p.ProductName, Package = p.Package, UnitPrice = p.UnitPrice, IsDiscontinued = p.IsDiscontinued, Supplier = new SupplierDto() { Id = p.Supplier.Id, City = p.Supplier.City, CompanyName=p.Supplier.CompanyName,ContactName= p.Supplier.ContactName, ContactTitle= p.Supplier.ContactTitle, Country=p.Supplier.Country, Fax= p.Supplier.Fax, Phone=p.Supplier.Phone } };
                return query.ToList();
            }
        }

        public ProductDto Get(int id)
        {
            using (AbcCompanyEntities ctx = new AbcCompanyEntities())
            {
                var query = from p in ctx.Products  where p.Id == id select new ProductDto() { Id = p.Id, ProductName = p.ProductName, Package = p.Package, UnitPrice = p.UnitPrice, IsDiscontinued = p.IsDiscontinued, Supplier = new SupplierDto() { Id = p.Supplier.Id, City = p.Supplier.City, CompanyName = p.Supplier.CompanyName, ContactName = p.Supplier.ContactName, ContactTitle = p.Supplier.ContactTitle, Country = p.Supplier.Country, Fax = p.Supplier.Fax, Phone = p.Supplier.Phone } };
                return query.FirstOrDefault();
            }
        }
    }
}
