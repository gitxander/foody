﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;
using System.Net.Http;
using Foody.Data;
using Foody.Model;
namespace Foody
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {

           
            InitializeComponent();


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (App.isloggedin)
            {
            
                await Navigation.PushAsync(new UserDetailPage());

            }


        }

        public async void Loginbtn(object sender, System.EventArgs e)
        {
            if (login_Email.Text != "" && login_PW.Text != "")
            {
                User user = new User();


                user.Email = login_Email.Text;
                user.Password = login_PW.Text;




                UserData userData = new UserData();
                var data = await userData.PostLoginDataAsync(user);
                string validation = "";
                foreach(User x in data)
                {
                    validation += x.Id;
                    
                }

                if (!String.IsNullOrWhiteSpace(validation))
                {
                  
                    App.isloggedin = true;
                    App.User_Id = Int32.Parse(validation);

                    await DisplayAlert("Success", "Login Success", "OK");

                    await Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await DisplayAlert("Failed", "Check Your Email and Password", "OK");
                }
            }
            else
            {
                await DisplayAlert("Warning", "Enter Your Email and Password", "OK");
            }

        }

        void SignUpbtn(object sender, System.EventArgs e)
        {

            Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}