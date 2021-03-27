using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockageApi.Models
{
    public interface IDAL : IDisposable
    {
        List<ProductModel> GetProducts();
        ProductModel GetProduct(int ID);
        Task<bool> AddProduct(ProductModel Product);
        bool DeleteProduct(int ID);
    }
}
