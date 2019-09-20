using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Foods
    {
        [PrimaryKey]
        public int Restaurant_Id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category_Id { get; set; }
        public string Image { get; set; }

        public Foods()
        {

        }
    }
}
