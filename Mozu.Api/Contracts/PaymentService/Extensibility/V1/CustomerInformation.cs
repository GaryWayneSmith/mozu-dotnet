
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


namespace Mozu.Api.Contracts.PaymentService.Extensibility.V1
{
		public class CustomerInformation
		{
			public Address Address { get; set; }

			public Contact Contact { get; set; }

			public string CurrencyCode { get; set; }

			public string CustomerId { get; set; }

			public List<KeyValueTuple> ExtendedInfo { get; set; }

			public string PhoneNumber { get; set; }

			public string RequestorIp { get; set; }

			public string RequestorUrl { get; set; }

			public string RequestorUserAgent { get; set; }

		}

}