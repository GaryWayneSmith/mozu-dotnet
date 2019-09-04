
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

namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use the Orders resource to manage all components of order processing, payment, and fulfillment.
	/// </summary>
	public partial class OrderClient 	{
		
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
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrders( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  includeBin,  responseFields);
		///   var orderCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> GetOrdersClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, bool? includeBin =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetOrdersUrl(startIndex, pageSize, sortBy, filter, q, qLimit, includeBin, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the available order actions to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableActions( orderId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableActionsClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetAvailableActionsUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.PricingRuntime.TaxableOrder"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTaxableOrders( orderId);
		///   var taxableOrderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> GetTaxableOrdersClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetTaxableOrdersUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="includeBin"></param>
		/// <param name="orderId">Unique identifier of the order details to get.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrder( orderId,  draft,  includeBin,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> GetOrderClient(string orderId, bool? draft =  null, bool? includeBin =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetOrderUrl(orderId, draft, includeBin, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId">Unique identifier of the cart. This is the original cart ID expressed as a GUID.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderFromCart( cartId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderFromCartClient(string cartId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.CreateOrderFromCartUrl(cartId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="order">Properties of the order to create and submit.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrder( order,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderClient(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.CreateOrderUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>(order);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="action">The action to perform for the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformOrderAction( action,  orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformOrderActionClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.PerformOrderActionUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshShipping"></param>
		/// <param name="responseFields"></param>
		/// <param name="order"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PriceOrder( order,  refreshShipping,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PriceOrderClient(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, bool refreshShipping, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.PriceOrderUrl(refreshShipping, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>(order);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="digitalWalletType"></param>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="digitalWallet"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ProcessDigitalWallet( digitalWallet,  orderId,  digitalWalletType,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ProcessDigitalWalletClient(Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet digitalWallet, string orderId, string digitalWalletType, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ProcessDigitalWalletUrl(orderId, digitalWalletType, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet>(digitalWallet);
			return mozuClient;

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
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderDiscount( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderDiscountClient(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.UpdateOrderDiscountUrl(orderId, discountId, updateMode, version, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount>(discount);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the draft to delete.</param>
		/// <param name="version">If applicable, the version of the order draft to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderDraft( orderId,  version);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteOrderDraftClient(string orderId, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.DeleteOrderDraftUrl(orderId, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="action"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendOrderConfirmationEmail( action,  orderId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> ResendOrderConfirmationEmailClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ResendOrderConfirmationEmailUrl(orderId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction>(action);
			return mozuClient;

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
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangeOrderPriceList( priceListCode,  orderId,  updateMode,  version,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderPriceListClient(string priceListCode, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ChangeOrderPriceListUrl(orderId, updateMode, version, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(priceListCode);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangeOrderUserId( orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderUserIdClient(string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ChangeOrderUserIdUrl(orderId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

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
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrder( order,  orderId,  updateMode,  version,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderClient(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.UpdateOrderUrl(orderId, updateMode, version, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>(order);
			return mozuClient;

		}


	}

}


