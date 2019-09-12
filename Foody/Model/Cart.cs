using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Food_Id { get; set; }
        public int User_Id { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public DateTime? Datetime { get; set; }

        public Cart()
        {

        }

    }
}
