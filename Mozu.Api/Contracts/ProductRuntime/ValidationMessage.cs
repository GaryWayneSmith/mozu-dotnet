
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of a message displayed when a product validation failure occurs for a shopper in a storefront.
		///
		public class ValidationMessage
		{
			public string Message { get; set; }

			public string Severity { get; set; }

			public string Source { get; set; }

			public string SourceId { get; set; }

			///
			///Type of validation error that occurred. This can be checked programatically. Must be one of the values in ValidationTypeConst.
			///
			public string ValidationType { get; set; }

		}

}