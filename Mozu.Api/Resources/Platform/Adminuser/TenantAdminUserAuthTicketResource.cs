
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

namespace Mozu.Api.Resources.Platform.Adminuser
{
	/// <summary>
	/// Use the Admin User authentication tickets resource to generate and refresh authentication tickets that enable  administrator or developer account users to access development or production tenants.
	/// </summary>
	public partial class TenantAdminUserAuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TenantAdminUserAuthTicketResource() 
		{
			_apiContext = null;
		}
		 public TenantAdminUserAuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TenantAdminUserAuthTicketResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TenantAdminUserAuthTicketResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="redirect"></param>
		/// <param name="responseFields"></param>
		/// <param name="scopeid"></param>
		/// <param name="scopeType"></param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var string = await tenantadminuserauthticket.GetWsFedChallengeUrlAsync( id,  scopeid,  scopeType,  redirect,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<string> GetWsFedChallengeUrlAsync(string id, int? scopeid, string scopeType, string redirect, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.GetWsFedChallengeUrlClient( id,  scopeid,  scopeType,  redirect,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="redirect"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var string = await tenantadminuserauthticket.GetWsFedSignOutUrlAsync( id,  redirect,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<string> GetWsFedSignOutUrlAsync(string id, string redirect, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.GetWsFedSignOutUrlClient( id,  redirect,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="tenantId">Unique identifier of the development or production tenant for which to generate the user authentication ticket.</param>
		/// <param name="userAuthInfo">Information required to authenticate a user.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = await tenantadminuserauthticket.CreateUserAuthTicketAsync( userAuthInfo,  tenantId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> CreateUserAuthTicketAsync(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? tenantId =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.CreateUserAuthTicketClient( userAuthInfo,  tenantId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="responseFields"></param>
		/// <param name="scopeid"></param>
		/// <param name="scopeType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = await tenantadminuserauthticket.CreateUserAuthTicketWithWsFedAsync( id,  scopeid,  scopeType,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> CreateUserAuthTicketWithWsFedAsync(string id, int? scopeid, string scopeType, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.CreateUserAuthTicketWithWsFedClient( id,  scopeid,  scopeType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="tenantId">Unique identifier of the development or production tenant for which to generate the user authentication ticket.</param>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to be used in user claims with the  API.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = await tenantadminuserauthticket.RefreshAuthTicketAsync( existingAuthTicket,  tenantId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> RefreshAuthTicketAsync(Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket existingAuthTicket, int? tenantId =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.RefreshAuthTicketClient( existingAuthTicket,  tenantId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var stream = await tenantadminuserauthticket.DeleteUserAuthTicketAsync( refreshToken);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteUserAuthTicketAsync(string refreshToken, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.DeleteUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


