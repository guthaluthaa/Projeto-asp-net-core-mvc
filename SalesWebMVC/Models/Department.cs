namespace SalesWebMVC.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seler)
        {
            Sellers.Add(seler);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
