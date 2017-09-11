namespace FlowersShop.DAL.Context
{
    using System.Data.Entity;
    using EF;
    using Migrations;

    /// <summary>
    /// The FlowersShop DB initializer.
    /// </summary>
    internal class FlowersShopDatabaseInitizlizer
        : MigrateDatabaseToLatestVersion<FlowersShopEntities, FlowersShopContextConfiguration>
    {
    }
}
