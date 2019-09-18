﻿using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class RestaurantPage : ContentPage
    {
        public RestaurantPage()
        {
            
            InitializeComponent();
        }

        /* RANDOMLY ADD FOOD TO CART - SHOULD BE MOVED TO RESTAURANTS PAGE  */
        async void AddFoodToCart(object sender, EventArgs e)
        {

            Cart cart = new Cart();
            cart.Food_Id = 2;
            cart.User_Id = 1;
            cart.Quantity = 3;

            CartData cartData = new CartData();

            await cartData.PostDataAsync(cart);

            await DisplayAlert("Success", "Your data has been added", "OK");
        }
    }
}
