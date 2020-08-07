using Shop.Database.Services;
using Shop.Database.Services.Contracts;
using ShopProject.Services.Contracts;
using ShopProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Services
{
    public class ProductsService : IProductsService
    {
        private IProductsDbService db;
        public ProductsService()
        {
            this.db = new ProductsDbService();
        }
        public IEnumerable<ProductViewModel> GetAll()
        {
            return this.db.GetAllProducts().Select(x => new ProductViewModel
            {
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                ImageUrl = x.ImageUrl
            }).ToList();
        }

        
    }
}
