using Microsoft.EntityFrameworkCore;

namespace ProductApi.Models
{
    public class ProductContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=jeanstation;user id=sa; password=Pass@123; trustservercertificate=true");
        }
    }
}
