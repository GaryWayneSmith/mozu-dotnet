
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Use the Payment Settings resource to specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PaymentSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PaymentSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PaymentSettingsResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fullyQualifiedName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = await paymentsettings.GetThirdPartyPaymentWorkflowWithValuesAsync( fullyQualifiedName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> GetThirdPartyPaymentWorkflowWithValuesAsync(string fullyQualifiedName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowWithValuesClient( fullyQualifiedName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = await paymentsettings.GetThirdPartyPaymentWorkflowsAsync();
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsAsync(CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="definition"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var stream = await paymentsettings.AddThirdPartyPaymentWorkflowAsync( definition);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> AddThirdPartyPaymentWorkflowAsync(Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition definition, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.AddThirdPartyPaymentWorkflowClient( definition);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="fullyQualifiedName"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var stream = await paymentsettings.DeleteThirdPartyPaymentWorkflowAsync( fullyQualifiedName);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteThirdPartyPaymentWorkflowAsync(string fullyQualifiedName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.DeleteThirdPartyPaymentWorkflowClient( fullyQualifiedName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


