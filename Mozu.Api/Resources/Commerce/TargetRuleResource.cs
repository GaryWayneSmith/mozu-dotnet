
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// commerce/targetrules related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class TargetRuleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TargetRuleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TargetRuleResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TargetRuleResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of TargetRules according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = targetrule.GetTargetRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection GetTargetRules(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of TargetRules according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = await targetrule.GetTargetRulesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> GetTargetRulesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Get Target Rule
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.GetTargetRule( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule GetTargetRule(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Get Target Rule
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.GetTargetRuleAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> GetTargetRuleAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// commerce-targetrules Post CreateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.CreateTargetRule( targetRule,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule CreateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// commerce-targetrules Post CreateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.CreateTargetRuleAsync( targetRule,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> CreateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// commerce-targetrules Post ValidateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.ValidateTargetRule( targetRule);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ValidateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// commerce-targetrules Post ValidateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.ValidateTargetRuleAsync( targetRule);
		/// </code>
		/// </example>
		public virtual async Task ValidateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// commerce-targetrules Put UpdateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.UpdateTargetRule( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule UpdateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// commerce-targetrules Put UpdateTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">Mozu.ShippingAdmin.Contracts.TargetRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.UpdateTargetRuleAsync( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> UpdateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// commerce-targetrules Delete DeleteTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.DeleteTargetRule( code);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteTargetRule(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// commerce-targetrules Delete DeleteTargetRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.DeleteTargetRuleAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteTargetRuleAsync(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


