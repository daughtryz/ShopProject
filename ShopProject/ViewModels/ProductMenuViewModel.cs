﻿using MvvmHelpers;
using ShopProject.Services;
using ShopProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.ViewModels
{
   public class ProductMenuViewModel : BaseViewModel
    {
       
        private IProductsService service;

        public ProductMenuViewModel()
        {
            this.service = new ProductsService();
        }
        public ProductMenuViewModel(MainViewModel mainViewModel) : this()
        {
           
            this.MainViewModel = mainViewModel;
        }

        public MainViewModel MainViewModel { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }


        public string ImageUrl { get; set; }

        
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
       
        public List<ProductMenuViewModel> Menu => this.service.GetMenu().ToList();
    }
}
