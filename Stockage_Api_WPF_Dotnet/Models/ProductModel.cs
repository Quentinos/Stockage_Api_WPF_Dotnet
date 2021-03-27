using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockage_Api_WPF_Dotnet.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string Zone { get; set; }
    }
}