using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StockageApi.Models
{
    public class DBContext : DbContext
    {
        public DbSet <ProductModel> ProductModels { get; set; }
    }
}