using ShopProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Services
{
    public class AdminService : IAdminService
    {
        public AdminService()
        {

        }
        public void CreateProduct(string name, decimal price, int quantity, string imageUrl)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
