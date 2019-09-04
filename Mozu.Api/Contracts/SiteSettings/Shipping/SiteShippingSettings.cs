
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.SiteSettings.Shipping
{
		///
		///	Properties of the shipping settings configured for an individual site.
		///
		public class SiteShippingSettings
		{
			public AuditInfo AuditInfo { get; set; }

			public SiteShippingHandlingFee OrderHandlingFee { get; set; }

			public bool RefreshShipping { get; set; }

			public bool RefreshTax { get; set; }

			public SiteShippingSignatureRequirement SignatureRequirement { get; set; }

		}

}