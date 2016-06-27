
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

namespace Mozu.Api.Contracts.Customer
{
		///
		///	Mozu.Customer.Contracts.CustomerPurchaseOrderPaymentTerm ApiType DOCUMENT_HERE 
		///
		public class CustomerPurchaseOrderPaymentTerm
		{
			///
			///Basic audit info about the object, including date, time, and user account. Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Mozu.Customer.Contracts.CustomerPurchaseOrderPaymentTerm code ApiTypeMember DOCUMENT_HERE 
			///
			public string Code { get; set; }

			///
			///The localized description in text for the object, displayed per the locale code. For example, descriptions are used for product descriptions, attributes, and pre-authorization transaction types.
			///
			public string Description { get; set; }

			///
			///Unique identifier for the site. This ID is used at all levels of a store, catalog, and tenant to associate objects to a site.
			///
			public int SiteId { get; set; }

		}

}