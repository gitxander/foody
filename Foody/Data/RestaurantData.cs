using Foody.Model;
using MarcTron.Plugin;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Foody.Data
{
    public class RestaurantData
    {
        public RestaurantData()
        {
            MtSql.Helper.Initialize("restaurants.db");
            MtSql.Helper.CreateTable<Restaurants>();
            MtSql.Helper.DeleteAll<Restaurants>();
            MtSql.Helper.CreateTable<Restaurants>();
            MtSql.Helper.Insert<Restaurants>(new Restaurants {R_ID=1, R_Title="Il Amalfi Pizza Pasta", R_Description= "Il Amalfi Pizza Pasta is known for serving up delicious New York-style pizza to the customers of Burwood. Our patrons rave about our classic, deluxe, and gourmet pizzas. If youre looking for a customisable dish, we recommend trying our Youre The Boss pizza that includes mozzarella cheese, a tomato base, and your choice of toppings. Indulge in our pasta fan favourite, known as the Matriciana, that comes with bacon, onion, capsicum, chilli, garlic, and a Napoli sauce. End your meal with a bowl of our delightful cookie ice cream.",R_Address= "Shop 1, 2-8 Burwood Hwy, Burwood East, 3151", R_Logo="logo1.png", R_BgImg="drawable/r1_bg.png"});
            MtSql.Helper.Insert<Restaurants>(new Restaurants {R_ID=2, R_Title = "Korean Night Snack", R_Description = "", R_Address = "294A Middleborough Road, Blackburn South, 3130", R_Logo ="logo2.png", R_BgImg = "drawable/r2_bg.png" });
            MtSql.Helper.Insert<Restaurants>(new Restaurants {R_ID=3, R_Title = "The Pancake Parlour", R_Description = "", R_Logo="logo3.png", R_Address = "682-690 Warrigal Road, Malvern East, 3145", R_BgImg = "drawable/r3_bg.png" });
            R_database = MtSql.Current.GetConnectionAsync("restaurants.db");
            }

        public SQLiteAsyncConnection R_database { get; private set; }

        public async Task<List<Restaurants>> GetAllRestaurantsAsync()
        {
            return await R_database.Table<Restaurants>().ToListAsync();
        }
    }
}
