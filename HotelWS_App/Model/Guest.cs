﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWS_App.Model
{
    public class Guest
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

        public override string ToString()
        {
            return Guest_No + Name + Address;
        }

    }
}