using ElectricityBillPaymentSystem.Models;

namespace ElectricityBillPaymentSystem.Services
{
    public class BillService
    {
        private readonly EventPublisher _eventPublisher;

        public BillService(EventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        public Bill CreateBill(decimal amount)
        {
            var bill = new Bill { Id = Guid.NewGuid().ToString(), Amount = amount };
            _eventPublisher.Publish("bill_created", bill);
            return bill;
        }

        public bool PayBill(string billId, Wallet wallet)
        {
            // Implement bill payment logic and check wallet balance
            if (wallet.Balance >= bill.Amount)
            {
                wallet.Balance -= bill.Amount;
                bill.Status = "Paid";
                _eventPublisher.Publish("payment_completed", bill);
                return true;
            }
            return false;
        }
    }
}
