using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoinParkingSystem.ViewModels;

namespace CoinParkingSystem.Views
{
    /// <summary>
    /// EntryView.xaml の相互作用ロジック
    /// </summary>
    public partial class EntryView : Window
    {
        public EntryView()
        {
            InitializeComponent();
            DataContext = new EntryViewModel(null);
        }
        private void SlotButton_Click(object sender, RoutedEventArgs e)
        { 
            foreach (var child in SlotGrid.Children)
            {
                if (child is Button btn)
                {
                    btn.BorderBrush = Brushes.LimeGreen;
                }
            }
            Button clickedButton = sender as Button;
            clickedButton.BorderBrush = Brushes.Red;
        }

    }
}
