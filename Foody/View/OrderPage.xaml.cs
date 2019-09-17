using System;
using System.Collections.Generic;
using Foody.Model;
using Foody.Data;

using Xamarin.Forms;
using System.Linq;

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
			int User_Id = 1;
			int Checkout = 1;
            base.OnAppearing();
            OrderData orderData = new OrderData();
            ListView.ItemsSource = await orderData.GetDataByUserIdAsync(User_Id, Checkout);
        }

        /* TRIGGER WHEN AN ITEM IS SELECTED FROM TABLE ROW */
        async void OnListViewItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var foo = e.CurrentSelection.FirstOrDefault() as Order;
                
            await Navigation.PushAsync(new OrderDetailsPage(foo.Id)
            {
                BindingContext = e.CurrentSelection.FirstOrDefault() as Order
            });
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
