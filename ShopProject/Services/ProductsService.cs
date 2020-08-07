using Shop.Database.Services.Contracts;
using ShopProject.Services.Contracts;
using ShopProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Services
{
    public class ProductsService : IProductsService
    {
        public ProductsService(IProductsDbService db)
        {

        }
        public IEnumerable<ProductViewModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
