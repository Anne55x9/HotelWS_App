using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWS_App.Model;
using System.Windows.Input;
using HotelWS_App.Common;

namespace HotelWS_App.ViewModel
{
    public class GuestBookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public int Guest_No { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private ObservableCollection<Guest> _guestList;

        public ObservableCollection<Guest> GuestList
        {
            get { return _guestList; }
            set { _guestList = value; }
        }

        public Handler.GuestHandler gh { get; set; }

        public ICommand GetGuestCommand { get; set; }

        private Guest _selectedGuest;

        public Guest SelectedGuest
        {
            get { return _selectedGuest; }
            set { _selectedGuest = value; OnPropertyChanged(nameof(SelectedGuest)); }
        }

        public GuestBookViewModel()
        {
            GuestList = GuestSingleton.Instance.Guests;
            gh = new Handler.GuestHandler(this);

            //GetGuestCommand = new RelayCommand(gh.GetGuest, null);
        }
    }


}
