using System;
using System.Collections.Generic;
using Foody.Data;
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

            await Navigation.PushAsync(new CartPage()
            {

            });
        }
    }
}
