using JoeCoffeeStore.StockManagement.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.DAL;

namespace JoeCoffeeStore.StockManagement.App
{
   public class ViewModelLocator
    {

        //create concerete classes
        private static IDialogService dialogservice = new DialogService();
        private static ICoffeeDataService coffeedataservice = new CoffeeDataService(new CoffeeRepository());

        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel(coffeedataservice, dialogservice);

        private static CoffeeDetailViewModel coffeeDetailViewModel = new CoffeeDetailViewModel(coffeedataservice);

        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
           get {
                return coffeeOverviewViewModel;
            }
        }


        public static CoffeeDetailViewModel CoffeeDetailViewModel
        {
            get
            {
                return coffeeDetailViewModel;
            }
        }
        public int Test { get; set; }
    }
}
