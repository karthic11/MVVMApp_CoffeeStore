﻿using JoeCoffeeStore.StockManagement.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.App
{
   public class ViewModelLocator
    {

        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel();

        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
           get {
                return coffeeOverviewViewModel;
            }
        }

        public int Test { get; set; }
    }
}
