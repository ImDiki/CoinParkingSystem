using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoinParkingSystem.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
                   //DUN CHANGE IT!!!!

              //View က ViewModel ကို သိတယ်။

         //ViewModel က Model နဲ့ Services ကို သိတယ်။

       