using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinParkingSystem.ViewModels
{
    public class EntryViewModel:BaseViewModel
    {
        private readonly MainNavigationViewModel _mainNav;

       
        public EntryViewModel(MainNavigationViewModel mainNav)
        {
            _mainNav = mainNav;
        }
    }
}
