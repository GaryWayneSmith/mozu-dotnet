
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Facets resource to manage the facets shoppers use to filter product display results on a storefront. Facets can include categories, product attributes, or prices, and use either a range of values or discrete values.
	/// </summary>
	public partial class FacetResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public FacetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public FacetResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new FacetResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = await facet.GetFacetAsync( facetId,  validate,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Facet> GetFacetAsync(int facetId, bool? validate =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.FacetClient.GetFacetClient( facetId,  validate,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="includeAvailable">If true, returns a list of the attributes and categories associated with a product type that have not been defined as a facet for the category.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.FacetSet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facetSet = await facet.GetFacetCategoryListAsync( categoryId,  includeAvailable,  validate,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.FacetSet> GetFacetCategoryListAsync(int categoryId, bool? includeAvailable =  null, bool? validate =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.FacetSet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.FacetClient.GetFacetCategoryListClient( categoryId,  includeAvailable,  validate,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="facet">Properties of the facet used to retrieve documents.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = await facet.AddFacetAsync( facet,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Facet> AddFacetAsync(Mozu.Api.Contracts.ProductAdmin.Facet facet, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.FacetClient.AddFacetClient( facet,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="facet">Properties of the facet used to retrieve documents.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = await facet.UpdateFacetAsync( facet,  facetId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Facet> UpdateFacetAsync(Mozu.Api.Contracts.ProductAdmin.Facet facet, int facetId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.FacetClient.UpdateFacetClient( facet,  facetId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var stream = await facet.DeleteFacetByIdAsync( facetId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteFacetByIdAsync(int facetId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.FacetClient.DeleteFacetByIdClient( facetId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


