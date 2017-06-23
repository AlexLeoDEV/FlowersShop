using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.DAL.EF
{
    public class FlowersShopContext: DbContext
    {
        public FlowersShopContext(string connectionString)
        : base(connectionString)
        {
        }

        public FlowersShopContext()
            : base("name=FlowersShopContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commodities> Commodities { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Commodities>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.FullPrice)
                .HasPrecision(19, 4);
        }
    }
}
