
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

namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// 
	/// </summary>
	public partial class FulfillmentSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public FulfillmentSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public FulfillmentSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new FulfillmentSettingsResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentsettings = new FulfillmentSettings();
		///   var fulfillmentSettings = await fulfillmentsettings.GetFulfillmentSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> GetFulfillmentSettingsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.FulfillmentSettingsClient.GetFulfillmentSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="fulfillmentSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentsettings = new FulfillmentSettings();
		///   var fulfillmentSettings = await fulfillmentsettings.CreateFulfillmentSettingsAsync( fulfillmentSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> CreateFulfillmentSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings fulfillmentSettings, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.FulfillmentSettingsClient.CreateFulfillmentSettingsClient( fulfillmentSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="fulfillmentSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentsettings = new FulfillmentSettings();
		///   var fulfillmentSettings = await fulfillmentsettings.UpdateFulfillmentSettingsAsync( fulfillmentSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> UpdateFulfillmentSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings fulfillmentSettings, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Fulfillment.FulfillmentSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.FulfillmentSettingsClient.UpdateFulfillmentSettingsClient( fulfillmentSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


