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

        public void GetGuest()
        {
            Guest tempGuest = new Model.Guest(Gvm.Guest_No, Gvm.Name, Gvm.Address);
            tempGuest.Guest_No = Gvm.Guest_No;
            tempGuest.Name = Gvm.Name;
            tempGuest.Address = Gvm.Address;

            GuestSingleton.Instance.GetGuests(tempGuest);
        }
    }
}
