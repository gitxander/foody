using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Restaurants
    {
        [PrimaryKey]
        public int R_ID { get; set; } //Restaurants ID
        public string R_Title { get; set; }
        public string R_Description { get; set; }
        public string R_BgImg { get; set; }
        public string R_Logo { get; set; }
        
        //address
        public string R_Address { get; set; }
        //public int R_Unit { get; set; }
        //public string R_Street { get; set; }
        //public string R_Suburb { get; set; }
        //public string R_State { get; set; }
        //public int R_Postcode { get; set; }
        //public int R_ContactNumber { get; set; }
        //public string R_TradingHours { get; set; }


        public Restaurants()
        {

        }

        public Restaurants(int id, string title, string description, string address)
        {
            R_ID = id;
            R_Title = title;
            R_Description = description;
            R_Address = address;
            //R_Unit = unit;
            //R_Street = street;
            //R_Suburb = suburb;
            //R_State = state;
            //R_Postcode = postcode;
            //R_ContactNumber = phone;
            //R_TradingHours = tradinghour;

        }


    }
}
