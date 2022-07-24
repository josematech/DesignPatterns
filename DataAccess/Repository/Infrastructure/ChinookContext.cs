using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{

    public class ChinookContext : DbContext
    {
        private readonly string connectionString;

        public ChinookContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                // .UseLazyLoadingProxies()
                .UseSqlite(connectionString);
        }
    }
}
