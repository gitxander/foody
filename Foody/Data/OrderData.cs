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
    public class OrderData
    {
        HttpClient client = new HttpClient();
        List<Order> orderList = null;

        /* LINK FROM AWS EC2 INSTANCE */
        string url = "http://3.91.188.122/order";

        /* GET Order LIST */
        public async Task<List<Order>> GetDataAsync()
        {
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    orderList = JsonConvert.DeserializeObject<List<Order>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return orderList;
        }

        /* EDIT Order INFO */
        public async Task<List<Order>> PutDataAsync(Order Order)
        {
            var json = JsonConvert.SerializeObject(Order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client1 = new HttpClient();

            try
            {
                HttpResponseMessage response = await client1.PutAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    orderList = JsonConvert.DeserializeObject<List<Order>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return orderList;

        }

        public OrderData()
        {

        }
    }
}

