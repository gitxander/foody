using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class CartPage : ContentPage
    {

        int User_Id = 1;
        int Checkout = 0;
        CartData cartData;

        public CartPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            cartData = new CartData();
            ListView.ItemsSource = await cartData.GetCartDataAsyncByUserId(User_Id, Checkout);
        }

        /* CHECKOUT CART */
        async void CheckoutCart(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CheckoutPage()
            {

            });
        }

        async void DecreaseItem(object sender, EventArgs args)
        {
            
            Cart cart = new Cart();
            cart.Food_Id = int.Parse((sender as Button).CommandParameter.ToString());
            cart.User_Id = User_Id;
            cart.Quantity = -1;

            await cartData.PostDataAsync(cart);

            ListView.ItemsSource = await cartData.GetCartDataAsyncByUserId(User_Id, Checkout);
        }

        async void IncreaseItem(object sender, EventArgs args)
        {

            Cart cart = new Cart();
            cart.Food_Id = int.Parse((sender as Button).CommandParameter.ToString());
            cart.User_Id = User_Id;
            cart.Quantity = 1;

            await cartData.PostDataAsync(cart);

            ListView.ItemsSource = await cartData.GetCartDataAsyncByUserId(User_Id, Checkout);
        }
    }
}
