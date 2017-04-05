using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWS_App.Model
{
    public class Guest : INotifyPropertyChanged
    {
        public int Guest_No { get; set; }

        public string Name { get; set; }
      
        public string Address { get; set; }

        public Guest(int guest_No, string name, string address)
        {
            this.Guest_No = guest_No;
            this.Name = name;
            this.Address = address;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return "Gæstens nr:" + Guest_No + "Navn:" + Name + "Adresse:" + Address;
        }

    }
}
