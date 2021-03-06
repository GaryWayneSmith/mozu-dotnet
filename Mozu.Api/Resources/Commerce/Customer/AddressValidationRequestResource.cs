
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
	/// Use the Address Validation resource to validate addresses associated with a customer account contact.
	/// </summary>
	public partial class AddressValidationRequestResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AddressValidationRequestResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AddressValidationRequestResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AddressValidationRequestResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="addressValidationRequest">Properties of the address used for validation of the account's full address. This content may include multiple lines of an address, city, state/province, zip/postal code, and country.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.AddressValidationResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var addressvalidationrequest = new AddressValidationRequest();
		///   var addressValidationResponse = await addressvalidationrequest.ValidateAddressAsync( addressValidationRequest,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.AddressValidationResponse> ValidateAddressAsync(Mozu.Api.Contracts.Customer.AddressValidationRequest addressValidationRequest, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.AddressValidationResponse> response;
			var client = Mozu.Api.Clients.Commerce.Customer.AddressValidationRequestClient.ValidateAddressClient( addressValidationRequest,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


