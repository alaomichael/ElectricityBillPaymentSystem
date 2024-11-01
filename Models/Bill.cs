namespace ElectricityBillPaymentSystem.Models
{
    public class Bill
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
