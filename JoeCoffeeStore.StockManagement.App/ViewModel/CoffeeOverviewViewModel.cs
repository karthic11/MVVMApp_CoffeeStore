using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;
using JoeCoffeeStore.StockManagement.App.Extensions;
using System.ComponentModel;
using System;
using JoeCoffeeStore.StockManagement.App.Utilities;
using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.App.Messages;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {

        private ICoffeeDataService coffeedataservice;
        public ICommand CoffeEditCommand { get; set; }
        private IDialogService dialogservice;

        private ObservableCollection<Coffee> coffees;
        public ObservableCollection<Coffee> Coffees
        {
            get
            {
                return coffees;
            }

            set
            {
                coffees = value;
                RaisePropertyChanged("Coffees");
            }
        }


        private Coffee selectedcoffee;
        public Coffee SelectedCoffee
        {
            get
            {
                return selectedcoffee;
            }

            set
            {
                selectedcoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }


        public CoffeeOverviewViewModel(ICoffeeDataService coffeedataservice, IDialogService dialogservice)
        {
            this.coffeedataservice = coffeedataservice;
            this.dialogservice = dialogservice;
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            dialogservice.CloseDetailDialog();
        }

        private void LoadCommands()
        {
            CoffeEditCommand = new MyCommand(EditCoffee, CanEditCoffee);
        }

        private void EditCoffee(object obj)
        {

            Messenger.Default.Send<Coffee>(selectedcoffee);
            dialogservice.ShowDetailDialog();
        }

        private bool CanEditCoffee(object obj)
        {
            if (selectedcoffee != null) return true;

            return false;
        }

        private void LoadData()
        {
            //this.Coffees = coffeedataservice.GetAllCoffees().ToObservableCollection();
            //this.Coffees = (IObservable<Coffee>) listcoffees.ToObservableCollection();
             this.Coffees = coffeedataservice.GetAllCoffees().ToObservableCollection();
            // this.Coffees = new ObservableCollection<Coffee>(listcoffees);

        }
    }
}
