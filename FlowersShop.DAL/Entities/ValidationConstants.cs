namespace FlowersShop.DAL.Entities
{
    /// <summary>
    /// Database validation constraints
    /// </summary>
    internal class ValidationConstants
    {
        /// <summary>
        /// Category entity validation constants
        /// </summary>
        public static class Category
        {
            public const int MAX_NAME_LENGTH = 60;
        }

        /// <summary>
        /// City entity validation constants
        /// </summary>
        public static class City
        {
            public const int MAX_NAME_LENGTH = 30;
        }

        /// <summary>
        /// Client entity validation constants
        /// </summary>
        public static class Client
        {
            public const int MAX_NAME_LENGTH = 30;

            public const int MAX_CELLPHONE_LENGTH = 15;

            public const int MAX_EMAIL_LENGTH = 15;

            public const int MAX_GENDER_NAME_LENGTH = 15;
        }

        /// <summary>
        /// Commodities entity validation constants
        /// </summary>
        public static class Commodities
        {
            public const int MAX_NAME_LENGTH = 30;

            public const int MAX_COLOR_LENGTH = 30;

            public const int MAX_DESCRIPTION_LENGTH = 50;

            public const int MAX_PREFERECES_LENGTH = 50;

            public const int MAX_IMAGE_PATH_LENGTH = 50;
        }

        /// <summary>
        /// Order entity validation constants
        /// </summary>
        public static class Order
        {
            public const int MAX_RECEIVER_LENGTH = 50;

            public const int MAX_ADDRESS_LENGTH = 50;
        }
    }
}
