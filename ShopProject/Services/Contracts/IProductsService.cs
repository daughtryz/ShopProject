using ShopProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Services.Contracts
{
    public interface IProductsService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
