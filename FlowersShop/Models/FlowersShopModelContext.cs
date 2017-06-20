using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FlowersShop.Models
{    
    public partial class FlowersShopModelContext : DbContext
    {
        public FlowersShopModelContext()
            : base("name=FlowersShopModelContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commodities> Commodities { get; set; }
        public virtual DbSet<Order> Order { get; set; }

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
