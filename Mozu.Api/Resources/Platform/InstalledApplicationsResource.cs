
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// Use the Applications resource to update and retrieve details about the applications installed for your tenant.
	/// </summary>
	public partial class InstalledApplicationsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public InstalledApplicationsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public InstalledApplicationsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new InstalledApplicationsResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="appId">The application ID that represents the application to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var installedapplications = new InstalledApplications();
		///   var stream = await installedapplications.GetApplicationAsync( appId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetApplicationAsync(string appId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Platform.InstalledApplicationsClient.GetApplicationClient( appId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="appId">The application ID that represents the application to update.</param>
		/// <param name="application">Properties of the application to update.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var installedapplications = new InstalledApplications();
		///   var stream = await installedapplications.UpdateApplicationAsync( application,  appId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> UpdateApplicationAsync(Mozu.Api.Contracts.InstalledApplications.Application application, string appId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Platform.InstalledApplicationsClient.UpdateApplicationClient( application,  appId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


