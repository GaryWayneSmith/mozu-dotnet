
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Fulfillment resource to manage shipments or pickups of collections of packages for an order.
	/// </summary>
	public partial class FulfillmentActionResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public FulfillmentActionResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public FulfillmentActionResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new FulfillmentActionResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Sets the fulfillment action to "Ship" or "PickUp". To ship an order or prepare it for in-store pickup, the order must have a customer name, the "Open" or "OpenAndProcessing" status. To ship the order, it must also have the full shipping address and shipping method. Shipping all packages or picking up all pickups for an order will complete a paid order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="action">Properties of an action to perform when fulfilling an item in an order, whether through in-store pickup or direct shipping.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentaction = new FulfillmentAction();
		///   var order = fulfillmentaction.PerformFulfillmentAction( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformFulfillmentAction(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentActionClient.PerformFulfillmentActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Sets the fulfillment action to "Ship" or "PickUp". To ship an order or prepare it for in-store pickup, the order must have a customer name, the "Open" or "OpenAndProcessing" status. To ship the order, it must also have the full shipping address and shipping method. Shipping all packages or picking up all pickups for an order will complete a paid order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="action">Properties of an action to perform when fulfilling an item in an order, whether through in-store pickup or direct shipping.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentaction = new FulfillmentAction();
		///   var order = await fulfillmentaction.PerformFulfillmentActionAsync( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformFulfillmentActionAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentActionClient.PerformFulfillmentActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// orders-fulfillment Post ResendPackageFulfillmentEmail description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="action">Properties of an action to perform when fulfilling an item in an order, whether through in-store pickup or direct shipping.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentaction = new FulfillmentAction();
		///   var order = fulfillmentaction.ResendPackageFulfillmentEmail( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ResendPackageFulfillmentEmail(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentActionClient.ResendPackageFulfillmentEmailClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// orders-fulfillment Post ResendPackageFulfillmentEmail description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="action">Properties of an action to perform when fulfilling an item in an order, whether through in-store pickup or direct shipping.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentaction = new FulfillmentAction();
		///   var order = await fulfillmentaction.ResendPackageFulfillmentEmailAsync( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ResendPackageFulfillmentEmailAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentActionClient.ResendPackageFulfillmentEmailClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


