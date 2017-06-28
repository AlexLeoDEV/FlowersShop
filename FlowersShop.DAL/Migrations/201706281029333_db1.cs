namespace FlowersShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.City", "id_Client");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "id_Client", c => c.Int());
        }
    }
}
