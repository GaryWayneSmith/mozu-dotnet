
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Mozu.CommerceRuntime.Contracts.Payments.SubPayment ApiType DOCUMENT_HERE 
		///
		public class SubPayment
		{
			///
			///amountCollected ApiType DOCUMENT_HERE 
			///
			public decimal AmountCollected { get; set; }

			///
			///amountCredited ApiType DOCUMENT_HERE 
			///
			public decimal AmountCredited { get; set; }

			///
			///amountRefunded ApiType DOCUMENT_HERE 
			///
			public decimal AmountRefunded { get; set; }

			///
			///amountRequested ApiType DOCUMENT_HERE 
			///
			public decimal AmountRequested { get; set; }

			///
			///The current status of the object.This value is read only. Valid values for this field are: "Active", "Expired", and "Inactive".
			///
			public string Status { get; set; }

			///
			///Targets represent the object, such as an item to apply discounts to(products or orders) or a view field for content. Targets are the dot notations that link to the source document property. For example, firstitem for the direct level or firstitem.seconditem.thirditem for a deeper property.
			///
			public PaymentActionTarget Target { get; set; }

		}

}