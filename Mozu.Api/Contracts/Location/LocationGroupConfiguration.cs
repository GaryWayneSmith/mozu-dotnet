
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Location
{
		public class LocationGroupConfiguration
		{
			public bool? AllowReturns { get; set; }

			public List<LocationAttribute> Attributes { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public List<BoxType> BoxTypes { get; set; }

			public List<Carrier> Carriers { get; set; }

			public List<string> ClosePickWavePermissions { get; set; }

			public string CustomerFailedToPickupAfterAction { get; set; }

			public int? CustomerFailedToPickupDeadline { get; set; }

			public string DefaultCarrier { get; set; }

			public int? DefaultNumberOfOrdersInPickWave { get; set; }

			public string DefaultPrinterType { get; set; }

			public int? DefaultReturnRefundReductionAmount { get; set; }

			public bool? EnableAdvancedOptionForPickWaveCreation { get; set; }

			public bool? EnableForISPU { get; set; }

			public bool? EnableForSTH { get; set; }

			public bool? EnableScanningOfUpcForShipToHome { get; set; }

			public int LocationGroupId { get; set; }

			public int? MaximumNumberOfOrdersInPickWave { get; set; }

			public int? MaximumReturnRefundReductionAmount { get; set; }

			public string PickWavePrintFormat { get; set; }

			public bool? PrintReturnLabel { get; set; }

			public bool? ReturnRefundReduction { get; set; }

			public int? SendCustomerPickupReminder { get; set; }

			public int SiteId { get; set; }

			public int TenantId { get; set; }

			public bool? WmsEnabled { get; set; }

		}

}