using System;
using System.Collections.Generic;
using Foody.Data;
using Foody.Model;
using Xamarin.Forms;

namespace Foody
{
    public partial class UserDetailPage : ContentPage
    {
        public UserDetailPage()
        {
            InitializeComponent();

           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //UserData user = new UserData();
            //await user.GetUserDataByIdAsync(App.User_Id);

            User user = new User();


            user.Id = App.User_Id;



            UserData userData = new UserData();
            var data = await userData.GetUserDataByIdAsync(App.User_Id);
           
            foreach (User x in data)
            {
              
                ed_Email.Text = x.Email;
                ed_FNAME.Text = x.First_Name;
                ed_LNAME.Text = x.Last_Name;
                ed_PhoneNumber.Text = x.Phone;
                ed_Unit.Text = x.Unit;
                ed_Street.Text = x.Street;
                ed_Suburb.Text = x.Suburb;
                ed_State.Text = x.State;
                ed_Postcode.Text = x.Postcode;

            }



        }

        async void BtnSave_Clicked(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = App.User_Id;
            user.First_Name = ed_FNAME.Text;
            user.Last_Name = ed_LNAME.Text;
            user.Email = ed_Email.Text;

            if(ed_PW.Text!="")
            {
                if(ed_PW.Text == ed_PWC.Text)
                {
                    user.Password = ed_PW.Text;
                }
                else
                {
                    await DisplayAlert("Failed", "Password and Confirm Password are different", "OK");
                }

            }

            user.Phone = ed_PhoneNumber.Text;
            user.Unit = ed_Unit.Text;
            user.Street = ed_Street.Text;
            user.Suburb = ed_Suburb.Text;
            user.State = ed_State.Text;
            user.Postcode = ed_Postcode.Text;



            UserData userData = new UserData();
            var data = await userData.PutDataAsync(user);

            await DisplayAlert("Success", "Your data has been changed", "OK");

            await Navigation.PushAsync(new HomePage());

        }
        void BtnCancle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        void LogOut(object sender, EventArgs e)
        {
            if(App.isloggedin)
            {
                App.isloggedin = false;
                DisplayAlert("Success", "Logout Success", "OK");
                Navigation.PushAsync(new HomePage());
            }
        }

    }
}
