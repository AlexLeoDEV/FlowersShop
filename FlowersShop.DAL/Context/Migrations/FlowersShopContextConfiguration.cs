namespace FlowersShop.DAL.Context.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// The FlowersShop context configuration.
    /// </summary>
    internal sealed class FlowersShopContextConfiguration : DbMigrationsConfiguration<EF.FlowersShopEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowersShopContextConfiguration"/> class.
        /// </summary>
        public FlowersShopContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Context\Migrations";
            ContextKey = "FlowersShop.DAL.Context.EF.FlowersShopEntities";
        }

        /// <summary>
        /// This method will be called after migrating to the latest version.
        /// </summary>
        /// <param name="context">FlowersShop context</param>
        protected override void Seed(EF.FlowersShopEntities context)
        {
            SeedDataGenerator.GenerateDebugEntities(context);
        }
    }
}
