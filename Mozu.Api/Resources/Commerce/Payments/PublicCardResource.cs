
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

namespace Mozu.Api.Resources.Commerce.Payments
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PublicCardResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PublicCardResource() 
		{
			_apiContext = null;
		}
		 public PublicCardResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PublicCardResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PublicCardResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = publiccard.Create( request);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.PaymentService.Response.SyncResponse Create(Mozu.Api.Contracts.PaymentService.PublicCard request)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.CreateClient( request);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = await publiccard.CreateAsync( request);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> CreateAsync(Mozu.Api.Contracts.PaymentService.PublicCard request)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.CreateClient( request);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId"></param>
		/// <param name="request"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = publiccard.Update( request,  cardId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.PaymentService.Response.SyncResponse Update(Mozu.Api.Contracts.PaymentService.PublicCard request, string cardId)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.UpdateClient( request,  cardId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId"></param>
		/// <param name="request"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = await publiccard.UpdateAsync( request,  cardId);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> UpdateAsync(Mozu.Api.Contracts.PaymentService.PublicCard request, string cardId)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.UpdateClient( request,  cardId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   publiccard.Delete( cardId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void Delete(string cardId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.DeleteClient( cardId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   await publiccard.DeleteAsync( cardId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAsync(string cardId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.DeleteClient( cardId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


