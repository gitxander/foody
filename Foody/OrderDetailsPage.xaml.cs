using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class OrderDetailsPage : ContentPage
    {
        int Order_Id;

        public OrderDetailsPage(int _order_id)
        {
            InitializeComponent();
            Order_Id = _order_id;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            CartData cartData = new CartData();
            ListView.ItemsSource = await cartData.GetCartDataAsyncByOrderId(Order_Id);
        }
    }
}
