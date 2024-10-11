namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Sellers { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(Guid id, DateTime date, double amount, SaleStatus status, Seller sellers)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Sellers = sellers;
        }
    }
}
