using ElectricityBillPaymentSystem.Models;

namespace ElectricityBillPaymentSystem.Services
{
    public class WalletService
    {
        private readonly EventPublisher _eventPublisher;

        public WalletService(EventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        public Wallet AddFunds(string walletId, decimal amount)
        {
            // Implement logic to add funds to the wallet
            wallet.Balance += amount;
            _eventPublisher.Publish("funds_added", wallet);
            return wallet;
        }
    }
}
