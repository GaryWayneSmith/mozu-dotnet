
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
	/// 
	/// </summary>
	public partial class RoleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public RoleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public RoleResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new RoleResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.RoleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var role = new Role();
		///   var roleCollection = await role.GetRolesAsync( filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.RoleCollection> GetRolesAsync(string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Core.RoleCollection> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.RoleClient.GetRolesClient( filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


