
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Categories resource to organize products and control where they appear on the storefront. Create and maintain a hierarchy of categories and subcategories where the site will store properties.
	/// </summary>
	public partial class CategoryClient 	{
		
		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCategories(dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var categoryPagedCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection> GetCategoriesClient(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.GetCategoriesUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of subcategories within a category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CategoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetChildCategories( categoryId,  responseFields);
		///   var categoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryCollection> GetChildCategoriesClient(int categoryId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.GetChildCategoriesUrl(categoryId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCategory(dataViewMode,  categoryId,  responseFields);
		///   var categoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> GetCategoryClient(DataViewMode dataViewMode, int categoryId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.GetCategoryUrl(categoryId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Category>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Adds a new category to the site's category hierarchy. Specify a ParentCategoryID to determine where to place the category in the hierarchy. If no ParentCategoryID is specified, the new category is a top-level category.
		/// </summary>
		/// <param name="incrementSequence">If true, when adding a new product category, set the sequence number of the new category to an increment of one integer greater than the maximum available sequence number across all product categories. If false, set the sequence number to zero.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddCategory( category,  incrementSequence,  responseFields);
		///   var categoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> AddCategoryClient(Mozu.Api.Contracts.ProductAdmin.Category category, bool? incrementSequence =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.AddCategoryUrl(incrementSequence, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Category>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Category>(category);
			return mozuClient;

		}

		/// <summary>
		/// Modifies the sequence and hierarchy of multiple categories in a category tree in one operation. This is better for moving a category to a different location in the tree and adjusting the order of multiple categories than doing individual category updates.
		/// </summary>
		/// <param name="categorySequencies">Mozu.ProductAdmin.Contracts.CategorySequenceCollection ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCategoryTree( categorySequencies);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateCategoryTreeClient(Mozu.Api.Contracts.ProductAdmin.CategorySequenceCollection categorySequencies)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.UpdateCategoryTreeUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.CategorySequenceCollection>(categorySequencies);
			return mozuClient;

		}

		/// <summary>
		/// Validates the precomputed dynamic category expression.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateDynamicExpression( dynamicExpressionIn,  responseFields);
		///   var dynamicExpressionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> ValidateDynamicExpressionClient(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.ValidateDynamicExpressionUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.DynamicExpression>(dynamicExpressionIn);
			return mozuClient;

		}

		/// <summary>
		/// Validates the realtime dynamic expression.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dynamicExpressionIn">Mozu.ProductAdmin.Contracts.DynamicExpression ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DynamicExpression"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateRealTimeDynamicExpression( dynamicExpressionIn,  responseFields);
		///   var dynamicExpressionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression> ValidateRealTimeDynamicExpressionClient(Mozu.Api.Contracts.ProductAdmin.DynamicExpression dynamicExpressionIn, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.ValidateRealTimeDynamicExpressionUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DynamicExpression>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.DynamicExpression>(dynamicExpressionIn);
			return mozuClient;

		}

		/// <summary>
		/// Update the properties of a defined category or move it to another location in the category hierarchy. Because this operation replaces the defined resource,include all the information to maintain for the category in the request.
		/// </summary>
		/// <param name="cascadeVisibility">If true, when changing the display option for the category, change it for all subcategories also. The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="category">A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCategory( category,  categoryId,  cascadeVisibility,  responseFields);
		///   var categoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> UpdateCategoryClient(Mozu.Api.Contracts.ProductAdmin.Category category, int categoryId, bool? cascadeVisibility =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.UpdateCategoryUrl(categoryId, cascadeVisibility, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Category>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Category>(category);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the category specified by its category ID.
		/// </summary>
		/// <param name="cascadeDelete">Specifies whether to also delete all subcategories associated with the specified category.If you set this value is false, only the specified category is deleted.The default value is false.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="forceDelete">Specifies whether the category, and any associated subcategories, are deleted even if there are products that reference them. The default value is false.</param>
		/// <param name="reassignToParent">Specifies whether any subcategories of the specified category are reassigned to the parent of the specified category.This field only applies if the cascadeDelete parameter is false.The default value is false.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCategoryById( categoryId,  cascadeDelete,  forceDelete,  reassignToParent);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCategoryByIdClient(int categoryId, bool? cascadeDelete =  null, bool? forceDelete =  null, bool? reassignToParent =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CategoryUrl.DeleteCategoryByIdUrl(categoryId, cascadeDelete, forceDelete, reassignToParent);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


