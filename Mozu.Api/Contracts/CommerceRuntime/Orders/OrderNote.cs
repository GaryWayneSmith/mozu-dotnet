
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

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	Properties of an order note for a merchant, which is internal only for administrative purposes and not available to the shopper.
		///
		public class OrderNote
		{
			///
			///Unique identifier of the order note.
			///
			public string Id { get; set; }

			///
			///The text content of the order note.
			///
			public string Text { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}