
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The difference between the base price for the product and this variation of the product, which can be a positive or negative decimal value. For example, if the base price for a t-shirt product is $10, but the XL variation should cost $12, the DeltaPrice value should be "2". However, if the XS variation should only cost $8, the DeltaPrice value should be "-2".
		///
		public class ProductVariationDeltaPrice
		{
			///
			///The credit amount for the product.
			///
			public decimal? CreditValue { get; set; }

			public string CurrencyCode { get; set; }

			///
			///The manufacturer's suggested retail price, as defined by the supplier.
			///
			public decimal? Msrp { get; set; }

			public decimal? Value { get; set; }

		}

}