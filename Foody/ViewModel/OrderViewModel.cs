using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Foody.Data;
using Foody.Model;

namespace Foody.ViewModel
{
    public class OrderViewModel:INotifyPropertyChanged
    {
        OrderData orderData = new OrderData();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Order> _orderList;

        public ObservableCollection<Order> OrderList
        {
            get { return _orderList; }
            set
            {
                _orderList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("OrderList"));
                }
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await orderData.GetDataAsync();
            OrderList = new ObservableCollection<Order>(list);
        }

        public OrderViewModel()
        {
        }
    }
}
