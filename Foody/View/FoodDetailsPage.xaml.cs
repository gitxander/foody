using System;
using System.Linq;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Foody.ViewModel;
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

        /* RANDOMLY ADD FOOD TO CART - SHOULD BE MOVED TO RESTAURANTS PAGE  */
        //async void AddFoodToCart(object sender, EventArgs e)
        //{
        //    var food = e.
        //    Cart cart = new Cart();
        //    cart.Food_Id = 2;
        //    cart.User_Id = 1;
        //    cart.Quantity = 3;
        //    Cart cart = new Cart();
        //    CartData cartData = new CartData();

        //    await cartData.PostDataAsync(cart);

        //    await DisplayAlert("Success", "Your data has been added", "OK");
        //}

        async void OnListViewItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var food = e.CurrentSelection.FirstOrDefault() as Foods;

            Cart cart = new Cart();

            cart.Food_Id = food.Id;
            cart.User_Id = 1;
            cart.Quantity = 1;
            CartData cartData = new CartData();

            await cartData.PostDataAsync(cart);

            await DisplayAlert("Success", food.Name +  " has been added", "OK");
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            FoodDetailsData foodData = new FoodDetailsData();
            FoodDetailsView.ItemsSource = await foodData.GetDataByRestaurantIdAsync(FoodDetailsViewModel.restaurantID);
        }

        /* VIEW CART  */
        async void ViewCart(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CartPage()
            {

            });
        }
    }
}
