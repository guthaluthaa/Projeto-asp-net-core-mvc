using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department dp1 = new Department() { Id = Guid.NewGuid(), Name = "Electronics" };
            Department dp2 = new Department() { Id = Guid.NewGuid(), Name = "Housing" };
            Department dp3 = new Department() { Id = Guid.NewGuid(), Name = "Computers" };
            Department dp4 = new Department() { Id = Guid.NewGuid(), Name = "Books" };

            Seller s1 = new Seller() { Id = Guid.NewGuid(), Name = "Jacob Neller", Email = "Jacob@gmail.com", BirthDate = new DateTime(1998, 12, 12, 0, 0, 0, DateTimeKind.Utc), baseSalary = 5000.0, Department = dp1 };
            Seller s2 = new Seller(Guid.NewGuid(), "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 12, 0, 0, 0, DateTimeKind.Utc), 3500.0, dp2);
            Seller s3 = new Seller(Guid.NewGuid(), "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 10, 0, 0, 0, DateTimeKind.Utc), 2200.0, dp1);
            Seller s4 = new Seller(Guid.NewGuid(), "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 10, 0, 0, 0, DateTimeKind.Utc), 3000.0, dp4);
            Seller s5 = new Seller(Guid.NewGuid(), "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9, 0, 0, 0, DateTimeKind.Utc), 4000.0, dp3);
            Seller s6 = new Seller(Guid.NewGuid(), "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4, 0, 0, 0, DateTimeKind.Utc), 3000.0, dp2);

            List<SalesRecord> records = new List<SalesRecord>() {
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 12, 0, 0, 0, DateTimeKind.Utc), 11000.0, SaleStatus.Billed, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 4, 0, 0, 0, DateTimeKind.Utc), 7000.0, SaleStatus.Billed, s5),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 10, 0, 0, 0, DateTimeKind.Utc), 4000.0, SaleStatus.Canceled, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 1, 0, 0, 0, DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 1, 0, 0, 0, DateTimeKind.Utc), 3000.0, SaleStatus.Billed, s3),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 2, 0, 0, 0, DateTimeKind.Utc), 2000.0, SaleStatus.Billed, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 2, 0, 0, 0, DateTimeKind.Utc), 13000.0, SaleStatus.Billed, s2),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 11, 0, 0, 0, DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 5, 0, 0, 0, DateTimeKind.Utc), 11000.0, SaleStatus.Pending, s6),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 7, 0, 0, 0, DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s6),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 4, 0, 0, 0, DateTimeKind.Utc), 6000.0, SaleStatus.Billed, s2),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 5, 0, 0, 0, DateTimeKind.Utc), 7000.0, SaleStatus.Pending, s3),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 4, 0, 0, 0, DateTimeKind.Utc), 10000.0, SaleStatus.Billed, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 4, 0, 0, 0, DateTimeKind.Utc), 3000.0, SaleStatus.Billed, s5),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 9, 12, 0, 0, 0, DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 5, 0, 0, 0, DateTimeKind.Utc), 2000.0, SaleStatus.Billed, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 1, 0, 0, 0, DateTimeKind.Utc), 12000.0, SaleStatus.Billed, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 2, 0, 0, 0, DateTimeKind.Utc), 6000.0, SaleStatus.Billed, s3),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 1, 0, 0, 0, DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s5),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 5, 0, 0, 0, DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s6),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 1, 0, 0, 0, DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s2),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 2, 0, 0, 0, DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 1, 0, 0, 0, DateTimeKind.Utc), 11000.0, SaleStatus.Canceled, s2),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 12, 0, 0, 0, DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s5),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 1, 0, 0, 0, DateTimeKind.Utc), 7000.0, SaleStatus.Billed, s3),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 6, 0, 0, 0, DateTimeKind.Utc), 5000.0, SaleStatus.Billed, s4),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 6, 0, 0, 0, DateTimeKind.Utc), 9000.0, SaleStatus.Pending, s1),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 7, 0, 0, 0, DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s3),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 8, 0, 0, 0, DateTimeKind.Utc), 12000.0, SaleStatus.Billed, s5),
                new SalesRecord(Guid.NewGuid(), new DateTime(2018, 10, 12, 0, 0, 0, DateTimeKind.Utc), 5000.0, SaleStatus.Billed, s2)
            };

            _context.Department.AddRange(dp1, dp2, dp3, dp4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(records);

            _context.SaveChanges();
        }
    }
}