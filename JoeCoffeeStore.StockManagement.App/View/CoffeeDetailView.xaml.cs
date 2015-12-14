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
using JoeCoffeeStore.StockManagement.Model;

namespace JoeCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : MetroWindow
    {
        public Coffee SelectedCoffee { get; set; }
        public CoffeeDetailView()
        {
            InitializeComponent();
            this.Loaded += CoffeeDetailView_Loaded;
        }

        private void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            // LoadData();
            this.DataContext = this.SelectedCoffee;
        }

        //private void LoadData()
        //{
        //    this.CoffeNameLabel.Content = SelectedCoffee.CoffeeName;
        //    this.CoffeeIdTextBox.Text = SelectedCoffee.CoffeeId.ToString();
        //    CoffeeDescriptionTextBox.Text = SelectedCoffee.Description;
        //    CoffeePriceTextBox.Text = SelectedCoffee.Price.ToString();
        //    StockAmountTextBox.Text = SelectedCoffee.AmountInStock.ToString();
        //    FirstTimeAddedTextBox.Text = SelectedCoffee.FirstAddedToStockDate.ToShortDateString();
        //    if (SelectedCoffee is SuperiorCoffee)
        //    {
        //        ExtraDescriptionTextBox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDescription;
        //    }
        //    else
        //    {
        //        ExtraDescriptionTextBox.Text = "NA";
        //    }

        //    ////BitmapImage IMG = new BitmapImage();
        //    ////IMG.BeginInit();


        //    ////IMG.UriSource = new Uri("pack://application:JoeCoffeeStore.StockManagement.App/Images/coffee1.png");
        //    ////IMG.EndInit();

        //    //CoffeeImage.Source = IMG;
        //        //"C:\Users\kkanmani\Documents\StudyMaterials\MVVM\PluralsightCourse\practical-mvvm\1-practical-mvvm-m1-exercise-files\Finished application\JoeCoffeeStore.StockManagement.App\Images\coffee1.jpg";
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveCoffee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCoffe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void changecoffee_Click(object sender, RoutedEventArgs e)
        {
            SelectedCoffee.CoffeeName = "Houston Coffee";
            SelectedCoffee.Price = 400;
        }
    }
}
