using Stockage_Api_WPF_Dotnet.Models;
using Stockage_Api_WPF_Dotnet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Stockage_Api_WPF_Dotnet.Controllers
{
    public class ProductController : Controller
    {
        ApiService _service = new ApiService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public async Task< ActionResult> AddProduct(ProductModel product)
        {
           var response = await _service.AddProduct(product);
            return View();
        }
    }
}