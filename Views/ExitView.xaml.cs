using System;
using System.Windows;
using System.Windows.Controls;
using CoinParkingSystem.ViewModels; // for ViewModel/ExitViewModel

namespace CoinParkingSystem.Views
{
    public partial class ExitView : Window
    {
        public ExitView()
        {
            InitializeComponent();

           
            this.DataContext = new ExitViewModel();
        }
    }
}
