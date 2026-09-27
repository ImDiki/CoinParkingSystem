using System;
using System.IO;

namespace CoinParkingSystem.Services
{
    public class ReceiptService
    {
        private readonly string _customerReceiptPath;
        private readonly string _dailyOwnerReportPath;

        public ReceiptService()
        {
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string customerDirectory = Path.Combine(dataDirectory, "Customer_Receipt");
            string ownerDirectory = Path.Combine(dataDirectory, "Owner_Receipt");

            Directory.CreateDirectory(customerDirectory);
            Directory.CreateDirectory(ownerDirectory);

            _customerReceiptPath = Path.Combine(customerDirectory, "receipt_history.txt");
            _dailyOwnerReportPath = Path.Combine(ownerDirectory, "daily_income_report.txt");
        }

        public void GenerateCustomerReceipt(string plateNumber, decimal amount)
        {
            string content =
                $"--- Receipt ---{Environment.NewLine}" +
                $"Plate: {plateNumber}{Environment.NewLine}" +
                $"Amount: ¥{amount}{Environment.NewLine}" +
                $"Time: {DateTime.Now}{Environment.NewLine}{Environment.NewLine}";

            File.AppendAllText(_customerReceiptPath, content);
        }

        public void SaveDailyIncome(decimal amount)
        {
            string reportLine =
                $"{DateTime.Now.ToShortDateString()} | Income: ¥{amount}{Environment.NewLine}";

            File.AppendAllText(_dailyOwnerReportPath, reportLine);
        }
    }
}
