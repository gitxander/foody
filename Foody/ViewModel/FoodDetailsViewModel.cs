using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Foody.Data;
using Foody.Model;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Diagnostics.Debug;

namespace Foody.ViewModel
{
    public class FoodDetailsViewModel: INotifyPropertyChanged
    {
        public static int restaurantID;
        FoodDetailsData foodItemData = new FoodDetailsData();
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Foods> _foodItems;
        public ObservableCollection<Foods> FoodItems
        {
            get { return _foodItems; }
            set
            {
                _foodItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FoodItems"));
            }
        }

        public async Task FetchDataAsync()
        { 
            var foodItems = await foodItemData.GetDataByRestaurantIdAsync(restaurantID);
            _foodItems = new ObservableCollection<Foods>(foodItems);
        }

        public FoodDetailsViewModel()
        {
            FetchDataAsync();
        }
    }
}
