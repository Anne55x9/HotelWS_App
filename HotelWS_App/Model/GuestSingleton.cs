using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return Instance; }

        }

        public ObservableCollection<Guest> Guests { get; set; }

        private GuestSingleton()
        {
            Guests = new ObservableCollection<Guest>();
            
        }

        public void GetGuests(Guest newGuest)
        {
            Guests.Add(newGuest);
            //Web.LoadGuestFromJson();
        }

        ////Foreach over GetAsyncGuest.

        //public async Task GetGuestAsync()
        //{
        //    foreach (var item in await Web.GetAsyncGuest())
        //    {
        //        this.Guests.Add(item);
        //    }

        //}

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
