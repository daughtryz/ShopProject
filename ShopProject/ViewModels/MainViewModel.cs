using MvvmHelpers;
using ShopProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShopProject.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ProductMenuViewModel productMenuViewModel;

        public ProductMenuViewModel ProductMenuViewModel
        {
            get
            {
                if (productMenuViewModel == null)
                {
                    productMenuViewModel = new ProductMenuViewModel(this);
                    ProductMenuView menuView = new ProductMenuView();


                    menuView.DataContext = productMenuViewModel;
                }

                return productMenuViewModel;
            }
            set
            {
                productMenuViewModel = value;
                OnPropertyChanged();
            }
        }

    }
}
