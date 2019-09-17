using System;
using System.Collections.Generic;
using Foody.Data;
using Xamarin.Forms;

namespace Foody
{
    public partial class SuccessPage : ContentPage
    {
        public SuccessPage()
        {
            InitializeComponent();
        }

        /* GO BACK HOME */
        async void GoBackHome(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage()
            {

            });
        }
    }
}
