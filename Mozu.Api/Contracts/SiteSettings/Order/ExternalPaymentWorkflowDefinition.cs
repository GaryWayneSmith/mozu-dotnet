
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

namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Properties of an external payment processing workflow defined for the site. At this time, only PayPal Express is supported.
		///
		public class ExternalPaymentWorkflowDefinition
		{
			///
			///The name of the external payment workflow definition.
			///
			public string Name { get; set; }

			///
			///If true, the associated external payment workflow definition is enabled for the site.
			///
			public bool IsEnabled { get; set; }

			///
			///The credential fields required to communicate with the external payment processor.
			///
			public List<ThirdPartyCredentialField> Credentials { get; set; }

		}

}