using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TA.Data
{
    public partial class Html5Context : DbContext
    {
        public Html5Context(DbContextOptions<Html5Context> options) : base(options) { }

        public virtual DbSet<_2dfeature> _2dfeature { get; set; }
        public virtual DbSet<_3dfeature> _3dfeature { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BrandBlackout> BrandBlackout { get; set; }
        public virtual DbSet<Care> Care { get; set; }
        public virtual DbSet<CatalogRequest> CatalogRequest { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Century> Century { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<ColourAndFinish> ColourAndFinish { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryBlackList> CountryBlackList { get; set; }
        public virtual DbSet<Dealer> Dealer { get; set; }
        public virtual DbSet<DealerGroupRegion> DealerGroupRegion { get; set; }
        public virtual DbSet<DealerShippingAddress> DealerShippingAddress { get; set; }
        public virtual DbSet<DealerStore> DealerStore { get; set; }
        public virtual DbSet<DealerTaus> DealerTaus { get; set; }
        public virtual DbSet<DesignerTaus> DesignerTaus { get; set; }
        public virtual DbSet<DynamicTable> DynamicTable { get; set; }
        public virtual DbSet<Exclusivity> Exclusivity { get; set; }
        public virtual DbSet<ExclusivityGroup> ExclusivityGroup { get; set; }
        public virtual DbSet<Geography> Geography { get; set; }
        public virtual DbSet<GeoLite2CityLocations> GeoLite2CityLocations { get; set; }
        public virtual DbSet<GeoLiteCityLocation> GeoLiteCityLocation { get; set; }
        public virtual DbSet<ImageExistingStatus> ImageExistingStatus { get; set; }
        public virtual DbSet<IpblackList> IpblackList { get; set; }
        public virtual DbSet<IpwhiteList> IpwhiteList { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Item2dfeature> Item2dfeature { get; set; }
        public virtual DbSet<Item3dfeature> Item3dfeature { get; set; }
        public virtual DbSet<ItemBlackout> ItemBlackout { get; set; }
        public virtual DbSet<ItemCare> ItemCare { get; set; }
        public virtual DbSet<ItemCentury> ItemCentury { get; set; }
        public virtual DbSet<ItemColourAndFinish> ItemColourAndFinish { get; set; }
        public virtual DbSet<ItemGeography> ItemGeography { get; set; }
        public virtual DbSet<ItemInStockProgram> ItemInStockProgram { get; set; }
        public virtual DbSet<ItemKenoVideo> ItemKenoVideo { get; set; }
        public virtual DbSet<ItemOptionDescription> ItemOptionDescription { get; set; }
        public virtual DbSet<ItemPrice> ItemPrice { get; set; }
        public virtual DbSet<ItemPriceLog> ItemPriceLog { get; set; }
        public virtual DbSet<ItemProcessAndTechnique> ItemProcessAndTechnique { get; set; }
        public virtual DbSet<ItemShape> ItemShape { get; set; }
        public virtual DbSet<ItemShippingStatus> ItemShippingStatus { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemStyle> ItemStyle { get; set; }
        public virtual DbSet<ItemTau> ItemTau { get; set; }
        public virtual DbSet<ItemTheme> ItemTheme { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<KenoVideo> KenoVideo { get; set; }
        public virtual DbSet<Lookbook> Lookbook { get; set; }
        public virtual DbSet<LookbookItem> LookbookItem { get; set; }
        public virtual DbSet<LookbookShared> LookbookShared { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialCategory> MaterialCategory { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<OptionGroup> OptionGroup { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderItemShippingStatus> OrderItemShippingStatus { get; set; }
        public virtual DbSet<ProcessAndTechnique> ProcessAndTechnique { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RelatedItem> RelatedItem { get; set; }
        public virtual DbSet<RelatedSkuForSpecialGroup> RelatedSkuForSpecialGroup { get; set; }
        public virtual DbSet<RoomAndUsage> RoomAndUsage { get; set; }
        public virtual DbSet<SalesAssociate> SalesAssociate { get; set; }
        public virtual DbSet<SalesAssociateStore> SalesAssociateStore { get; set; }
        public virtual DbSet<Search> Search { get; set; }
        public virtual DbSet<Shape> Shape { get; set; }
        public virtual DbSet<ShippingStatus> ShippingStatus { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<ShoppingCartItemShippingStatus> ShoppingCartItemShippingStatus { get; set; }
        public virtual DbSet<SkulistingForSizeAvailability> SkulistingForSizeAvailability { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreBrand> StoreBrand { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<SubCollection> SubCollection { get; set; }
        public virtual DbSet<Synonym> Synonym { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<Tmp4SyncItemStatusTai> Tmp4SyncItemStatusTai { get; set; }
        public virtual DbSet<Tmp4SyncItemStatusTaus> Tmp4SyncItemStatusTaus { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=html5;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_2dfeature>(entity =>
            {
                entity.ToTable("2Dfeature");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_3dfeature>(entity =>
            {
                entity.ToTable("3Dfeature");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_City");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrandBlackout>(entity =>
            {
                entity.HasKey(e => new { e.BrandId, e.CountryId });

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandBlackout)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrandBlackout_Brand");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.BrandBlackout)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrandBlackout_Country");
            });

            modelBuilder.Entity<Care>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContentBody).HasColumnType("text");

                entity.Property(e => e.ContentImageS7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogRequest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.Arm).HasMaxLength(500);

                entity.Property(e => e.Back).HasMaxLength(500);

                entity.Property(e => e.Base).HasMaxLength(500);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(500);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(500);

                entity.Property(e => e.ConfirmId).HasColumnName("confirmID");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(500);

                entity.Property(e => e.Currentcustomer).HasColumnName("currentcustomer");

                entity.Property(e => e.Cushion).HasMaxLength(500);

                entity.Property(e => e.Customertype)
                    .HasColumnName("customertype")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(500);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(500);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsConfirm).HasColumnName("isConfirm");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(500);

                entity.Property(e => e.Leg).HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(500);

                entity.Property(e => e.Sendmailresult)
                    .HasColumnName("sendmailresult")
                    .HasMaxLength(500);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(500);

                entity.Property(e => e.Store).HasMaxLength(500);

                entity.Property(e => e.Style).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(500);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Century>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Name, e.Latitude, e.Longitude, e.Population, e.Timezone, e.Gmtoffset, e.RegionId })
                    .HasName("_dta_index_City_7_823673982__K2_1_3_4_5_6_7_8");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gmtoffset)
                    .HasColumnName("GMToffset")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Latitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Region");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Collection)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Collection_Brand");
            });

            modelBuilder.Entity<ColourAndFinish>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AreaSqrKm).HasColumnName("AreaSqrKM");

                entity.Property(e => e.Capital)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Continent)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ContinentId).HasColumnName("Continent_ID");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fips)
                    .IsRequired()
                    .HasColumnName("fips")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Iso)
                    .IsRequired()
                    .HasColumnName("ISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Iso3)
                    .IsRequired()
                    .HasColumnName("ISO3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Isonumeric).HasColumnName("ISONumeric");

                entity.Property(e => e.Languages)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeFormat)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeRegex)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tld)
                    .IsRequired()
                    .HasColumnName("tld")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContinentNavigation)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.ContinentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_Continent");
            });

            modelBuilder.Entity<CountryBlackList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryBlackList)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryBlacklist_Country");
            });

            modelBuilder.Entity<Dealer>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.ExclusivityGroupId, e.BillingAddressId, e.DefaultShippingAddressId, e.ShowSkus, e.ShowPrice, e.ShowAddress, e.UserId })
                    .HasName("_dta_index_Dealer_7_797961919__K2_1_3_4_5_6_7_8");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_ID");

                entity.Property(e => e.DefaultShippingAddressId).HasColumnName("DefaultShippingAddress_ID");

                entity.Property(e => e.ExclusivityGroupId).HasColumnName("ExclusivityGroup_ID");

                entity.Property(e => e.ShowSkus).HasColumnName("ShowSKUs");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.DealerBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_Dealer_Address");

                entity.HasOne(d => d.DefaultShippingAddress)
                    .WithMany(p => p.DealerDefaultShippingAddress)
                    .HasForeignKey(d => d.DefaultShippingAddressId)
                    .HasConstraintName("FK_Dealer_Address1");

                entity.HasOne(d => d.ExclusivityGroup)
                    .WithMany(p => p.Dealer)
                    .HasForeignKey(d => d.ExclusivityGroupId)
                    .HasConstraintName("FK_Dealer_ExclusivityGroup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Dealer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dealer_User");
            });

            modelBuilder.Entity<DealerGroupRegion>(entity =>
            {
                entity.HasKey(e => new { e.Dealergroup, e.Region });

                entity.ToTable("DealerGroup_Region");

                entity.Property(e => e.Dealergroup)
                    .HasColumnName("dealergroup")
                    .HasMaxLength(50);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DealerShippingAddress>(entity =>
            {
                entity.HasKey(e => new { e.DealerId, e.ShippingAddressId });

                entity.ToTable("Dealer_ShippingAddress");

                entity.Property(e => e.DealerId).HasColumnName("Dealer_ID");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_ID");

                entity.HasOne(d => d.Dealer)
                    .WithMany(p => p.DealerShippingAddress)
                    .HasForeignKey(d => d.DealerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dealer_ShippingAddress_Dealer");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.DealerShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dealer_ShippingAddress_Address");
            });

            modelBuilder.Entity<DealerStore>(entity =>
            {
                entity.HasKey(e => new { e.DealerId, e.StoreId });

                entity.ToTable("Dealer_Store");

                entity.HasIndex(e => e.StoreId)
                    .HasName("_dta_index_Dealer_Store_7_299148111__K3");

                entity.Property(e => e.DealerId).HasColumnName("Dealer_ID");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.HasOne(d => d.Dealer)
                    .WithMany(p => p.DealerStore)
                    .HasForeignKey(d => d.DealerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dealer_Store_Dealer");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DealerStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dealer_Store");
            });

            modelBuilder.Entity<DealerTaus>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TausId });

                entity.ToTable("Dealer_Taus");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.TausId)
                    .HasColumnName("TausID")
                    .HasMaxLength(50);

                entity.Property(e => e.TausName).HasMaxLength(500);
            });

            modelBuilder.Entity<DesignerTaus>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TausId, e.DesignerType });

                entity.ToTable("Designer_Taus");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.TausId)
                    .HasColumnName("TausID")
                    .HasMaxLength(50);

                entity.Property(e => e.DesignerType).HasMaxLength(50);

                entity.Property(e => e.TausName).HasMaxLength(500);
            });

            modelBuilder.Entity<DynamicTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnValue).HasMaxLength(500);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Exclusivity>(entity =>
            {
                entity.HasKey(e => new { e.ExclusivityGroupId, e.ItemId });

                entity.Property(e => e.ExclusivityGroupId).HasColumnName("ExclusivityGroup_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.HasOne(d => d.ExclusivityGroup)
                    .WithMany(p => p.Exclusivity)
                    .HasForeignKey(d => d.ExclusivityGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exclusivity_ExclusivityGroup");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Exclusivity)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exclusivity_Item");
            });

            modelBuilder.Entity<ExclusivityGroup>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_ExclusivityGroup")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Geography>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeoLite2CityLocations>(entity =>
            {
                entity.HasKey(e => e.GeonameId);

                entity.Property(e => e.GeonameId)
                    .HasColumnName("geoname_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContinentCode)
                    .HasColumnName("continent_code")
                    .HasMaxLength(255);

                entity.Property(e => e.ContinentName)
                    .HasColumnName("continent_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryIsoCode)
                    .HasColumnName("country_iso_code")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MetroCode)
                    .HasColumnName("metro_code")
                    .HasMaxLength(255);

                entity.Property(e => e.SubdivisionIsoCode).HasColumnName("subdivision_iso_code");

                entity.Property(e => e.SubdivisionName)
                    .HasColumnName("subdivision_name")
                    .HasMaxLength(255);

                entity.Property(e => e.TimeZone)
                    .HasColumnName("time_zone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GeoLiteCityLocation>(entity =>
            {
                entity.HasKey(e => e.LocId);

                entity.HasIndex(e => e.Country)
                    .HasName("_dta_index_GeoLiteCityLocation_7_496720822__K2");

                entity.HasIndex(e => new { e.Region, e.City, e.PostalCode, e.Latitude, e.Longitude, e.Country, e.LocId })
                    .HasName("_dta_index_GeoLiteCityLocation_7_496720822__K2_K1_3_4_5_6_7");

                entity.HasIndex(e => new { e.Region, e.City, e.PostalCode, e.Latitude, e.Longitude, e.LocId, e.Country })
                    .HasName("_dta_index_GeoLiteCityLocation_7_496720822__K1_K2_3_4_5_6_7");

                entity.Property(e => e.LocId)
                    .HasColumnName("locId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasColumnName("areaCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.MetroCode)
                    .HasColumnName("metroCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageExistingStatus>(entity =>
            {
                entity.HasKey(e => e.Url);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IpblackList>(entity =>
            {
                entity.ToTable("IPBlackList");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IpwhiteList>(entity =>
            {
                entity.ToTable("IPWhiteList");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("_dta_index_Item_7_787533889__K1");

                entity.HasIndex(e => e.IsActive)
                    .HasName("_dta_index_Item_7_787533889__K39");

                entity.HasIndex(e => e.Sku)
                    .HasName("IX_Item")
                    .IsUnique();

                entity.HasIndex(e => new { e.CategoryId, e.Id })
                    .HasName("_dta_index_Item_7_787533889__K11_K1");

                entity.HasIndex(e => new { e.Sku, e.DefaultCode })
                    .HasName("_dta_index_Item_8_787533889__K2_K10");

                entity.HasIndex(e => new { e.CategoryId, e.BrandId, e.Id })
                    .HasName("_dta_index_Item_7_787533889__K11_K13_K1");

                entity.HasIndex(e => new { e.CategoryId, e.CollectionId, e.Id })
                    .HasName("_dta_index_Item_7_787533889__K11_K14_K1");

                entity.HasIndex(e => new { e.CollectionId, e.IsActive, e.CategoryId })
                    .HasName("_dta_index_Item_7_787533889__K14_K39_K11");

                entity.HasIndex(e => new { e.IsActive, e.BrandId, e.CategoryId })
                    .HasName("_dta_index_Item_7_787533889__K39_K13_K11");

                entity.HasIndex(e => new { e.IsActive, e.Id, e.CategoryId })
                    .HasName("_dta_index_Item_7_787533889__K39_K1_K11");

                entity.HasIndex(e => new { e.CollectionId, e.IsActive, e.Id, e.CategoryId })
                    .HasName("_dta_index_Item_7_787533889__K39_K1_K11_14");

                entity.HasIndex(e => new { e.ParentCode, e.OptionGroupId, e.OptionGroup2Id, e.Sku, e.Id })
                    .HasName("_dta_index_Item_7_787533889__K19_K20_K2_K1_9");

                entity.HasIndex(e => new { e.ParentCode, e.IsActive, e.Sku, e.OptionGroupId, e.OptionGroup2Id, e.Id })
                    .HasName("_dta_index_Item_7_787533889__K39_K2_K19_K20_K1_9");

                entity.HasIndex(e => new { e.ParentCode, e.OptionGroup2Id, e.IsActive, e.Id, e.OptionGroupId, e.Sku })
                    .HasName("_dta_index_Item_7_787533889__K20_K39_K1_K19_K2_9");

                entity.HasIndex(e => new { e.Sku, e.ProductName, e.VariationDescription, e.ParentCode, e.Depth, e.Width, e.Height, e.IsNew, e.QuantityMultiplier, e.CategoryId, e.BrandId, e.IsActive, e.DefaultCode, e.RoomAndUsageId, e.Id, e.CollectionId })
                    .HasName("_dta_index_Item_7_787533889__K11_K13_K39_K10_K12_K1_K14_2_3_6_9_24_25_26_38_40");

                entity.HasIndex(e => new { e.Sku, e.ProductName, e.VariationDescription, e.ParentCode, e.Depth, e.Width, e.Height, e.IsNew, e.QuantityMultiplier, e.CategoryId, e.CollectionId, e.IsActive, e.DefaultCode, e.RoomAndUsageId, e.Id, e.BrandId })
                    .HasName("_dta_index_Item_7_787533889__K11_K14_K39_K10_K12_K1_K13_2_3_6_9_24_25_26_38_40");

                entity.HasIndex(e => new { e.Sku, e.ProductName, e.VariationDescription, e.ParentCode, e.Depth, e.Width, e.Height, e.IsNew, e.QuantityMultiplier, e.CollectionId, e.IsActive, e.DefaultCode, e.RoomAndUsageId, e.Id, e.BrandId, e.CategoryId })
                    .HasName("_dta_index_Item_7_787533889__K14_K39_K10_K12_K1_K13_K11_2_3_6_9_24_25_26_38_40");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalFeatures).HasColumnType("ntext");

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Cbm).HasColumnName("CBM");

                entity.Property(e => e.ChairArmHeight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ChairInsideSeatDepth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ChairInsideSeatWidth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ChairSeatHeight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ExtendedDescription)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Height).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords).HasColumnType("ntext");

                entity.Property(e => e.OptionGroup2Id).HasColumnName("OptionGroup2_ID");

                entity.Property(e => e.OptionGroup3Id).HasColumnName("OptionGroup3_ID");

                entity.Property(e => e.OptionGroupId).HasColumnName("OptionGroup_ID");

                entity.Property(e => e.ParentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PrimaryMaterialId).HasColumnName("PrimaryMaterial_ID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityMultiplier).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoomAndUsageId).HasColumnName("RoomAndUsage_ID");

                entity.Property(e => e.SecondaryMaterialId).HasColumnName("SecondaryMaterial_ID");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Story).HasColumnType("ntext");

                entity.Property(e => e.TableClearance).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TableClosedDepth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TableClosedHeight).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TableClosedWidth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TableLeavesWidth).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TertiaryMaterialId).HasColumnName("TertiaryMaterial_ID");

                entity.Property(e => e.VariationDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Category");

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("FK_Item_Collection");

                entity.HasOne(d => d.OptionGroup2)
                    .WithMany(p => p.ItemOptionGroup2)
                    .HasForeignKey(d => d.OptionGroup2Id)
                    .HasConstraintName("FK_Item_OptionGroup1");

                entity.HasOne(d => d.OptionGroup3)
                    .WithMany(p => p.ItemOptionGroup3)
                    .HasForeignKey(d => d.OptionGroup3Id)
                    .HasConstraintName("FK_Item_OptionGroup2");

                entity.HasOne(d => d.OptionGroup)
                    .WithMany(p => p.ItemOptionGroup)
                    .HasForeignKey(d => d.OptionGroupId)
                    .HasConstraintName("FK_Item_OptionGroup");

                entity.HasOne(d => d.PrimaryMaterial)
                    .WithMany(p => p.ItemPrimaryMaterial)
                    .HasForeignKey(d => d.PrimaryMaterialId)
                    .HasConstraintName("FK_Item_Material");

                entity.HasOne(d => d.RoomAndUsage)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.RoomAndUsageId)
                    .HasConstraintName("FK_Item_RoomAndUsage");

                entity.HasOne(d => d.SecondaryMaterial)
                    .WithMany(p => p.ItemSecondaryMaterial)
                    .HasForeignKey(d => d.SecondaryMaterialId)
                    .HasConstraintName("FK_Item_Material1");

                entity.HasOne(d => d.TertiaryMaterial)
                    .WithMany(p => p.ItemTertiaryMaterial)
                    .HasForeignKey(d => d.TertiaryMaterialId)
                    .HasConstraintName("FK_Item_Material2");
            });

            modelBuilder.Entity<Item2dfeature>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e._2dfeatureId });

                entity.ToTable("Item_2Dfeature");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e._2dfeatureId).HasColumnName("2Dfeature_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Item2dfeature)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_2Dfeature_Item");

                entity.HasOne(d => d._2dfeature)
                    .WithMany(p => p.Item2dfeature)
                    .HasForeignKey(d => d._2dfeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_2Dfeature_2Dfeature");
            });

            modelBuilder.Entity<Item3dfeature>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e._3dfeatureId });

                entity.ToTable("Item_3Dfeature");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e._3dfeatureId).HasColumnName("3Dfeature_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Item3dfeature)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_3Dfeature_Item");

                entity.HasOne(d => d._3dfeature)
                    .WithMany(p => p.Item3dfeature)
                    .HasForeignKey(d => d._3dfeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_3Dfeature_3Dfeature");
            });

            modelBuilder.Entity<ItemBlackout>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.CountryId });

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ItemBlackout)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemBlackout_Country");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemBlackout)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemBlackout_Item");
            });

            modelBuilder.Entity<ItemCare>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.CareId });

                entity.ToTable("Item_Care");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.CareId).HasColumnName("Care_ID");

                entity.HasOne(d => d.Care)
                    .WithMany(p => p.ItemCare)
                    .HasForeignKey(d => d.CareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Care_Care");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemCare)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Care_Item");
            });

            modelBuilder.Entity<ItemCentury>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.CenturyId });

                entity.ToTable("Item_Century");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.CenturyId).HasColumnName("Century_ID");

                entity.HasOne(d => d.Century)
                    .WithMany(p => p.ItemCentury)
                    .HasForeignKey(d => d.CenturyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Century_Century");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemCentury)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Century_Item");
            });

            modelBuilder.Entity<ItemColourAndFinish>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ColourAndFinishId });

                entity.ToTable("Item_ColourAndFinish");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ColourAndFinishId).HasColumnName("ColourAndFinish_ID");

                entity.HasOne(d => d.ColourAndFinish)
                    .WithMany(p => p.ItemColourAndFinish)
                    .HasForeignKey(d => d.ColourAndFinishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ColourAndFinish_ColourAndFinish");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemColourAndFinish)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ColourAndFinish_Item");
            });

            modelBuilder.Entity<ItemGeography>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.GeographyId });

                entity.ToTable("Item_Geography");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.GeographyId).HasColumnName("Geography_ID");

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.ItemGeography)
                    .HasForeignKey(d => d.GeographyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Geography_Geography");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemGeography)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Geography_Item");
            });

            modelBuilder.Entity<ItemInStockProgram>(entity =>
            {
                entity.ToTable("Item_InStockProgram");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemInStockProgram)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_InStockProgram_Item");
            });

            modelBuilder.Entity<ItemKenoVideo>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.KenoVideoId });

                entity.ToTable("Item_KenoVideo");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.KenoVideoId).HasColumnName("KenoVideo_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemKenoVideo)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_KenoVideo_Item");

                entity.HasOne(d => d.KenoVideo)
                    .WithMany(p => p.ItemKenoVideo)
                    .HasForeignKey(d => d.KenoVideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_KenoVideo_KenoVideo");
            });

            modelBuilder.Entity<ItemOptionDescription>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Item_OptionDescription");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.OptionDescription)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.Region });

                entity.ToTable("Item_Price");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<ItemPriceLog>(entity =>
            {
                entity.ToTable("item_price_log");

                entity.Property(e => e.ItemPriceLogId).HasColumnName("ITEM_PRICE_LOG_ID");

                entity.Property(e => e.BatchId).HasColumnName("batchID");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalPrice)
                    .HasColumnName("localPrice")
                    .HasColumnType("numeric(20, 4)");

                entity.Property(e => e.LocalSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Parent)
                    .IsRequired()
                    .HasColumnName("parent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Skuprice)
                    .HasColumnName("SKUPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ItemProcessAndTechnique>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ProcessAndTechniqueId });

                entity.ToTable("Item_ProcessAndTechnique");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ProcessAndTechniqueId).HasColumnName("ProcessAndTechnique_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemProcessAndTechnique)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ProcessAndTechnique_Item");

                entity.HasOne(d => d.ProcessAndTechnique)
                    .WithMany(p => p.ItemProcessAndTechnique)
                    .HasForeignKey(d => d.ProcessAndTechniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ProcessAndTechnique_ProcessAndTechnique");
            });

            modelBuilder.Entity<ItemShape>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ShapeId });

                entity.ToTable("Item_Shape");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ShapeId).HasColumnName("Shape_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemShape)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Shape_Item");

                entity.HasOne(d => d.Shape)
                    .WithMany(p => p.ItemShape)
                    .HasForeignKey(d => d.ShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Shape_Shape");
            });

            modelBuilder.Entity<ItemShippingStatus>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ShippingStatusId });

                entity.ToTable("Item_ShippingStatus");

                entity.HasIndex(e => new { e.ItemId, e.Quantity })
                    .HasName("_dta_index_Item_ShippingStatus_7_381244413__K1_K3");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ShippingStatusId).HasColumnName("ShippingStatus_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemShippingStatus)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ShippingStatus_Item");

                entity.HasOne(d => d.ShippingStatus)
                    .WithMany(p => p.ItemShippingStatus)
                    .HasForeignKey(d => d.ShippingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ShippingStatus_ShippingStatus");
            });

            modelBuilder.Entity<ItemStatus>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.Region });

                entity.ToTable("Item_Status");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemStyle>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.StyleId });

                entity.ToTable("Item_Style");

                entity.HasIndex(e => e.StyleId)
                    .HasName("_dta_index_Item_Style_7_1973582069__K2");

                entity.HasIndex(e => new { e.StyleId, e.ItemId })
                    .HasName("_dta_index_Item_Style_7_1973582069__K2_K1");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.StyleId).HasColumnName("Style_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemStyle)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Style_Item");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.ItemStyle)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Style_Style");
            });

            modelBuilder.Entity<ItemTau>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Item_TAU");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ItemTheme>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ThemeId });

                entity.ToTable("Item_Theme");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ThemeId).HasColumnName("Theme_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTheme)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Theme_Item");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ItemTheme)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Theme_Theme");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.TypeId });

                entity.ToTable("Item_Type");

                entity.HasIndex(e => e.TypeId)
                    .HasName("_dta_index_Item_Type_7_1781581385__K2");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemType)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Type_Item");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ItemType)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Type_Type");
            });

            modelBuilder.Entity<KenoVideo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContentBody).HasColumnType("text");

                entity.Property(e => e.ContentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentVideoS7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lookbook>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Lookbook)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lookbook_User");
            });

            modelBuilder.Entity<LookbookItem>(entity =>
            {
                entity.HasKey(e => new { e.LookbookId, e.ItemId });

                entity.ToTable("Lookbook_Item");

                entity.Property(e => e.LookbookId).HasColumnName("Lookbook_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.LookbookItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lookbook_Item_Item");

                entity.HasOne(d => d.Lookbook)
                    .WithMany(p => p.LookbookItem)
                    .HasForeignKey(d => d.LookbookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lookbook_Item_Lookbook");
            });

            modelBuilder.Entity<LookbookShared>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromUserId).HasColumnName("FromUser_ID");

                entity.Property(e => e.IncludeNotes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LookbookId).HasColumnName("Lookbook_ID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.LookbookShared)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookbookShared_User");

                entity.HasOne(d => d.Lookbook)
                    .WithMany(p => p.LookbookShared)
                    .HasForeignKey(d => d.LookbookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookbookShared_Lookbook");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasIndex(e => new { e.MaterialCategoryId, e.Name })
                    .HasName("IX_Material")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategory_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaterialCategory)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.MaterialCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Material_MaterialCategory");
            });

            modelBuilder.Entity<MaterialCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OptionGroupId).HasColumnName("OptionGroup_ID");

                entity.HasOne(d => d.OptionGroup)
                    .WithMany(p => p.Option)
                    .HasForeignKey(d => d.OptionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Option_OptionGroup");
            });

            modelBuilder.Entity<OptionGroup>(entity =>
            {
                entity.HasIndex(e => e.GroupName)
                    .HasName("IX_OptionGroup")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContainerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSubmitted).HasColumnType("smalldatetime");

                entity.Property(e => e.DealerId).HasColumnName("Dealer_ID");

                entity.Property(e => e.ShippingAddress1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCityId).HasColumnName("ShippingCity_ID");

                entity.Property(e => e.ShippingInstructions).HasColumnType("text");

                entity.Property(e => e.ShippingPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dealer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.DealerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Dealer");

                entity.HasOne(d => d.ShippingCity)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ShippingCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_City1");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ItemId });

                entity.ToTable("Order_Item");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Item_Item");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Item_Order");
            });

            modelBuilder.Entity<OrderItemShippingStatus>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ItemId, e.ShippingStatusId });

                entity.ToTable("Order_Item_ShippingStatus");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ShippingStatusId).HasColumnName("ShippingStatus_ID");

                entity.HasOne(d => d.ShippingStatus)
                    .WithMany(p => p.OrderItemShippingStatus)
                    .HasForeignKey(d => d.ShippingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Item_ShippingStatus_ShippingStatus");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.OrderItemShippingStatus)
                    .HasForeignKey(d => new { d.OrderId, d.ItemId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Item_ShippingStatus_Order_Item");
            });

            modelBuilder.Entity<ProcessAndTechnique>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContentBody).HasColumnType("text");

                entity.Property(e => e.ContentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentVideoS7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_Country");
            });

            modelBuilder.Entity<RelatedItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.RelatedItemId });

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.RelatedItemId).HasColumnName("RelatedItem_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.RelatedItemItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedItem_Item");

                entity.HasOne(d => d.RelatedItemNavigation)
                    .WithMany(p => p.RelatedItemRelatedItemNavigation)
                    .HasForeignKey(d => d.RelatedItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedItem_Item1");
            });

            modelBuilder.Entity<RelatedSkuForSpecialGroup>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.Sku });

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.RelatedSkuForSpecialGroup)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedSKUforSpecialGroupOnly_Item");
            });

            modelBuilder.Entity<RoomAndUsage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesAssociate>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SalesAssociate)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesAssociate_User1");
            });

            modelBuilder.Entity<SalesAssociateStore>(entity =>
            {
                entity.HasKey(e => e.SalesAssociateId);

                entity.ToTable("SalesAssociate_Store");

                entity.Property(e => e.SalesAssociateId)
                    .HasColumnName("SalesAssociate_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.HasOne(d => d.SalesAssociate)
                    .WithOne(p => p.SalesAssociateStore)
                    .HasForeignKey<SalesAssociateStore>(d => d.SalesAssociateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesAssociate_Store_SalesAssociate1");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.SalesAssociateStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesAssociate_Store");
            });

            modelBuilder.Entity<Search>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Sku })
                    .HasName("_dta_index_Search_7_1780917416__K1_K2");

                entity.HasIndex(e => new { e.AllInclusive, e.Sku, e.Id })
                    .HasName("_dta_index_Search_7_1780917416__K2_K1_32");

                entity.HasIndex(e => new { e.Id, e.Sku, e.DefaultCode })
                    .HasName("_dta_index_Search_8_1780917416__K2_K14_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllInclusive).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.Cares).HasMaxLength(500);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Centuries).HasMaxLength(500);

                entity.Property(e => e.Collection).HasMaxLength(50);

                entity.Property(e => e.ColourAndFinishes).HasMaxLength(500);

                entity.Property(e => e.DefaultCode).HasMaxLength(50);

                entity.Property(e => e.Geographies).HasMaxLength(500);

                entity.Property(e => e.OptionGroup).HasMaxLength(50);

                entity.Property(e => e.OptionGroup2).HasMaxLength(50);

                entity.Property(e => e.OptionGroup3).HasMaxLength(50);

                entity.Property(e => e.ParentCode).HasMaxLength(50);

                entity.Property(e => e.PrimaryMaterial).HasMaxLength(50);

                entity.Property(e => e.ProcessAndTechniques).HasMaxLength(500);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoomAndUsage).HasMaxLength(50);

                entity.Property(e => e.SecondaryMaterial).HasMaxLength(50);

                entity.Property(e => e.Shapes).HasMaxLength(500);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Styles).HasMaxLength(500);

                entity.Property(e => e.TertiaryMaterial).HasMaxLength(50);

                entity.Property(e => e.Themes).HasMaxLength(500);

                entity.Property(e => e.Types).HasMaxLength(500);

                entity.Property(e => e._2dfeatures)
                    .HasColumnName("2Dfeatures")
                    .HasMaxLength(500);

                entity.Property(e => e._3dfeatures)
                    .HasColumnName("3Dfeatures")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Shape>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DeliveryState)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTime)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateOrderCreated).HasColumnType("datetime");

                entity.Property(e => e.DealerId).HasColumnName("Dealer_ID");

                entity.HasOne(d => d.Dealer)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.DealerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Dealer");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.HasKey(e => new { e.ShoppingCartId, e.ItemId });

                entity.ToTable("ShoppingCart_Item");

                entity.HasIndex(e => new { e.ShoppingCartId, e.ItemId })
                    .HasName("IX_ShoppingCart_Item")
                    .IsUnique();

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCart_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Item_Item");

                entity.HasOne(d => d.ShoppingCart)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ShoppingCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Item_ShoppingCart");
            });

            modelBuilder.Entity<ShoppingCartItemShippingStatus>(entity =>
            {
                entity.HasKey(e => new { e.ShoppingCartId, e.ItemId, e.ShippingStatusId });

                entity.ToTable("ShoppingCart_Item_ShippingStatus");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCart_ID");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ShippingStatusId).HasColumnName("ShippingStatus_ID");

                entity.HasOne(d => d.ShippingStatus)
                    .WithMany(p => p.ShoppingCartItemShippingStatus)
                    .HasForeignKey(d => d.ShippingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Item_ShippingStatus_ShippingStatus");

                entity.HasOne(d => d.ShoppingCartItem)
                    .WithMany(p => p.ShoppingCartItemShippingStatus)
                    .HasForeignKey(d => new { d.ShoppingCartId, d.ItemId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Item_ShippingStatus_ShoppingCart_Item1");
            });

            modelBuilder.Entity<SkulistingForSizeAvailability>(entity =>
            {
                entity.ToTable("SKUListingForSizeAvailability");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SkulistingForSizeAvailability)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SKUlistingForSizeAvailability_Item");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Store_City");
            });

            modelBuilder.Entity<StoreBrand>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.BrandId });

                entity.ToTable("Store_Brand");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.StoreBrand)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Store_Brand_Brand");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreBrand)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Store_Brand_Store");
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.Property(e => e.CollectionId)
                    .HasColumnName("Collection_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.ParentCollectionId).HasColumnName("ParentCollection_ID");

                entity.HasOne(d => d.Collection)
                    .WithOne(p => p.SubCollection)
                    .HasForeignKey<SubCollection>(d => d.CollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCollection_Collection");
            });

            modelBuilder.Entity<Synonym>(entity =>
            {
                entity.HasKey(e => new { e.SearchTerm, e.Match });

                entity.Property(e => e.SearchTerm)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Match)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tmp4SyncItemStatusTai>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("tmp4Sync_Item_Status_tai");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(250);
            });

            modelBuilder.Entity<Tmp4SyncItemStatusTaus>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("tmp4Sync_Item_Status_taus");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(250);
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Type)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Type_Category");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("IX_User_User")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserType_ID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_User_City");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
