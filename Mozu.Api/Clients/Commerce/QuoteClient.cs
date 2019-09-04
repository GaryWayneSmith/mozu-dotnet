
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
	/// 
	/// </summary>
	public partial class QuoteClient 	{
		
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
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetQuotes( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		///   var quoteCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection> GetQuotesClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.GetQuotesUrl(startIndex, pageSize, sortBy, filter, q, qLimit, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.QuoteCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetQuote( quoteId,  responseFields);
		///   var quoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> GetQuoteClient(string quoteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.GetQuoteUrl(quoteId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="quoteName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetQuoteByName( customerAccountId,  quoteName,  responseFields);
		///   var quoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> GetQuoteByNameClient(int customerAccountId, string quoteName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.GetQuoteByNameUrl(customerAccountId, quoteName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="quote"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateQuote( quote,  responseFields);
		///   var quoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> CreateQuoteClient(Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote quote, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.CreateQuoteUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>(quote);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <param name="responseFields"></param>
		/// <param name="quote"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateQuote( quote,  quoteId,  responseFields);
		///   var quoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote> UpdateQuoteClient(Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote quote, string quoteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.UpdateQuoteUrl(quoteId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Quotes.Quote>(quote);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="quoteId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteQuote( quoteId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteQuoteClient(string quoteId)
		{
			var url = Mozu.Api.Urls.Commerce.QuoteUrl.DeleteQuoteUrl(quoteId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


