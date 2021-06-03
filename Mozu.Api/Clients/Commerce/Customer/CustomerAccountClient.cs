
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

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Accounts resource to manage the components of shopper accounts, including attributes, contact information, company notes, and groups associated with the customer account.
	/// </summary>
	public partial class CustomerAccountClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fields">The fields to include in the response.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="isAnonymous">If true, retrieve anonymous shopper accounts in the response.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccounts( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous,  responseFields);
		///   var customerAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> GetAccountsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, bool? isAnonymous =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetAccountsUrl(startIndex, pageSize, sortBy, filter, fields, q, qLimit, isAnonymous, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginState( accountId,  userId,  responseFields);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateClient(int accountId, string userId =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateUrl(accountId, userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccount( accountId,  userId,  responseFields);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> GetAccountClient(int accountId, string userId =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetAccountUrl(accountId, userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account">Properties of the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccount( account,  responseFields);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> AddAccountClient(Mozu.Api.Contracts.Customer.CustomerAccount account, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="unlockAccount">Specifies whether to unlock the specified customer account.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <param name="passwordInfo">The information required to modify a shopper account password.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangePassword( passwordInfo,  accountId,  unlockAccount,  userId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> ChangePasswordClient(Mozu.Api.Contracts.Customer.PasswordInfo passwordInfo, int accountId, bool? unlockAccount =  null, string userId =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.ChangePasswordUrl(accountId, unlockAccount, userId);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.PasswordInfo>(passwordInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerAuthInfo">The login information for a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLoginToExistingCustomer( customerAuthInfo,  accountId,  responseFields);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddLoginToExistingCustomerClient(Mozu.Api.Contracts.Customer.CustomerLoginInfo customerAuthInfo, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddLoginToExistingCustomerUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerLoginInfo>(customerAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RecomputeCustomerLifetimeValue( accountId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> RecomputeCustomerLifetimeValueClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.RecomputeCustomerLifetimeValueUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <param name="isLocked">If true, the customer account is locked from logging in.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetLoginLocked( isLocked,  accountId,  userId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> SetLoginLockedClient(bool isLocked, int accountId, string userId =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.SetLoginLockedUrl(accountId, userId);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(isLocked);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <param name="isPasswordChangeRequired">If true, the password for the customer account must be changed.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetPasswordChangeRequired( isPasswordChangeRequired,  accountId,  userId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> SetPasswordChangeRequiredClient(bool isPasswordChangeRequired, int accountId, string userId =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.SetPasswordChangeRequiredUrl(accountId, userId);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(isPasswordChangeRequired);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="accountAndAuthInfo">The authentication information associated with a customer account.Â The data includes the account properties such as the name, username, authorization access, and email address, the required password to match, and indicates if the account was imported from a third party resource. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountAndLogin( accountAndAuthInfo,  responseFields);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddAccountAndLoginClient(Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo accountAndAuthInfo, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountAndLoginUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo>(accountAndAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customers">The authentication information associated with a customer account.Â The data includes the account properties such as the name, username, authorization access, and email address, the required password to match, and indicates if the account was imported from a third party resource. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccounts( customers,  responseFields);
		///   var customerAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> AddAccountsClient(List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo> customers, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo>>(customers);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="accountPasswordInfos">The details of the changed customer account passwords.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.ChangePasswordResultCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangePasswords( accountPasswordInfos,  responseFields);
		///   var changePasswordResultCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.ChangePasswordResultCollection> ChangePasswordsClient(Mozu.Api.Contracts.Customer.AccountPasswordInfoCollection accountPasswordInfos, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.ChangePasswordsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.ChangePasswordResultCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.AccountPasswordInfoCollection>(accountPasswordInfos);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerSetCode">The unique idenfitier of the customer set.</param>
		/// <param name="emailAddress">The email address associated with the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginStateByEmailAddress( emailAddress,  customerSetCode,  responseFields);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByEmailAddressClient(string emailAddress, string customerSetCode =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateByEmailAddressUrl(emailAddress, customerSetCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerSetCode">The unique idenfitier of the customer set.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userName">The user name associated with the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginStateByUserName( userName,  customerSetCode,  responseFields);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByUserNameClient(string userName, string customerSetCode =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateByUserNameUrl(userName, customerSetCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountType">The type of customer account utilizing purchase orders.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomersPurchaseOrderAccounts( startIndex,  pageSize,  sortBy,  accountType,  responseFields);
		///   var customerPurchaseOrderAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccountCollection> GetCustomersPurchaseOrderAccountsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string accountType =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetCustomersPurchaseOrderAccountsUrl(startIndex, pageSize, sortBy, accountType, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="resetPasswordInfo">Information required to reset the password for a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResetPassword( resetPasswordInfo);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> ResetPasswordClient(Mozu.Api.Contracts.Customer.ResetPasswordInfo resetPasswordInfo)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.ResetPasswordUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.ResetPasswordInfo>(resetPasswordInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account">Properties of the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccount( account,  accountId,  responseFields);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> UpdateAccountClient(Mozu.Api.Contracts.Customer.CustomerAccount account, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.UpdateAccountUrl(accountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccount( accountId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteAccountClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.DeleteAccountUrl(accountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


