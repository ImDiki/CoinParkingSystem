using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CoinParkingSystem.Commands;
using CoinParkingSystem.Models;

namespace CoinParkingSystem.ViewModels
{
    public class EntryViewModel:BaseViewModel
    {
        private readonly MainNavigationViewModel _mainNav;
       

        public ObservableCollection<ParkingSlot> ParkingSlots { get; set; } 

        private ParkingSlot _selectedSlot
        public ParkingSlot SelectedSlot
        {
            get => _selectedSlot;
            set
            {
                _selectedSlot = value;
                OnPropertyChanged();
            }
        }
        public ICommand SelectSlotCommand { get; }
        public EntryViewModel (MainNavigationViewModel mainNav)
        {
            _mainNav = mainNav;

            ParkingSlots = new ObservableCollection<ParkingSlot>();
            for (int i = 1; i <= 15; i++)
            {
                ParkingSlots.Add(new ParkingSlot
                {
                    SlotNumber = i,
                    IsOccupied = false,

                });
            }

            SelectSlotCommand = new RelayCommand(SelectParkingSlot);
        }
        public void SelectParkingSlot(object parameter)
        {
            int slotNumber = int.Parse(parameter.ToString());
            SelectedSlot = ParkingSlots[slotNumber - 1];

            var result = MessageBox.Show(
                $"Slot{slotNumber}を登録しますか?",
                "確認",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            if (result == MessageBoxResult.Yes)
            {
                RegisterCarEntry();
            }
            else
            {
                return;
            }
        }
        public void RegisterCarEntry()
        {
            if (SelectedSlot == null)
                return;

            SelectedSlot.IsOccupied = true;
            SelectedSlot.EntryTime = DateTime.Now;

            OnPropertyChanged(nameof(ParkingSlots));
            MessageBox.Show(
                $"Slot{SelectedSlot.SlotNumber}が登録されました。",
                "完了",
                MessageBoxButton.OK,
                MessageBoxImage.Information
             );
        }
    }
}
