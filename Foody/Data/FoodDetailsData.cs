using System;
using System.Collections.Generic;
using System.Net.Http;
using Foody.Model;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;
using Xamarin.Forms;

namespace Foody.Data
{
    public class FoodDetailsData
    {
        HttpClient client = new HttpClient();
        List<Foods> foodItems = null;

        /* LINK FROM AWS EC2 INSTANCE */
        string url = "http://3.91.188.122/food";

        public FoodDetailsData()
        {        
        }

        /* GET ALL Food Items By Restaurant ID*/
        public async Task<List<Foods>> GetDataByRestaurantIdAsync(int restaurantID)
        {
            Console.WriteLine(restaurantID);
            try
            {
                var response = await client.GetAsync(url + "/restaurant/" + restaurantID);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    foodItems= JsonConvert.DeserializeObject<List<Foods>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return foodItems;
        }
    }
}
