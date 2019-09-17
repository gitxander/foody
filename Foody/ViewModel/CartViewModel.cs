using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Foody.Data;
using Foody.Model;

namespace Foody.ViewModel
{
    public class CartViewModel:INotifyPropertyChanged
    {
        CartData cartData = new CartData();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Cart> _cartList;

        public ObservableCollection<Cart> CartList
        {
            get { return _cartList; }
            set
            {
                _cartList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CartList"));
                }
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await cartData.GetDataAsync();
            CartList = new ObservableCollection<Cart>(list);
        }

        public CartViewModel()
        {
        }
    }
}
