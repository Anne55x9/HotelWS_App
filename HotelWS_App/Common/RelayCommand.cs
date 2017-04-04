using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace HotelWS_App.Common
{
    public class RelayCommand : ICommand

    {

        private Action methodToExecute = null;

        private Func<bool> methodToDetectCanExecute = null;

       //private DispatcherTimer canExecuteChangedEventTimer;

        public RelayCommand(Action methodToExecute, Func<bool> methodToDetectCanExecute)
        {
            this.methodToExecute = methodToExecute;
            this.methodToDetectCanExecute = methodToDetectCanExecute;

            //this.canExecuteChangedEventTimer = new DispatcherTimer();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            this.methodToExecute();
        }

        public bool CaneExecute(object parameter)
        {
            if (this.methodToDetectCanExecute == null)
            {
                return true;
            }
            else
            {
                return this.methodToDetectCanExecute();
            }
        }

    }
}
