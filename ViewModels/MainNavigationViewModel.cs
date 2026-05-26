using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinParkingSystem.ViewModels
{
    public class MainNavigationViewModel : BaseViewModel
    {
        //画面 Map for use. MapsToMain,MapsToEntry,MapsToExit

        private BaseViewModel _currentViewModel;

      
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
             
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

       
        public void MapsToMain()
        {
            
            CurrentViewModel = new MainViewModel(this);
        }

        public void MapsToEntry()
        {
            CurrentViewModel = new EntryViewModel(this);
        }

        public void MapsToExit()
        {
            CurrentViewModel = new ExitViewModel(this);
        }

        public MainNavigationViewModel()
        {
           
            MapsToMain();
        }

    }
}
