
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

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// The B2B feature includes the primary shared B2B account and a set of user account logins that have access to that primary account. This primary account has its own identifying data and customer attributes, as well as the list of users associated with it. These attributes and users can be managed through other operations of the B2B APIs.
	/// </summary>
	public partial class B2BAccountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public B2BAccountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public B2BAccountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new B2BAccountResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fields"></param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BAccountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BAccountCollection = await b2baccount.GetB2BAccountsAsync( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BAccountCollection> GetB2BAccountsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BAccountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetB2BAccountsClient( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var customerAttribute = await b2baccount.GetB2BAccountAttributeAsync( accountId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAttribute> GetB2BAccountAttributeAsync(int accountId, string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetB2BAccountAttributeClient( accountId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var customerAttributeCollection = await b2baccount.GetB2BAccountAttributesAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> GetB2BAccountAttributesAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetB2BAccountAttributesClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.UserRoleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var userRoleCollection = await b2baccount.GetUserRolesAsyncAsync( accountId,  userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.UserRoleCollection> GetUserRolesAsyncAsync(int accountId, string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.UserRoleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetUserRolesAsyncClient( accountId,  userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BUserCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BUserCollection = await b2baccount.GetUsersAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BUserCollection> GetUsersAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BUserCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetUsersClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BAccount = await b2baccount.GetB2BAccountAsync( accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BAccount> GetB2BAccountAsync(int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.GetB2BAccountClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BAccount = await b2baccount.AddAccountAsync( account,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BAccount> AddAccountAsync(Mozu.Api.Contracts.Customer.B2BAccount account, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.AddAccountClient( account,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="attribute">The attribute details being applied to the B2B account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var customerAttribute = await b2baccount.AddB2BAccountAttributeAsync( attribute,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAttribute> AddB2BAccountAttributeAsync(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.AddB2BAccountAttributeClient( attribute,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="roleId">Identifier for the role that the user account should belong to. For B2B, these roles include Admin, Purchaser, and Non-Purchaser.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var stream = await b2baccount.AddUserRoleAsyncAsync( accountId,  userId,  roleId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> AddUserRoleAsyncAsync(int accountId, string userId, int roleId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.AddUserRoleAsyncClient( accountId,  userId,  roleId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="user"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BUser"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BUser = await b2baccount.AddUserAsync( user,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BUser> AddUserAsync(Mozu.Api.Contracts.Customer.B2BUserAndAuthInfo user, int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BUser> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.AddUserClient( user,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="attribute"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var customerAttribute = await b2baccount.UpdateB2BAccountAttributeAsync( attribute,  accountId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAttribute> UpdateB2BAccountAttributeAsync(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.UpdateB2BAccountAttributeClient( attribute,  accountId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var stream = await b2baccount.RemoveUserAsync( accountId,  userId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> RemoveUserAsync(int accountId, string userId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.RemoveUserClient( accountId,  userId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <param name="user"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BUser"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BUser = await b2baccount.UpdateUserAsync( user,  accountId,  userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BUser> UpdateUserAsync(Mozu.Api.Contracts.Customer.B2BUser user, int accountId, string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BUser> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.UpdateUserClient( user,  accountId,  userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var b2BAccount = await b2baccount.UpdateAccountAsync( account,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.B2BAccount> UpdateAccountAsync(Mozu.Api.Contracts.Customer.B2BAccount account, int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.UpdateAccountClient( account,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var stream = await b2baccount.DeleteB2BAccountAttributeAsync( accountId,  attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteB2BAccountAttributeAsync(int accountId, string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.DeleteB2BAccountAttributeClient( accountId,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="roleId">The ID corresponding to the type of permissions being removed, e.g. 1 for Admin.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var b2baccount = new B2BAccount();
		///   var stream = await b2baccount.RemoveUserRoleAsyncAsync( accountId,  userId,  roleId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> RemoveUserRoleAsyncAsync(int accountId, string userId, int roleId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Customer.B2BAccountClient.RemoveUserRoleAsyncClient( accountId,  userId,  roleId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


