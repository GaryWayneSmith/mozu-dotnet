
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Fulfillment resource to manage shipments or pickups of collections of packages for an order.
	/// </summary>
	public partial class FulfillmentActionClient 	{
		
		/// <summary>
		/// Sets the fulfillment action to "Ship" or "PickUp". To ship an order or prepare it for in-store pickup, the order must have a customer name, the "Open" or "OpenAndProcessing" status. To ship the order, it must also have the full shipping address and shipping method. Shipping all packages or picking up all pickups for an order will complete a paid order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to perform the fulfillment action.</param>
		/// <param name="responseFields">Updated order with a new fulfillment status resulting from the action supplied in the request.</param>
		/// <param name="action">The action to perform for the order fulfillment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformFulfillmentAction( action,  orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformFulfillmentActionClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.FulfillmentActionUrl.PerformFulfillmentActionUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="action"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendPackageFulfillmentEmail( action,  orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ResendPackageFulfillmentEmailClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.FulfillmentActionUrl.ResendPackageFulfillmentEmailUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction>(action);
			return mozuClient;

		}


	}

}


