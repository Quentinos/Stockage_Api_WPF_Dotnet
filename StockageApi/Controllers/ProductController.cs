using StockageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StockageApi.Controllers
{
    public class ProductController : ApiController
    {
        IDAL dal;
        public ProductController() 
        {
            dal = new DAL();
        }

        [HttpGet]
        [Route("api/Products")]
        public List<ProductModel> products()
        {
            return dal.GetProducts();
        }

        [HttpPost]
        public IHttpActionResult AddProduct(ProductModel product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            dal.AddProduct(product);

            return Ok(product);
        }
    }
}
