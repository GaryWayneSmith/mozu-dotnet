
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


namespace Mozu.Api.Contracts.ShippingRuntime
{
		///
		///	Mozu.ShippingRuntime.Contracts.RateRequestAttribute ApiType DOCUMENT_HERE 
		///
		public class RateRequestAttribute
		{
			///
			///Unique identifier of the attribute definition.
			///
			public int? AttributeDefinitionId { get; set; }

			///
			///Fully qualified name of the attribute for the order or customer.
			///
			public string FullyQualifiedName { get; set; }

			///
			///List of value data for objects.
			///
			public List<object> Values { get; set; }

		}

}