
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
	/// 
	/// </summary>
	public partial class SearchResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SearchResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SearchResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SearchResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.GetSearchTuningRuleAsync( searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> GetSearchTuningRuleAsync(string searchTuningRuleCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleClient( searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRuleCollection = await search.GetSearchTuningRulesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> GetSearchTuningRulesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRuleSortFields = await search.GetSearchTuningRuleSortFieldsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> GetSearchTuningRuleSortFieldsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleSortFieldsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.GetSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> GetSettingsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinitionCollection = await search.GetSynonymDefinitionCollectionAsync( localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> GetSynonymDefinitionCollectionAsync(string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSynonymDefinitionCollectionClient( localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinitionPagedCollection = await search.GetSynonymDefinitionsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionPagedCollection> GetSynonymDefinitionsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSynonymDefinitionsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="synonymId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinition = await search.GetSynonymDefinitionAsync( synonymId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> GetSynonymDefinitionAsync(int synonymId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSynonymDefinitionClient( synonymId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleIn"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.AddSearchTuningRuleAsync( searchTuningRuleIn,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> AddSearchTuningRuleAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.AddSearchTuningRuleClient( searchTuningRuleIn,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleSortFieldsIn"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRuleSortFields = await search.UpdateSearchTuningRuleSortFieldsAsync( searchTuningRuleSortFieldsIn,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> UpdateSearchTuningRuleSortFieldsAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields searchTuningRuleSortFieldsIn, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleSortFieldsClient( searchTuningRuleSortFieldsIn,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="collection"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinitionCollection = await search.UpdateSynonymDefinitionCollectionAsync( collection,  localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> UpdateSynonymDefinitionCollectionAsync(Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection collection, string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSynonymDefinitionCollectionClient( collection,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="synonymDefinition"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinition = await search.AddSynonymDefinitionAsync( synonymDefinition,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> AddSynonymDefinitionAsync(Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition synonymDefinition, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.AddSynonymDefinitionClient( synonymDefinition,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleCode"></param>
		/// <param name="searchTuningRuleIn"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.UpdateSearchTuningRuleAsync( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> UpdateSearchTuningRuleAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string searchTuningRuleCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleClient( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="settings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.UpdateSettingsAsync( settings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> UpdateSettingsAsync(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="synonymId"></param>
		/// <param name="synonymDefinition"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var synonymDefinition = await search.UpdateSynonymDefinitionAsync( synonymDefinition,  synonymId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> UpdateSynonymDefinitionAsync(Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition synonymDefinition, int synonymId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSynonymDefinitionClient( synonymDefinition,  synonymId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var stream = await search.DeleteSearchTuningRuleAsync( searchTuningRuleCode);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteSearchTuningRuleAsync(string searchTuningRuleCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.DeleteSearchTuningRuleClient( searchTuningRuleCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="synonymId"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var stream = await search.DeleteSynonymDefinitionAsync( synonymId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteSynonymDefinitionAsync(int synonymId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.DeleteSynonymDefinitionClient( synonymId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


