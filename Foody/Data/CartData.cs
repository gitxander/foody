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
    public class CartData
    {
        HttpClient client = new HttpClient();
        List<Cart> cartList = null;

        /* LINK FROM AWS EC2 INSTANCE */
        string url = "http://3.91.188.122/cart";

        /* GET Cart LIST (ALL) */
        public async Task<List<Cart>> GetDataAsync()
        {
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cartList = JsonConvert.DeserializeObject<List<Cart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return cartList;
        }

        /* GET Cart By Order Id */
        public async Task<List<Cart>> GetCartDataAsyncByOrderId(int _order_id)
        {
            try
            {
                var response = await client.GetAsync(url + "/order/" + _order_id);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cartList = JsonConvert.DeserializeObject<List<Cart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return cartList;
        }

        /* GET Cart Per User Id */
        public async Task<List<Cart>> GetCartDataAsyncByUserId(int User_Id, int Checkout)
        {
            try
            {
                var response = await client.GetAsync(url + "/user/" + User_Id + "?checkout=" + Checkout);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cartList = JsonConvert.DeserializeObject<List<Cart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return cartList;
        }

        /* ADD/EDIT CART */
        public async Task<List<Cart>> PostDataAsync(Cart cart)
        {
            var json = JsonConvert.SerializeObject(cart);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client1 = new HttpClient();

            try
            {
                HttpResponseMessage response = await client1.PostAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cartList = JsonConvert.DeserializeObject<List<Cart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return cartList;

        }

        /* DELETE Cart */
        public async Task<List<Cart>> DeleteDataAsync(Cart cart)
        {
            HttpClient client1 = new HttpClient();

            url += "/" + cart.Id;

            try
            {
                HttpResponseMessage response = await client1.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cartList = JsonConvert.DeserializeObject<List<Cart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return cartList;

        }

        public CartData()
        {

        }
    }
}

