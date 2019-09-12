using System;
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
                await Navigation.PushAsync(new RestaurantPage
                {
                    BindingContext = e.SelectedItem as User
                });
            }
        }
    }
}
