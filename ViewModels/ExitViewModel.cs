using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CoinParkingSystem.Services;
using CoinParkingSystem.Commands;

namespace CoinParkingSystem.ViewModels
{
    public class ExitViewModel: BaseViewModel


           {

        private readonly MainNavigationViewModel _mainNav;

        // Constructor မှာ ရထားခေါင်းကြီးကို လှမ်းချိတ်ဖို့ သတ်မှတ်ချက်
        public ExitViewModel(MainNavigationViewModel mainNav)
        {
            _mainNav = mainNav;
        }



        private ReceiptService _receiptService = new ReceiptService();

        public ICommand PaymentCommand { get; }


        public ExitViewModel() { 

            PaymentCommand = new RelayCommand(OnPaymentConfirmed);
        }

        public void OnPaymentConfirmed(object parameter) {

            // mock example >> for testing to release receipt text file. diki
            string currentPlate = "Osaka 300 A 1234";
            decimal totalFee = 500;

            // for customer_receipt.diki
            _receiptService.GenerateCustomerReceipt(currentPlate, totalFee);

            // for owner.diki
            _receiptService.SaveDailyIncome(totalFee);

            System.Windows.MessageBox.Show("ありがとうございます。お支払い完了しました。");
        }

    }
}
