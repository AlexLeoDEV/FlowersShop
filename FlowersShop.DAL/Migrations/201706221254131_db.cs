namespace FlowersShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        id_Category = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id_Category);
            
            CreateTable(
                "dbo.Commodities",
                c => new
                    {
                        id_Commodities = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Colour = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Description = c.String(nullable: false),
                        IsHandMade = c.Boolean(nullable: false),
                        id_Category = c.Int(nullable: false),
                        image = c.String(nullable: false),
                        Preferences = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_Commodities)
                .ForeignKey("dbo.Category", t => t.id_Category, cascadeDelete: true)
                .Index(t => t.id_Category);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        id_Order = c.Int(nullable: false, identity: true),
                        id_Commodities = c.Int(),
                        OrderTime = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        FullPrice = c.Decimal(nullable: false, storeType: "money"),
                        id_Client = c.Int(),
                        Receiver = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id_Order)
                .ForeignKey("dbo.Client", t => t.id_Client)
                .ForeignKey("dbo.Commodities", t => t.id_Commodities)
                .Index(t => t.id_Commodities)
                .Index(t => t.id_Client);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        id_Client = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CellPhone = c.String(nullable: false, maxLength: 13),
                        Email = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(maxLength: 50),
                        Age = c.Int(),
                        id_City = c.Int(),
                    })
                .PrimaryKey(t => t.id_Client)
                .ForeignKey("dbo.City", t => t.id_City)
                .Index(t => t.id_City);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        id_City = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        id_Client = c.Int(),
                    })
                .PrimaryKey(t => t.id_City);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "id_Commodities", "dbo.Commodities");
            DropForeignKey("dbo.Order", "id_Client", "dbo.Client");
            DropForeignKey("dbo.Client", "id_City", "dbo.City");
            DropForeignKey("dbo.Commodities", "id_Category", "dbo.Category");
            DropIndex("dbo.Client", new[] { "id_City" });
            DropIndex("dbo.Order", new[] { "id_Client" });
            DropIndex("dbo.Order", new[] { "id_Commodities" });
            DropIndex("dbo.Commodities", new[] { "id_Category" });
            DropTable("dbo.City");
            DropTable("dbo.Client");
            DropTable("dbo.Order");
            DropTable("dbo.Commodities");
            DropTable("dbo.Category");
        }
    }
}
