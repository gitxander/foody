using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class User_Info
    {
        [PrimaryKey]
        public string U_ID { get; set; }
        [AutoIncrement]
        public int U_No { get; set; }
        public string U_Password { get; set; }

        public string U_Name { get; set; }

        public int U_Phone_Number { get; set; }

        public int U_Unit { get; set; }
        public string U_Street { get; set; }
        public string U_Suburb { get; set; }
        public string U_State { get; set; }
        public int U_Postcode { get; set; }



        public User_Info()
        {

        }

        public User_Info(string id, string pw, string name, int phone int unit, string street, string suburb, string state, int postcode)
        {
            U_ID = id;
            U_Password = pw;
            U_Name = name;
            U_Phone_Number = phone;
            U_Unit = unit;
            U_Street = street;
            U_Suburb = suburb;
            U_State = state;
            U_Postcode = postcode;
        }
    }
}
