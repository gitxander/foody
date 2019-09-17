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

        /* SHOULD BE AT FOOD MODEL BUT IDK */
        public int Restaurant_Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Cart()
        {

        }

    }
}
