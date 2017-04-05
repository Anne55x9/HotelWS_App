using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWS_App.ViewModel;
using HotelWS_App.Model;


namespace HotelWS_App.Handler
{
    public class GuestHandler
    {
        private GuestBookViewModel Gvm { get; set; }

        public GuestHandler(GuestBookViewModel gvm)
        {
            this.Gvm = gvm;
        }

        public async void GetGuest()
        {
            await GuestSingleton.Instance.GetGuestAsync();
        }

        public void CreateGuestHandler()
        {
            Guest tempGuest = new Guest(Gvm.Guest_No, Gvm.Name, Gvm.Address);
            tempGuest.Guest_No = Gvm.Guest_No;
            tempGuest.Name = Gvm.Name;
            tempGuest.Address = Gvm.Address;
           GuestSingleton.Instance.PostGuest(tempGuest);
        }

        public void PutGuestHandler()
        {
            GuestSingleton.Instance.PutGuest(Gvm.Guest_No, Gvm.SelectedGuest);
            //Singleton.Instance.GuestsCollection.Add(Gvm.SelectedGuest);
        }

        public void RemoveGuestHandler()
        {
            GuestSingleton.Instance.Guests.Remove(Gvm.SelectedGuest);
            //Singleton.Instance.RemoveGuestHandler(Gvm.SelectedGuest.Guest_No);
        }

    }
}
