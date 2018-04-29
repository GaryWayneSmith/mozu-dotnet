
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The properties of a product, referenced and used by carts, orders, wish lists, and returns.
		///
		public class Product
		{
			public List<Discount> AvailableShippingDiscounts { get; set; }

			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<BundledProduct> BundledProducts { get; set; }

			///
			///The date and time in UTC when the product is no longer active in the catalog.
			///
			public DateTime? CatalogEndDate { get; set; }

			///
			///The date and time in UTC format when the product is active in the catalog.
			///
			public DateTime? CatalogStartDate { get; set; }

			public List<Category> Categories { get; set; }

			public ProductContent Content { get; set; }

			public DateTime CreateDate { get; set; }

			///
			///The date and time in UTC format when the product first became available in the catalog. This field is used to calculate the number of days the product has been available in the catalog for a dynamic expression.
			///
			public DateTime? DateFirstAvailableInCatalog { get; set; }

			///
			///The total number of days the product has been available in the catalog. This field is related to the DaysAvailableInCatalog field in a dynamic expression.
			///
			public int? DaysAvailableInCatalog { get; set; }

			///
			///List of supported types of fulfillment for the product or variation. The types include direct ship, in-store pickup, or both.
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			///
			///The type of goods in a bundled product. A bundled product is composed of products associated to sell together. Possible values include â€œPhysicalâ€ and â€œDigitalCreditâ€. This comes from the `productType `of the product. Products are defaulted to a Physical `goodsType`. Gift cards have a `goodsType `of DigitalCredit.
			///
			public string GoodsType { get; set; }

			public ProductInventoryInfo InventoryInfo { get; set; }

			public bool? IsActive { get; set; }

			///
			///Indicates if the product must be shipped alone in a container. This is used for products and products within a bundle. If true, this product cannot be shipped in a package with other items and must ship in a package by itself.
			///
			public bool? IsPackagedStandAlone { get; set; }

			public bool IsRecurring { get; set; }

			public bool IsTaxable { get; set; }

			///
			///locationsInStock ApiType DOCUMENT_HERE 
			///
			public List<string> LocationsInStock { get; set; }

			public PackageMeasurements Measurements { get; set; }

			///
			///The manufacturer's part number for the product.
			///
			public string MfgPartNumber { get; set; }

			///
			///The list of manufacturer part numbers defined for the product.
			///
			public List<string> MfgPartNumbers { get; set; }

			public List<ProductOption> Options { get; set; }

			public ProductPrice Price { get; set; }

			public ProductPriceRange PriceRange { get; set; }

			///
			///Properties that describe the behavior the system uses when determining the price of products.
			///
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			public string ProductCode { get; set; }

			public int? ProductSequence { get; set; }

			public string ProductType { get; set; }

			///
			///The unique identifier of the product type of the product.
			///
			public int? ProductTypeId { get; set; }

			///
			///The usage type that applies to this product, which is Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle).
			///
			public string ProductUsage { get; set; }

			public List<ProductProperty> Properties { get; set; }

			public string PublishState { get; set; }

			public ProductPurchasableState PurchasableState { get; set; }

			///
			///The location where the order item(s) was purchased.
			///
			public string PurchaseLocation { get; set; }

			public string Upc { get; set; }

			///
			///The list of universal product codes defined for the product.
			///
			public List<string> UpCs { get; set; }

			///
			///The date and time in UTC format the object was updated most recently.
			///
			public DateTime UpdateDate { get; set; }

			///
			///A list of price lists for which the product is valid.
			///
			public List<string> ValidPriceLists { get; set; }

			public string VariationProductCode { get; set; }

			///
			///A summary of all variations that exist for the product.
			///
			public List<VariationSummary> Variations { get; set; }

			///
			///The details of any volume price bands associated with the product.Refer to [Volume Pricing](https://www.mozu.com/docs/guides/catalog/price-lists.htm#volume_pricing) for more information.
			///
			public List<ProductVolumePrice> VolumePriceBands { get; set; }

			///
			///The details of the volume price range associated with the product. Volume price ranges consist of a lower price and an upper price, and either lower or upper prices can be affected by discounts.You can display the volume price range on product listing pages, such as category and search result pages, and product detail pages.Refer to [Volume Pricing Storefront Behavior](https://www.mozu.com/docs/guides/catalog/price-lists.htm#volume_pricing_storefront_behavior) for more information.
			///
			public ProductPriceRange VolumePriceRange { get; set; }

		}

}