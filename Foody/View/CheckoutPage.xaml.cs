using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }

        /* PROCEED TO CHECKOUT CART */
        async void ProceedToCheckout(object sender, EventArgs e)
        {
            Order order = new Order();
            order.User_Id = 1;

            OrderData orderData = new OrderData();
            await orderData.PutDataAsync(order);

            await Navigation.PushAsync(new SuccessPage()
            {

            });
        }
    }
}
