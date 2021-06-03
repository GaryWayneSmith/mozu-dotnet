
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
	/// Use the Returns resource to manage returned items that were previously fufilled. Returns can include any number of items associated with an original  order. Each return must either be associated with an original order or a product definition to represent each returned item.Refer to the [Returns API](https://www.mozu.com/docs/developer/api-guides/returns.htm) topic for more information about creating and processing returns using the API.
	/// </summary>
	public partial class ReturnClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturns( startIndex,  pageSize,  sortBy,  filter,  q,  responseFields);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> GetReturnsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnsUrl(startIndex, pageSize, sortBy, filter, q, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableReturnActions( returnId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableReturnActionsClient(string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailableReturnActionsUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnItemId">Unique identifier of the return item whose details you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnItem( returnId,  returnItemId,  responseFields);
		///   var returnItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem> GetReturnItemClient(string returnId, string returnItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnItemUrl(returnId, returnItemId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnItems( returnId,  responseFields);
		///   var returnItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection> GetReturnItemsClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnItemsUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePaymentActionsForReturn( returnId,  paymentId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePaymentActionsForReturnClient(string returnId, string paymentId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailablePaymentActionsForReturnUrl(returnId, paymentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayment( returnId,  paymentId,  responseFields);
		///   var paymentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentClient(string returnId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentUrl(returnId, paymentId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayments( returnId,  responseFields);
		///   var paymentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentsUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnLabel( returnId,  responseFields);
		///   var generateLabelResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse> GetReturnLabelClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnLabelUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturn( returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> GetReturnClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReasons( responseFields);
		///   var reasonCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection> GetReasonsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReasonsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="ret">Properties of a return of one or more previously fulfilled items.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturn( ret,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnItem">Properties of a previously fulfilled item associated with a return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturnItem( returnItem,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnItemClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem returnItem, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnItemUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem>(returnItem);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="action">Properties of the payment action performed for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformPaymentActionForReturn( action,  returnId,  paymentId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> PerformPaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformPaymentActionForReturnUrl(returnId, paymentId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="action">Properties of the payment action performed for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePaymentActionForReturn( action,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreatePaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreatePaymentActionForReturnUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <param name="returnItems"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RestockReturnItems( returnItems,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> RestockReturnItemsClient(List<Mozu.Api.Contracts.CommerceRuntime.Returns.RestockableReturnItem> returnItems, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.RestockReturnItemsUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Returns.RestockableReturnItem>>(returnItems);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="itemQuantities"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturnShippingOrder( itemQuantities,  returnId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateReturnShippingOrderClient(List<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemSpecifier> itemQuantities, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnShippingOrderUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemSpecifier>>(itemQuantities);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="action">Properties of an action a user can perform for a return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformReturnActions( action,  responseFields);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> PerformReturnActionsClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformReturnActionsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="ret">Properties of a return of one or more previously fulfilled items.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateReturn( ret,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> UpdateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.UpdateReturnUrl(returnId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="action">Properties of an action a user can perform for a return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendReturnEmail( action);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> ResendReturnEmailClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.ResendReturnEmailUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnItemId">Unique identifier of the return item whose details you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderItem( returnId,  returnItemId);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> DeleteOrderItemClient(string returnId, string returnItemId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.DeleteOrderItemUrl(returnId, returnItemId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteReturn( returnId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteReturnClient(string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.DeleteReturnUrl(returnId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


