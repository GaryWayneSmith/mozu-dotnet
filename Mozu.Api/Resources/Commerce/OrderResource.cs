
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
using System.Threading;

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Orders resource to manage all components of order processing, payment, and fulfillment.
	/// </summary>
	public partial class OrderResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter an order's search results by any of its properties, including status, contact information, or total. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=Status+eq+Submitted"</param>
		/// <param name="includeBin"></param>
		/// <param name="pageSize">Used to page results from a query. Indicates the maximum number of entities to return from a query. Default value: 20. Max value: 200.</param>
		/// <param name="q">A list of order search terms to use in the query when searching across order number and the name or email of the billing contact. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The element to sort the results by and the order in which the results appear. Either ascending order (a-z) which accepts 'asc' or 'asc' or descending order (z-a) which accepts 'desc' or 'desc'. The sortBy parameter follows an available property. For examp</param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var orderCollection = await order.GetOrdersAsync( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  includeBin,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> GetOrdersAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, bool? includeBin =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrdersClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  includeBin,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the available order actions to get.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var string = await order.GetAvailableActionsAsync( orderId);
		/// </code>
		/// </example>
		public virtual async Task<List<string>> GetAvailableActionsAsync(string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetAvailableActionsClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to retrieve.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.PricingRuntime.TaxableOrder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var taxableOrder = await order.GetTaxableOrdersAsync( orderId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> GetTaxableOrdersAsync(string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetTaxableOrdersClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="includeBin"></param>
		/// <param name="orderId">Unique identifier of the order details to get.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.GetOrderAsync( orderId,  draft,  includeBin,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> GetOrderAsync(string orderId, bool? draft =  null, bool? includeBin =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrderClient( orderId,  draft,  includeBin,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId">Unique identifier of the cart. This is the original cart ID expressed as a GUID.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.CreateOrderFromCartAsync( cartId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderFromCartAsync(string cartId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderFromCartClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="order">Properties of the order to create and submit.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.CreateOrderAsync( order,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderClient( order,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="action">The action to perform for the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.PerformOrderActionAsync( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformOrderActionAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.PerformOrderActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshShipping"></param>
		/// <param name="responseFields"></param>
		/// <param name="order"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.PriceOrderAsync( order,  refreshShipping,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PriceOrderAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, bool refreshShipping, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.PriceOrderClient( order,  refreshShipping,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="digitalWalletType"></param>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="digitalWallet"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.ProcessDigitalWalletAsync( digitalWallet,  orderId,  digitalWalletType,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ProcessDigitalWalletAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet digitalWallet, string orderId, string digitalWalletType, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ProcessDigitalWalletClient( digitalWallet,  orderId,  digitalWalletType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order discount. System-supplied and read only.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to modify the discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version"></param>
		/// <param name="discount">Properties of the order discount to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.UpdateOrderDiscountAsync( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderDiscountAsync(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderDiscountClient( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the draft to delete.</param>
		/// <param name="version">If applicable, the version of the order draft to delete.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var stream = await order.DeleteOrderDraftAsync( orderId,  version);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteOrderDraftAsync(string orderId, string version =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.DeleteOrderDraftClient( orderId,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var stream = await order.ResendOrderConfirmationEmailAsync( action,  orderId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> ResendOrderConfirmationEmailAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ResendOrderConfirmationEmailClient( action,  orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="priceListCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.ChangeOrderPriceListAsync( priceListCode,  orderId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderPriceListAsync(string priceListCode, string orderId, string updateMode =  null, string version =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderPriceListClient( priceListCode,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.ChangeOrderUserIdAsync( orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderUserIdAsync(string orderId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderUserIdClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version"></param>
		/// <param name="order">The properties of the order to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = await order.UpdateOrderAsync( order,  orderId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderClient( order,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


