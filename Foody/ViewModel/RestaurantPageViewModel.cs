using Foody.Data;
using Foody.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Foody.ViewModel
{
    public class RestaurantPageViewModel:INotifyPropertyChanged
    {
        public RestaurantPageViewModel()
        {
            FetchDataAsync();
        }

        RestaurantData _database = new RestaurantData();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Restaurants> _restaurantsList;
        public ObservableCollection<Restaurants> RestaurantsList
        {
            get { return _restaurantsList; }
            set
            {
                _restaurantsList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RestaurantsList"));
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllRestaurantsAsync();
            RestaurantsList = new ObservableCollection<Restaurants>(list);
        }
    }
}
