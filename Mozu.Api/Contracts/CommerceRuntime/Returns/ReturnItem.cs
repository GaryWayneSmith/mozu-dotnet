
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

using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Products;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of a previously fulfilled item associated with a return.
		///
		public class ReturnItem
		{
			///
			///Properties of a collection of component products that make up a single returned product bundle with its own product code.
			///
			public List<ReturnBundle> BundledProducts { get; set; }

			public bool? ExcludeProductExtras { get; set; }

			///
			///Unique identifier of the return whose items you want to get.
			///
			public string Id { get; set; }

			public List<OrderNote> Notes { get; set; }

			public string OrderItemId { get; set; }

			public string OrderItemOptionAttributeFQN { get; set; }

			public int? OrderLineId { get; set; }

			public Product Product { get; set; }

			public decimal? ProductLossAmount { get; set; }

			public decimal? ProductLossTaxAmount { get; set; }

			public int QuantityReceived { get; set; }

			public int? QuantityReplaced { get; set; }

			public int QuantityRestockable { get; set; }

			public int QuantityRestocked { get; set; }

			public int QuantityShipped { get; set; }

			public List<ReturnReason> Reasons { get; set; }

			public string ReceiveStatus { get; set; }

			public decimal? RefundAmount { get; set; }

			public string RefundStatus { get; set; }

			public string ReplaceStatus { get; set; }

			public bool ReturnNotRequired { get; set; }

			public string ReturnType { get; set; }

			public int? ShipmentItemId { get; set; }

			public int? ShipmentNumber { get; set; }

			public decimal? ShippingLossAmount { get; set; }

			public decimal? ShippingLossTaxAmount { get; set; }

			public decimal? TotalWithoutWeightedShippingAndHandling { get; set; }

			public decimal? TotalWithWeightedShippingAndHandling { get; set; }

		}

}