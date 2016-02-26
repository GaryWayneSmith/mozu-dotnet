
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of the target to which the discount applies, such as the type of discount and which products, categories, or shipping methods are eligible for the discount and the properties of this discount target.
		///
		public class DiscountTarget
		{
			///
			///Determines which way the discount is optimized. Consumers favor(default - false/null) or tenants favor (when this is set to true) Applies to discounts where target is not a specific product or list of products. May also impact behavior of Buy X Get Y so that X is the most expensive items and Y the least expensive.
			///
			public bool? AppliesToLeastExpensiveProductsFirst { get; set; }

			///
			///The list of all categories associated with the product. These categories contain products, can have discounts associated, and define the grouping of products to display on the storefront.
			///
			public List<TargetedCategory> Categories { get; set; }

			///
			///List of the product categories that are not eligible for the discount.
			///
			public List<TargetedCategory> ExcludedCategories { get; set; }

			///
			///Applies to Included categories Defaults to Any
			///
			public string ExcludedCategoriesOperator { get; set; }

			///
			///List of products that are not eligible for the discount.
			///
			public List<TargetedProduct> ExcludedProducts { get; set; }

			///
			///Prevents order scoped discounts from layering over items that already have a product discount with the same type.
			///
			public bool? ExcludeItemsWithExistingProductDiscounts { get; set; }

			///
			///Prevents order scoped discounts from layering over items that already have a shipping discount with the same type.
			///
			public bool? ExcludeItemsWithExistingShippingDiscounts { get; set; }

			///
			///If true, the target discount applies to all products sold on the site, regardless of product category.
			///
			public bool? IncludeAllProducts { get; set; }

			///
			///Applies to Included categories Defaults to Any
			///
			public string IncludedCategoriesOperator { get; set; }

			///
			///When a condition is specified, this property limits the number of items that are targeted for each discount redemption with an order. If multiple redemptions are allowed for each order then multiples of this value are allowed in multiples of the associated condition. If no condition is specified, then this value is not used. If null and condition exists, then defaults to 1.
			///
			public int? MaximumQuantityPerRedemption { get; set; }

			///
			///List of  product codes that represent the products to which the discount can apply.
			///
			public List<TargetedProduct> Products { get; set; }

			///
			///The list of shipping method codes that represents the shipping service types to which the discount can apply.
			///
			public List<TargetedShippingMethod> ShippingMethods { get; set; }

			///
			///The list of shipping zones that are applicable for this discount.
			///
			public List<TargetedShippingZone> ShippingZones { get; set; }

			///
			///Properties of the object to which this discount is targeted, which can be Product or Shipping. If the discount type is Product, the target properties describe the product or product categories to which the discount applies. If the discount type is Shipping, the target properties describe the shipping methods eligible for the discount.
			///
			public string Type { get; set; }

		}

}