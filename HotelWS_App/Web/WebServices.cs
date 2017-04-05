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
            //HttpClientHandler handler = new HttpClientHandler();
            //HttpClient client = new HttpClient();
            //handler.UseDefaultCredentials = true;

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
                    System.Diagnostics.Debug.Write(e);
                    Temp_list = null;

                }

                return Temp_list;
            }
        }


    }
}
