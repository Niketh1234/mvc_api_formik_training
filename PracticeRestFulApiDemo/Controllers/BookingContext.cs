using Microsoft.EntityFrameworkCore;
using PracticeRestFulApiDemo.Models;

namespace PracticeRestFulApiDemo.Controllers
{
    public class BookingContext: DbContext
    {
        public DbSet<Details> BookingDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=bookings;user id=sa;password=Pass@123;trustservercertificate=true");
        }
    }
}
