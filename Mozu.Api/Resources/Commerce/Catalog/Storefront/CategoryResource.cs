
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Categories resource to view the product category hierarchy as it appears to shoppers who are browsing the storefront. The hierarchy can be returned as a flat list or as a category tree.
	/// </summary>
	public partial class CategoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public CategoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public CategoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CategoryResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public CategoryResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories(_dataViewMode,  filter,  startIndex,  pageSize,  sortBy,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection GetCategories(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient(_dataViewMode,  filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = await category.GetCategoriesAsync(_dataViewMode,  filter,  startIndex,  pageSize,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> GetCategoriesAsync(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient(_dataViewMode,  filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory(_dataViewMode,  categoryId,  allowInactive,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.Category GetCategory(int categoryId, bool? allowInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient(_dataViewMode,  categoryId,  allowInactive,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = await category.GetCategoryAsync(_dataViewMode,  categoryId,  allowInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.Category> GetCategoryAsync(int categoryId, bool? allowInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient(_dataViewMode,  categoryId,  allowInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = category.GetCategoryTree(_dataViewMode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryCollection GetCategoryTree(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient(_dataViewMode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = await category.GetCategoryTreeAsync(_dataViewMode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> GetCategoryTreeAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient(_dataViewMode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


