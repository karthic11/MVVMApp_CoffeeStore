using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace JoeCoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeid;
        private string coffeename;
        private int price;
        private string des;
        private bool instock;
        private Country origincountry;
        private int amountinstock;
        private DateTime firstAddedToStockDate;
        private int imageid;

        public int CoffeeId
        {
            get
            {
                return coffeeid;
            }
            set
            {
                coffeeid = value;
                RaisePropertyChanged("CoffeeId");
            }
        }

        public string CoffeeName
        {
            get
            {
                return coffeename;
            }
            set
            {
                coffeename = value;
                RaisePropertyChanged("CoffeeName");
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public string Description
        {
            get
            {
                return des;
            }
            set
            {
                des = value;
                RaisePropertyChanged("Description");
            }
        }

        public Country OriginCountry
        {
            get
            {
                return origincountry;
            }
            set
            {
                origincountry = value;
                RaisePropertyChanged("OriginCountry");
            }
        }

        public bool InStock
        {
            get
            {
                return instock;
            }
            set
            {
                instock = value;
                RaisePropertyChanged("InStock");
            }
        }

        public int AmountInStock 
        {
            get
            {
                return amountinstock;
            }
            set
            {
                amountinstock = value;
                RaisePropertyChanged("AmountInStock");
            }
        }

        public DateTime FirstAddedToStockDate
        {
            get
            {
                return firstAddedToStockDate;
            }
            set
            {
                firstAddedToStockDate = value;
                RaisePropertyChanged("FirstAddedToStockDate");
            }
        }

        public int ImageId
        {
            get
            {
                return imageid;
            }
            set
            {
                imageid = value;
                RaisePropertyChanged("ImageId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }

        }
    }
}
