﻿using Shop.Database.Services;
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
        public IEnumerable<ProductListViewModel> GetAll()
        {
            return this.db.GetAllProducts().Select(x => new ProductListViewModel
            {
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                
            }).ToList();
        }

        public IEnumerable<ProductMenuViewModel> GetMenu()
        {
            return this.db.GetAllProducts().Select(x => new ProductMenuViewModel
            {
                Name = x.Name,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            }).ToList();
        }


    }
}
