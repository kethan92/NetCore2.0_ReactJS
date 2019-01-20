using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Item
    {
        public Item()
        {
            Exclusivity = new HashSet<Exclusivity>();
            Item2dfeature = new HashSet<Item2dfeature>();
            Item3dfeature = new HashSet<Item3dfeature>();
            ItemBlackout = new HashSet<ItemBlackout>();
            ItemCare = new HashSet<ItemCare>();
            ItemCentury = new HashSet<ItemCentury>();
            ItemColourAndFinish = new HashSet<ItemColourAndFinish>();
            ItemGeography = new HashSet<ItemGeography>();
            ItemInStockProgram = new HashSet<ItemInStockProgram>();
            ItemKenoVideo = new HashSet<ItemKenoVideo>();
            ItemProcessAndTechnique = new HashSet<ItemProcessAndTechnique>();
            ItemShape = new HashSet<ItemShape>();
            ItemShippingStatus = new HashSet<ItemShippingStatus>();
            ItemStyle = new HashSet<ItemStyle>();
            ItemTheme = new HashSet<ItemTheme>();
            ItemType = new HashSet<ItemType>();
            LookbookItem = new HashSet<LookbookItem>();
            OrderItem = new HashSet<OrderItem>();
            RelatedItemItem = new HashSet<RelatedItem>();
            RelatedItemRelatedItemNavigation = new HashSet<RelatedItem>();
            RelatedSkuForSpecialGroup = new HashSet<RelatedSkuForSpecialGroup>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SkulistingForSizeAvailability = new HashSet<SkulistingForSizeAvailability>();
        }

        public Guid Id { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public string Story { get; set; }
        public string VariationDescription { get; set; }
        public string ExtendedDescription { get; set; }
        public string AdditionalFeatures { get; set; }
        public string ParentCode { get; set; }
        public string DefaultCode { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? RoomAndUsageId { get; set; }
        public Guid BrandId { get; set; }
        public Guid? CollectionId { get; set; }
        public Guid? PrimaryMaterialId { get; set; }
        public Guid? SecondaryMaterialId { get; set; }
        public Guid? TertiaryMaterialId { get; set; }
        public string Keywords { get; set; }
        public Guid? OptionGroupId { get; set; }
        public Guid? OptionGroup2Id { get; set; }
        public Guid? OptionGroup3Id { get; set; }
        public bool HasOtherSizes { get; set; }
        public double? Cbm { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? ChairSeatHeight { get; set; }
        public decimal? ChairArmHeight { get; set; }
        public decimal? ChairInsideSeatDepth { get; set; }
        public decimal? ChairInsideSeatWidth { get; set; }
        public Guid? MatchingArmOrSide { get; set; }
        public decimal? TableClearance { get; set; }
        public decimal? TableClosedDepth { get; set; }
        public decimal? TableClosedWidth { get; set; }
        public decimal? TableClosedHeight { get; set; }
        public int? TableLeavesCount { get; set; }
        public decimal? TableLeavesWidth { get; set; }
        public int? TablesSeatsCountClosed { get; set; }
        public int? TablesSeatsCountOpen { get; set; }
        public bool IsNew { get; set; }
        public bool? IsActive { get; set; }
        public int QuantityMultiplier { get; set; }
        public DateTime DateCreated { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public Collection Collection { get; set; }
        public OptionGroup OptionGroup { get; set; }
        public OptionGroup OptionGroup2 { get; set; }
        public OptionGroup OptionGroup3 { get; set; }
        public Material PrimaryMaterial { get; set; }
        public RoomAndUsage RoomAndUsage { get; set; }
        public Material SecondaryMaterial { get; set; }
        public Material TertiaryMaterial { get; set; }
        public ICollection<Exclusivity> Exclusivity { get; set; }
        public ICollection<Item2dfeature> Item2dfeature { get; set; }
        public ICollection<Item3dfeature> Item3dfeature { get; set; }
        public ICollection<ItemBlackout> ItemBlackout { get; set; }
        public ICollection<ItemCare> ItemCare { get; set; }
        public ICollection<ItemCentury> ItemCentury { get; set; }
        public ICollection<ItemColourAndFinish> ItemColourAndFinish { get; set; }
        public ICollection<ItemGeography> ItemGeography { get; set; }
        public ICollection<ItemInStockProgram> ItemInStockProgram { get; set; }
        public ICollection<ItemKenoVideo> ItemKenoVideo { get; set; }
        public ICollection<ItemProcessAndTechnique> ItemProcessAndTechnique { get; set; }
        public ICollection<ItemShape> ItemShape { get; set; }
        public ICollection<ItemShippingStatus> ItemShippingStatus { get; set; }
        public ICollection<ItemStyle> ItemStyle { get; set; }
        public ICollection<ItemTheme> ItemTheme { get; set; }
        public ICollection<ItemType> ItemType { get; set; }
        public ICollection<LookbookItem> LookbookItem { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<RelatedItem> RelatedItemItem { get; set; }
        public ICollection<RelatedItem> RelatedItemRelatedItemNavigation { get; set; }
        public ICollection<RelatedSkuForSpecialGroup> RelatedSkuForSpecialGroup { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ICollection<SkulistingForSizeAvailability> SkulistingForSizeAvailability { get; set; }
    }
}
