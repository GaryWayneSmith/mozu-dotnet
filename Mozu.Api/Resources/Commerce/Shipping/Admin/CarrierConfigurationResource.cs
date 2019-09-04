
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

namespace Mozu.Api.Resources.Commerce.Shipping.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CarrierConfigurationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CarrierConfigurationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CarrierConfigurationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CarrierConfigurationResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var carrierconfiguration = new CarrierConfiguration();
		///   var carrierConfigurationCollection = await carrierconfiguration.GetConfigurationsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection> GetConfigurationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.CarrierConfigurationClient.GetConfigurationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="carrierId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var carrierconfiguration = new CarrierConfiguration();
		///   var carrierConfiguration = await carrierconfiguration.GetConfigurationAsync( carrierId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> GetConfigurationAsync(string carrierId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.CarrierConfigurationClient.GetConfigurationClient( carrierId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="carrierId"></param>
		/// <param name="responseFields"></param>
		/// <param name="carrierConfiguration"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var carrierconfiguration = new CarrierConfiguration();
		///   var carrierConfiguration = await carrierconfiguration.CreateConfigurationAsync( carrierConfiguration,  carrierId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> CreateConfigurationAsync(Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration carrierConfiguration, string carrierId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.CarrierConfigurationClient.CreateConfigurationClient( carrierConfiguration,  carrierId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="carrierId"></param>
		/// <param name="responseFields"></param>
		/// <param name="carrierConfiguration"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var carrierconfiguration = new CarrierConfiguration();
		///   var carrierConfiguration = await carrierconfiguration.UpdateConfigurationAsync( carrierConfiguration,  carrierId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> UpdateConfigurationAsync(Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration carrierConfiguration, string carrierId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.CarrierConfigurationClient.UpdateConfigurationClient( carrierConfiguration,  carrierId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="carrierId"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var carrierconfiguration = new CarrierConfiguration();
		///   var stream = await carrierconfiguration.DeleteConfigurationAsync( carrierId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteConfigurationAsync(string carrierId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.CarrierConfigurationClient.DeleteConfigurationClient( carrierId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


