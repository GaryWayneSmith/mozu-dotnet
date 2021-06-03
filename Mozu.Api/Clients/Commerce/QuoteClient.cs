
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
	/// Quotes support the eCommerce B2B feature by providing functionality similar to that of standard wishlists. However, comments can be added to quotes to provide clearer information to other users accessing the quote through the shared B2B account. These basic APIs provide the ability to create new quotes, update them, and retrieve their information.These APIs are currently a work-in-progress and will be enhanced in the future as more functionality such as setting fixed prices, setting expiration, etc. is released. The current models may change and break backwards compatibility, so use caution if interacting with these APIs for now.
	/// </summary>
	public partial class QuoteClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
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
		/// <param name="quoteId">A unique identifier for the quote.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
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
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="quoteName">A unique name for the quote.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
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
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="quote">The quote being created.</param>
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
		/// <param name="quoteId">A unique identifier for the quote being updated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="quote">The quote that is being updated.</param>
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
		/// <param name="quoteId">A unique identifier for the quote.</param>
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

