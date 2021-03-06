
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
	/// 
	/// </summary>
	public partial class QuoteResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public QuoteResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public QuoteResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new QuoteResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="q"></param>
		/// <param name="qLimit"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   var quoteCollection = await quote.GetQuotesAsync( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection> GetQuotesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection> response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.GetQuotesClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   var quote = await quote.GetQuoteAsync( quoteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> GetQuoteAsync(string quoteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.GetQuoteClient( quoteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="quoteName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   var quote = await quote.GetQuoteByNameAsync( customerAccountId,  quoteName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> GetQuoteByNameAsync(int customerAccountId, string quoteName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.GetQuoteByNameClient( customerAccountId,  quoteName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="quote"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   var quote = await quote.CreateQuoteAsync( quote,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> CreateQuoteAsync(Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote quote, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.CreateQuoteClient( quote,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <param name="responseFields"></param>
		/// <param name="quote"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   var quote = await quote.UpdateQuoteAsync( quote,  quoteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> UpdateQuoteAsync(Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote quote, string quoteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.UpdateQuoteClient( quote,  quoteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var quote = new Quote();
		///   await quote.DeleteQuoteAsync( quoteId);
		/// </code>
		/// </example>
		public virtual async Task DeleteQuoteAsync(string quoteId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.QuoteClient.DeleteQuoteClient( quoteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


