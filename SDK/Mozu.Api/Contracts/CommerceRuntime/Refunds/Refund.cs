
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Refunds
{
		public class Refund
		{
			public decimal Amount { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public string Id { get; set; }

			public string OrderId { get; set; }

			public Payment Payment { get; set; }

			public string Reason { get; set; }

		}

}