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
        //static FlowersShopContext()
        //{
        //    Database.SetInitializer<FlowersShopContext>(new StoreDbInitializer());
        //}

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
        //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<FlowersShopContext>
        //{
        //    protected override void Seed(FlowersShopContext db)
        //    {
        //        db.Commodities.Add(new Commodities { id_Category = 3, Title = "Roses", Colour = "Red", Price = 350, Preferences = "Beloved", IsHandMade = false, Description = "Red roses" });
        //        db.Commodities.Add(new Commodities { id_Category = 3, Title = "Tulips", Colour = "Yellow", Price = 150, Preferences = "Kid", IsHandMade = false, Description = "Yellow tulips" });
        //        db.Commodities.Add(new Commodities { id_Category = 4, Title = "Basket", Colour = "Mixed", Price = 2500, Preferences = "Colleague", IsHandMade = false, Description = "Just baskets" });
        //        db.Commodities.Add(new Commodities { id_Category = 1, Title = "Composition", Colour = "Chebur", Price = 1350, Preferences = "Mom", IsHandMade = false, Description = "Chuburashka" });

        //        db.Categories.Add(new Category { Title = "Flower composition" });
        //        db.Categories.Add(new Category { Title = "Mono bouquet" });
        //        db.Categories.Add(new Category { Title = "Bouquet" });
        //        db.Categories.Add(new Category { Title = "Flower basket" });

        //        db.Clients.Add(new Client { id_City = 1, Name = "Admin", Age = 24, Gender = "M", Email = "email", CellPhone = "095366888" });

        //        db.Cities.Add(new City { id_Client = 1, Price = 500, Title = "Dnipro" });

        //        db.SaveChanges();
        //    }
        //}
    }
}
