using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWS_App.Web;


namespace HotelWS_App.Model
{
    public class GuestSingleton
    {
        private static GuestSingleton _instance;

        public static GuestSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GuestSingleton();
                }
                return _instance; }

        }

  

            public ObservableCollection<Guest> Guests { get; set; }

        private GuestSingleton()
        {
            Guests = new ObservableCollection<Guest>();
            GetGuestAsync();
           
        }

        //public void GetGuests(Guest newGuest)
        //{
        //    Guests.Add(newGuest);
        //    WebServices.LoadEventsFromJsonAsync();
        //}

        //Foreach over GetAsyncGuest.

        public async Task GetGuestAsync()
        {
            foreach (var item in await WebServices.LoadEventsFromJsonAsync())
            {
                this.Guests.Add(item);
            }

        }

        //public async void LoadJson()
        //{
        //    try
        //    {
        //        Guests = await Web.LoadGuestFromJson();
        //    }
        //    catch (Exception e)
        //    {

        //        System.Diagnostics.Debug.Write($"Exception: {e}");
        //    }
        //}

    }
}
