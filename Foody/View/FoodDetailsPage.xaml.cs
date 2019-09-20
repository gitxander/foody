using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Foody.ViewModel;
using Xamarin.Forms;

using Xamarin.Forms;

namespace Foody.View
{
    public partial class FoodDetailsPage : ContentPage
    {
        public FoodDetailsPage(int restaurantID)
        {
            FoodDetailsViewModel.restaurantID = restaurantID;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            FoodDetailsData foodData = new FoodDetailsData();
            FoodDetailsView.ItemsSource = await foodData.GetDataByRestaurantIdAsync(FoodDetailsViewModel.restaurantID);
        }
    }
}
