using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Foody.Model
{
    public class Foods
    {
        [PrimaryKey]
        public int F_ID { get; set; }
        public int R_ID { get; set; }
        public string F_Title { get; set; }
        public string F_Description { get; set; }
        public int F_Price { get; set; }
        public string F_Category { get; set; }

        public Foods()
        {

        }

        public Foods(int fid, int rid, string title, string desc, int price, string category)
        {
            F_ID = fid;
            R_ID = rid;
            F_Title = title;
            F_Description = desc;
            F_Price = price;
            F_Category = category;

        }

    }
}
