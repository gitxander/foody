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
            MtSql.Helper.DeleteAll<Restaurants>();
            MtSql.Helper.CreateTable<Restaurants>();
            MtSql.Helper.Insert<Restaurants>(new Restaurants {R_Title="Il Amalfi Pizza Pasta", R_Description= "Il Amalfi Pizza Pasta is known for serving up delicious New York-style pizza to the customers of Burwood. Our patrons rave about our classic, deluxe, and gourmet pizzas. If youre looking for a customisable dish, we recommend trying our Youre The Boss pizza that includes mozzarella cheese, a tomato base, and your choice of toppings. Indulge in our pasta fan favourite, known as the Matriciana, that comes with bacon, onion, capsicum, chilli, garlic, and a Napoli sauce. End your meal with a bowl of our delightful cookie ice cream.", R_BgImg="drawable/r1_bg.png"});
            MtSql.Helper.Insert<Restaurants>(new Restaurants { R_Title = "Korean Night Snack", R_Description = "", R_BgImg = "drawable/r2_bg.png" });
            R_database = MtSql.Current.GetConnectionAsync("restaurants.db");
            }

        public SQLiteAsyncConnection R_database { get; private set; }

        public async Task<List<Restaurants>> GetAllRestaurantsAsync()
        {
            return await R_database.Table<Restaurants>().ToListAsync();
        }
    }
}
