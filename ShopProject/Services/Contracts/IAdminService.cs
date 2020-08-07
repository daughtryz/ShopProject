using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Services.Contracts
{
    public interface IAdminService
    {
        void CreateUser(string username,string password);

        void CreateProduct(string name,decimal price,int quantity,string imageUrl);


    }
}
