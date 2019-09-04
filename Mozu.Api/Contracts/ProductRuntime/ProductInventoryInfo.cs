
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of the active inventory managed for the product.
		///
		public class ProductInventoryInfo
		{
			public DateTime? AvailableDate { get; set; }

			public bool? ManageStock { get; set; }

			///
			///The location code for the direct ship location associated with the available online stock.
			///
			public string OnlineLocationCode { get; set; }

			public int? OnlineSoftStockAvailable { get; set; }

			public int? OnlineStockAvailable { get; set; }

			public string OutOfStockBehavior { get; set; }

		}

}