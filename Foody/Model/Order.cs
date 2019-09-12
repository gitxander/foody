using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public double Total { get; set; }
        public DateTime?  Datetime { get; set; }
        
        public Order()
        {

        }
        
    }
}
