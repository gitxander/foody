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

        void BtnSave_Clicked(object sender, EventArgs e)
        {

        }
        void BtnCancle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }


    }
}
