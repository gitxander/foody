using System;
using System.Collections.Generic;
using Foody.Data;
using Xamarin.Forms;

namespace Foody
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            int User_Id = 1;
            int Checkout = 0;

            base.OnAppearing();
            CartData cartData = new CartData();
            ListView.ItemsSource = await cartData.GetCartDataAsyncByUserId(User_Id, Checkout);
        }
    }
}
