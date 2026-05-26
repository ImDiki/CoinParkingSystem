using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinParkingSystem.ViewModels;

namespace CoinParkingSystem.ViewModels
{
    public class MainViewModel : BaseViewModel

    {
        private readonly MainNavigationViewModel _mainNav;

        public MainViewModel(MainNavigationViewModel mainNav) { 
            _mainNav = mainNav;
        }
    }
}
