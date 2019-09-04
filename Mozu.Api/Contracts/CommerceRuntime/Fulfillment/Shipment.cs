
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of a shipment used to ship order items to a shopper. A shipment can include any number of packages.
		///
		public class Shipment
		{
			public AuditInfo AuditInfo { get; set; }

			public int? BackorderCreatedDate { get; set; }

			public List<ShipmentItem> CanceledItems { get; set; }

			public List<ChangeMessage> ChangeMessages { get; set; }

			public decimal? Cost { get; set; }

			public string CurrencyCode { get; set; }

			public int? CustomerAccountId { get; set; }

			public string CustomerTaxId { get; set; }

			public JObject Data { get; set; }

			public Destination Destination { get; set; }

			public decimal DutyAdjustment { get; set; }

			public decimal DutyTotal { get; set; }

			public string Email { get; set; }

			public string ExternalShipmentId { get; set; }

			public DateTime? FulfillmentDate { get; set; }

			public string FulfillmentLocationCode { get; set; }

			public string FulfillmentStatus { get; set; }

			public decimal HandlingAdjustment { get; set; }

			public decimal HandlingSubtotal { get; set; }

			public decimal HandlingTaxAdjustment { get; set; }

			public decimal HandlingTaxTotal { get; set; }

			public decimal HandlingTotal { get; set; }

			public string Id { get; set; }

			public List<ShipmentItem> Items { get; set; }

			public decimal LineItemSubtotal { get; set; }

			public decimal LineItemTaxAdjustment { get; set; }

			public decimal LineItemTaxTotal { get; set; }

			public decimal LineItemTotal { get; set; }

			public int? Number { get; set; }

			public string OrderId { get; set; }

			public int OrderNumber { get; set; }

			public DateTime? OrderSubmitDate { get; set; }

			public Contact Origin { get; set; }

			public List<Package> Packages { get; set; }

			public string PickStatus { get; set; }

			public string PickType { get; set; }

			public decimal ShipmentAdjustment { get; set; }

			public string ShipmentStatus { get; set; }

			public string ShipmentType { get; set; }

			public decimal ShippingAdjustment { get; set; }

			public string ShippingMethodCode { get; set; }

			public string ShippingMethodName { get; set; }

			public decimal ShippingSubtotal { get; set; }

			public decimal ShippingTaxAdjustment { get; set; }

			public decimal ShippingTaxTotal { get; set; }

			public decimal ShippingTotal { get; set; }

			public bool? SignatureRequired { get; set; }

			public JObject TaxData { get; set; }

			public decimal Total { get; set; }

			public List<string> TrackingNumbers { get; set; }

			public string WorkflowProcessContainerId { get; set; }

			public string WorkflowProcessId { get; set; }

			public WorkflowState WorkflowState { get; set; }

		}

}