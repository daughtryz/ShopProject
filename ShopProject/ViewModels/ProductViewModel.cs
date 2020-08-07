﻿using ShopProject.Services;
using ShopProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.ViewModels
{
   public class ProductViewModel : INotifyPropertyChanged
    {
        private IProductsService service;
        public ProductViewModel()
        {
            this.service = new ProductsService();
        }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public string ImageUrl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public List<ProductViewModel> All => this.service.GetAll().ToList();
    }
}
