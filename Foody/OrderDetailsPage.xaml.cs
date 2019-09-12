using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class OrderDetailsPage : ContentPage
    {
        public OrderDetailsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            CartData cartData = new CartData();
            ListView.ItemsSource = await cartData.GetDataAsync();
        }
    }
}
