
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	A hold placed on product inventory for a particular product so that the quantity specified is set aside and available for purchase during the ordering process.
		///
		public class ProductReservation
		{
			///
			///Identifier of the entity.
			///
			public int? Id { get; set; }

			///
			///Code that identifies the location associated with this product reservation.
			///
			public string LocationCode { get; set; }

			///
			///Unique identifier of the order.
			///
			public string OrderId { get; set; }

			///
			///The unique identifier of the item in the order.
			///
			public string OrderItemId { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///The quantity of items associated with the product reservation.
			///
			public int Quantity { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}