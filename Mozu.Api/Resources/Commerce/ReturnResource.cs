
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
	/// Use the Returns resource to manage returned items that were previously fufilled. Returns can include any number of items associated with an original Mozu order. Each return must either be associated with an original order or a product definition to represent each returned item.
	/// </summary>
	public partial class ReturnResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ReturnResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ReturnResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ReturnResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="q"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var returnCollection = await return.GetReturnsAsync( startIndex,  pageSize,  sortBy,  filter,  q,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> GetReturnsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnsClient( startIndex,  pageSize,  sortBy,  filter,  q,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId">Unique identifier of the return for which to retrieve available actions.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var string = await return.GetAvailableReturnActionsAsync( returnId);
		/// </code>
		/// </example>
		public virtual async Task<List<string>> GetAvailableReturnActionsAsync(string returnId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetAvailableReturnActionsClient( returnId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <param name="returnItemId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var returnItem = await return.GetReturnItemAsync( returnId,  returnItemId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem> GetReturnItemAsync(string returnId, string returnItemId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnItemClient( returnId,  returnItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var returnItemCollection = await return.GetReturnItemsAsync( returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection> GetReturnItemsAsync(string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnItemsClient( returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var string = await return.GetAvailablePaymentActionsForReturnAsync( returnId,  paymentId);
		/// </code>
		/// </example>
		public virtual async Task<List<string>> GetAvailablePaymentActionsForReturnAsync(string returnId, string paymentId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetAvailablePaymentActionsForReturnClient( returnId,  paymentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var payment = await return.GetPaymentAsync( returnId,  paymentId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentAsync(string returnId, string paymentId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetPaymentClient( returnId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Returns the details of the refund payment associated with the return specified in the request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var paymentCollection = await return.GetPaymentsAsync( returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsAsync(string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetPaymentsClient( returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var generateLabelResponse = await return.GetReturnLabelAsync( returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse> GetReturnLabelAsync(string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Kibo.Cars.Model.GenerateLabelResponse> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnLabelClient( returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Returns the properties of the return specified in the request as well as system-supplied information.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.GetReturnAsync( returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> GetReturnAsync(string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnClient( returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var reasonCollection = await return.GetReasonsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection> GetReasonsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.GetReasonsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="ret">Wrapper for the properties of the return to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.CreateReturnAsync( ret,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnAsync(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.CreateReturnClient( ret,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <param name="returnItem"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.CreateReturnItemAsync( returnItem,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnItemAsync(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem returnItem, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.CreateReturnItemClient( returnItem,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return associated with the refund payment.</param>
		/// <param name="action">The payment action to perform for the refund payment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.PerformPaymentActionForReturnAsync( action,  returnId,  paymentId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> PerformPaymentActionForReturnAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string paymentId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.PerformPaymentActionForReturnClient( action,  returnId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return associated with the payment action.</param>
		/// <param name="action">The payment action to perform for the customer return.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.CreatePaymentActionForReturnAsync( action,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreatePaymentActionForReturnAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.CreatePaymentActionForReturnClient( action,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <param name="returnItems"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.RestockReturnItemsAsync( returnItems,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> RestockReturnItemsAsync(List<Mozu.Api.Contracts.CommerceRuntime.Returns.RestockableReturnItem> returnItems, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.RestockReturnItemsClient( returnItems,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <param name="itemQuantities"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var order = await return.CreateReturnShippingOrderAsync( itemQuantities,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateReturnShippingOrderAsync(List<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemSpecifier> itemQuantities, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.CreateReturnShippingOrderClient( itemQuantities,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="action">The name of the return action to perform, such as "Reject" or "Authorize".</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var returnCollection = await return.PerformReturnActionsAsync( action,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> PerformReturnActionsAsync(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.PerformReturnActionsClient( action,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return.</param>
		/// <param name="ret">Wrapper for the array of properties to update for the return.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.UpdateReturnAsync( ret,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> UpdateReturnAsync(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.UpdateReturnClient( ret,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var stream = await return.ResendReturnEmailAsync( action);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> ResendReturnEmailAsync(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.ResendReturnEmailClient( action);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId"></param>
		/// <param name="returnItemId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var return = await return.DeleteOrderItemAsync( returnId,  returnItemId);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> DeleteOrderItemAsync(string returnId, string returnItemId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.DeleteOrderItemClient( returnId,  returnItemId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId">Unique identifier of the return to delete.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var return = new Return();
		///   var stream = await return.DeleteReturnAsync( returnId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteReturnAsync(string returnId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.ReturnClient.DeleteReturnClient( returnId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


