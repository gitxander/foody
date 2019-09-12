using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Order_History
    {
        [PrimaryKey, AutoIncrement]
        public int O_No { get; set; }
        public int U_ID { get; set; }
        public string R_Title { get; set; }
        public string F_Title { get; set; }
        public int O_Quantity { get; set; }
        public DateTime?  O_Time { get; set; }
        public string O_Destination { get; set; }
        public string O_DriverName { get; set; }
        public int O_DriverContactNumber { get; set; }

        public Order_History()
        {

        }
        public Order_History(int no, int uid, string rtitle, string ftitme, int quantity, DateTime? time, string dest, string dname, int dphone)
        {
            O_No = no;
            U_ID = uid;
            R_Title = rtitle;
            F_Title = ftitme;
            O_Quantity = quantity;
            O_Time = time;
            O_Destination = dest;
            O_DriverName = dname;
            O_DriverContactNumber = dphone;

        }
        

    }
}
