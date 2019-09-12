using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foody
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HomePage();

            /* use new NavigationPage to enable Navigation.PushAsync */
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
