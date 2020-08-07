using Shop.Data.Models;
using Shop.Database.DataContext;
using Shop.Database.Services.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database.Services
{
    public class ProductsDbService : IProductsDbService
    {
        private ApplicationDbContext db;
        public ProductsDbService()
        {
            this.db = new ApplicationDbContext();
        }

        public IQueryable<Product> GetAllProducts()
        {
            return this.db.Products;
        }

    }
}
