namespace FlowersShop.DAL.Context
{
    /// <summary>
    /// Provides various DB names
    /// </summary>
    internal static class FlowersShopDatabaseMetadata
    {
        #region tables data types

        public const string DATE_COLUMN_TYPE = "date";

        public const string MONEY_COLUMN_TYPE = "money";

        public const string INT_COLUMN_TYPE = "int";

        public const string SMALL_INT_COLUMN_TYPE = "smallint";

        #endregion

        #region tables names

        public const string CATEGORY_TABLE_NAME = "Categories";

        public const string CITY_TABLE_NAME = "Cities";

        public const string CLIENT_TABLE_NAME = "Clients";

        public const string COMMODITIES_TABLE_NAME = "Commodities";

        public const string ORDER_TABLE_NAME = "Orders";

        #endregion

        #region foreign keys

        #endregion
    }
}
