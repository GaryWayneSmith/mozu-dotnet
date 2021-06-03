
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Retrieves the details of a price list. The details may contain a hierarchy of ancestor and/or descendant price lists dependening on your configuration.
	/// </summary>
	public partial class PriceListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PriceListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PriceListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PriceListResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode">The unique code of the price list for which you want to retrieve the details.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.GetPriceListAsync( priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.PriceList> GetPriceListAsync(string priceListCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var resolvedPriceList = await pricelist.GetResolvedPriceListAsync( customerAccountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> GetResolvedPriceListAsync(int? customerAccountId =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetResolvedPriceListClient( customerAccountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="customerAccountObject"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var resolvedPriceList = await pricelist.GetResolvedPriceList2Async( customerAccountObject,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> GetResolvedPriceList2Async(JObject customerAccountObject, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetResolvedPriceList2Client( customerAccountObject,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


