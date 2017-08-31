namespace FlowersShop.DAL.EF
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Context;
    using Entities;

    /// <summary>
    /// Flowers Shop database context
    /// </summary>
    public class FlowersShopEntities : DbContext
    {
        #region Constructor

        /// <summary>
        /// Initializes static members of the <see cref="FlowersShopEntities"/> class.
        /// </summary>
        static FlowersShopEntities()
        {
            Database.SetInitializer(new FlowersShopDatabaseInitizlizer());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowersShopEntities" /> class.
        /// </summary>
        public FlowersShopEntities()
            : base("FlowersShopEntities")
        {
        }

        #endregion

        #region Entity Sets

        /// <summary>
        /// Gets or sets the categories table.
        /// </summary>
        public DbSet<CategoryEntity> Categories { get; set; }

        /// <summary>
        /// Gets or sets the cities table.
        /// </summary>
        public DbSet<CityEntity> Cities { get; set; }

        /// <summary>
        /// Gets or sets the clients table.
        /// </summary>
        public DbSet<ClientEntity> Clients { get; set; }

        /// <summary>
        /// Gets or sets the commodities table.
        /// </summary>
        public DbSet<CommoditiesEntity> Commodities { get; set; }

        /// <summary>
        /// Gets or sets the orders table.
        /// </summary>
        public DbSet<OrderEntity> Orders { get; set; }

        #endregion

        /// <summary>
        /// Configure models if needed
        /// </summary>
        /// <param name="modelBuilder">model builder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            ConfigureCategory(modelBuilder);
            ConfigureCity(modelBuilder);
            ConfigureClient(modelBuilder);
            ConfigureCommodities(modelBuilder);
            ConfigureOrder(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static void ConfigureCategory(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>()
                .ToTable(FlowersShopDatabaseMetadata.CATEGORY_TABLE_NAME)
                .HasKey(t => t.Id);

            // Name
            modelBuilder.Entity<CategoryEntity>()
                .Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Category.MAX_NAME_LENGTH);

            // FK Category - Commodities
            modelBuilder.Entity<CategoryEntity>()
                .HasMany(d => d.Commodity)
                .WithRequired(d => d.Category)
                .HasForeignKey(d => d.CategoryId)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureCity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityEntity>()
                .ToTable(FlowersShopDatabaseMetadata.CITY_TABLE_NAME)
                .HasKey(t => t.Id);

            // Name
            modelBuilder.Entity<CityEntity>()
                .Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.City.MAX_NAME_LENGTH);

            // Price
            modelBuilder.Entity<CityEntity>()
                .Property(t => t.Price)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.MONEY_COLUMN_TYPE);
        }

        private static void ConfigureClient(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>()
                .ToTable(FlowersShopDatabaseMetadata.CLIENT_TABLE_NAME)
                .HasKey(t => t.Id);

            // Name
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Client.MAX_NAME_LENGTH);

            // Cellphone
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.CellPhone)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Client.MAX_CELLPHONE_LENGTH);

            // Email
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.Email)
                .IsOptional()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Client.MAX_EMAIL_LENGTH);

            // Gender
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.Gender)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Client.MAX_GENDER_NAME_LENGTH);

            // Age
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.Age)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // CityId
            modelBuilder.Entity<ClientEntity>()
                .Property(t => t.Age)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // FK Client - City
            modelBuilder.Entity<ClientEntity>()
                .HasRequired(t => t.City)
                .WithMany(p => p.LedClient)
                .HasForeignKey(t => t.CityId)
                .WillCascadeOnDelete(false);

            // FK Client -  Order
            modelBuilder.Entity<ClientEntity>()
                .HasMany(d => d.Order)
                .WithRequired(d => d.Client)
                .HasForeignKey(d => d.ClientId)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureCommodities(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommoditiesEntity>()
                .ToTable(FlowersShopDatabaseMetadata.COMMODITIES_TABLE_NAME)
                .HasKey(t => t.Id);

            // Name
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Commodities.MAX_NAME_LENGTH);

            // Colour
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.Colour)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Commodities.MAX_COLOR_LENGTH);

            // Price
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.Price)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.MONEY_COLUMN_TYPE);

            // Description
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.Description)
                .IsOptional()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Commodities.MAX_DESCRIPTION_LENGTH);

            // IsHandMade
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(u => u.IsHandMade);

            // Image path
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.ImagePath)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Commodities.MAX_IMAGE_PATH_LENGTH);

            // CategoryId
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // Preferences
            modelBuilder.Entity<CommoditiesEntity>()
                .Property(t => t.Preferences)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Commodities.MAX_PREFERECES_LENGTH);

            // FK Commodity - Category
            modelBuilder.Entity<CommoditiesEntity>()
                .HasRequired(t => t.Category)
                .WithMany(p => p.Commodity)
                .HasForeignKey(t => t.CategoryId)
                .WillCascadeOnDelete(false);

            // FK Commodity - Order
            modelBuilder.Entity<CommoditiesEntity>()
                .HasMany(d => d.Order)
                .WithRequired(d => d.Commodity)
                .HasForeignKey(d => d.CommodityId)
                .WillCascadeOnDelete(false);
        }

        private static void ConfigureOrder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>()
                .ToTable(FlowersShopDatabaseMetadata.ORDER_TABLE_NAME)
                .HasKey(t => t.Id);

            // CommodityId
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.CommodityId)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // OrderTime
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.OrderTime)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.DATE_COLUMN_TYPE);

            // Quantity
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.Quantity)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // FullPrice
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.FullPrice)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.MONEY_COLUMN_TYPE);

            // ClientId
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.ClientId)
                .IsRequired()
                .HasColumnType(FlowersShopDatabaseMetadata.INT_COLUMN_TYPE);

            // Receiver
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.Receiver)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Order.MAX_RECEIVER_LENGTH);

            // Address
            modelBuilder.Entity<OrderEntity>()
                .Property(t => t.Address)
                .IsRequired()
                .IsUnicode()
                .IsVariableLength()
                .HasMaxLength(ValidationConstants.Order.MAX_ADDRESS_LENGTH);

            // FK Order - Client
            modelBuilder.Entity<OrderEntity>()
                .HasRequired(t => t.Client)
                .WithMany(p => p.Order)
                .HasForeignKey(t => t.ClientId)
                .WillCascadeOnDelete(false);

            // FK Order - Commodity
            modelBuilder.Entity<OrderEntity>()
                .HasRequired(d => d.Commodity)
                .WithMany(d => d.Order)
                .HasForeignKey(d => d.CommodityId)
                .WillCascadeOnDelete(false);
        }
    }
}
