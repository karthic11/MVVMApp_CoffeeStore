using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;

namespace JoeCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : MetroWindow
    {
        public CoffeeOverviewView()
        {
            InitializeComponent();
            LoadData();
        }

        public Coffee SelectedCofee { get; set; }

        private void LoadData()
        {
            CoffeeDataService coffeDataService = new CoffeeDataService();
            this.CoffeListView.ItemsSource = coffeDataService.GetAllCoffees();
        }

        private void CoffeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.SelectedCofee = this.CoffeListView.SelectedItem as Coffee;
            this.lblCoffeeID.Content = this.SelectedCofee.CoffeeId;
            this.lblCoffeeName.Content = this.SelectedCofee.CoffeeName;
            this.lblDescription.Content = this.SelectedCofee.Description;
            this.lblFirstTimeAdded.Content = this.SelectedCofee.FirstAddedToStockDate.ToShortDateString();
            this.lblPrice.Content = this.SelectedCofee.Price.ToString();
            this.lblStockAmount.Content = this.SelectedCofee.AmountInStock.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView CoffeeDetailView = new CoffeeDetailView();
            CoffeeDetailView.SelectedCoffee = this.SelectedCofee;
            CoffeeDetailView.ShowDialog();
        }
    }
}
