using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWS_App.Model;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;



namespace HotelWS_App.Web
{
    public class WebServices
    {
        //Dette er facaden.

        const string serverUrl = "http://hotelappwebsevices20170403062059.azurewebsites.net/";

        public static async Task<ObservableCollection<Guest>> LoadEventsFromJsonAsync()
        {

            ObservableCollection<Guest> Temp_list = new ObservableCollection<Guest>();

            using (var client1 = new HttpClient())
            {
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client1.DefaultRequestHeaders.Clear();
                client1.BaseAddress = new Uri(serverUrl);

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/Guests");

                    if (response.IsSuccessStatusCode)
                    {
                        Temp_list = await response.Content.ReadAsAsync<ObservableCollection<Guest>>();
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.Write($"Exception: {e}");
                    Temp_list = null;

                }

                return Temp_list;
            }
        
        }

        public static void PostGuestAsync(Guest newGuest)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                //string urlStringPost = "api/Guests/";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //try
                //{
                    
                    var postResponse = client.PostAsJsonAsync<Guest>("api/Guests", newGuest).Result;
                   

                //    if (postResponse.IsSuccessStatusCode)
                //    {
                        
                //    }
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
            }
        }

        public static void PutAsyncGuest(int guest_No, Guest newGuest)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlStringPut = $"api/Guests/{newGuest.Guest_No}";

                //try
                //{
                    var postResponse = client.PutAsJsonAsync<Guest>(urlStringPut, newGuest).Result;

                //    if (postResponse.IsSuccessStatusCode)
                //    {
                      
                //    }
                //}
                //catch (Exception)
                //{

                //    throw;
                //}
            }
        }
    }
}
