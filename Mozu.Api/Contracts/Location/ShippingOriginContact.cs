
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Location
{
		///
		///	Properties of a fulfillment contact for the shipping origin address associated with a location.
		///
		public class ShippingOriginContact
		{
			///
			///The legal or doing business as (DBA) or tradestyle name of the business or organization. The maximum character length is 200.
			///
			public string CompanyOrOrganization { get; set; }

			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string Email { get; set; }

			///
			///The full first name of a customer or contact name.
			///
			public string FirstName { get; set; }

			///
			///The full last name or surname of a customer or contact name.
			///
			public string LastNameOrSurname { get; set; }

			///
			///Character string of the middle name or initial for the customer.
			///
			public string MiddleNameOrInitial { get; set; }

			///
			///Collection of phone numbers associated with the shipping origin contact.
			///
			public string PhoneNumber { get; set; }

		}

}