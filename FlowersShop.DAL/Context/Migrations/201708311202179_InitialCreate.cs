namespace FlowersShop.DAL.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Commodities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Colour = c.String(nullable: false, maxLength: 30),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Description = c.String(maxLength: 50),
                        IsHandMade = c.Boolean(nullable: false),
                        ImagePath = c.String(nullable: false, maxLength: 50),
                        CategoryId = c.Int(nullable: false),
                        Preferences = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommodityId = c.Int(nullable: false),
                        OrderTime = c.DateTime(nullable: false, storeType: "date"),
                        Quantity = c.Int(nullable: false),
                        FullPrice = c.Decimal(nullable: false, storeType: "money"),
                        ClientId = c.Int(nullable: false),
                        Receiver = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Commodities", t => t.CommodityId)
                .Index(t => t.CommodityId)
                .Index(t => t.ClientId);

            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CellPhone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 15),
                        Gender = c.String(nullable: false, maxLength: 15),
                        Age = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Commodities", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Orders", "CommodityId", "dbo.Commodities");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "CityId", "dbo.Cities");
            DropIndex("dbo.Clients", new[] { "CityId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.Orders", new[] { "CommodityId" });
            DropIndex("dbo.Commodities", new[] { "CategoryId" });
            DropTable("dbo.Cities");
            DropTable("dbo.Clients");
            DropTable("dbo.Orders");
            DropTable("dbo.Commodities");
            DropTable("dbo.Categories");
        }
    }
}
