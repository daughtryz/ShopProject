using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database.Services.Contracts
{
    public interface IProductsDbService
    {
         IQueryable<Product> GetAllProducts();
    }
}
