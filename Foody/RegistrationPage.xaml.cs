using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms.Xaml;
using Foody.Data;
using Foody.Model;

namespace Foody
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void SignUpbtn(object sender, EventArgs e)
        {
            if (u_PW.Text != u_PWC.Text)
            {
                await DisplayAlert("Failed", "Password and Confirm Password are different", "OK");
            }
            else
            {
                User user = new User();

                user.First_Name = u_FNAME.Text;
                user.Last_Name = u_LNAME.Text;
                user.Email = u_Email.Text;
                user.Password = u_PW.Text;
                user.Phone = u_PhoneNumber.Text;
                user.Unit = u_Unit.Text;
                user.Street = u_Street.Text;
                user.Suburb = u_Suburb.Text;
                user.State = u_State.Text;
                user.Postcode = u_Postcode.Text;



                UserData userData = new UserData();
                var data = await userData.PostDataAsync(user);

                await DisplayAlert("Success", "Your data has been added", "OK");

                await Navigation.PopAsync(); //error here
            }

        }

        private async void Resetbtn(object sender, EventArgs e)
        {
            u_FNAME.Text = "";
            u_LNAME.Text = "";
            u_Email.Text = "";
            u_PW.Text = "";
            u_PWC.Text = "";
            u_PhoneNumber.Text = "";
            u_Unit.Text = "";
            u_Street.Text = "";
            u_Suburb.Text = "";
            u_State.Text = "";
            u_Postcode.Text = "";
            await DisplayAlert("Success", "Page Reset", "OK");

        }
    }
}