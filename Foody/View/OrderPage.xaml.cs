﻿using System;
using System.Collections.Generic;
using Foody.Model;
using Foody.Data;

using Xamarin.Forms;

namespace Foody
{
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        /* TRIGGER AFTER ADD/UPDATE/DELETE DATA. REFRESH TABLE ROW */
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            OrderData orderData = new OrderData();
            ListView.ItemsSource = await orderData.GetDataAsync();
        }

        /* TRIGGER WHEN AN ITEM IS SELECTED FROM TABLE ROW */
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var foo = e.SelectedItem as Order;
                
                await Navigation.PushAsync(new OrderDetailsPage(foo.Id)
                {
                    BindingContext = e.SelectedItem as Order
                });
            }
        }

        /* RANDOMLY ADD FOOD TO CART - SHOULD BE MOVED TO RESTAURANTS PAGE  */
        async void AddFoodToCart(object sender, EventArgs e)
        {
   
                Cart random = new Cart();
                random.Food_Id = 2;
                random.User_Id = 1;
                random.Quantity = 3;

                CartData cartData = new CartData();

                await cartData.PostDataAsync(random);

                await DisplayAlert("Success", "Your data has been added", "OK");
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