
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


namespace Mozu.Api.Contracts.PaymentService
{
		public class OrderItem
		{
			public List<CustomData> CustomData { get; set; }

			public string Id { get; set; }

			public Product Product { get; set; }

			public int Quantity { get; set; }

			public decimal? TaxAmount { get; set; }

			public decimal? TotalAmount { get; set; }

			public decimal? UnitPrice { get; set; }

		}

}