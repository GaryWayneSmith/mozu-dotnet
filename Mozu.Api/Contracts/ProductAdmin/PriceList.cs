
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

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Mozu.ProductAdmin.Contracts.PriceList ApiType DOCUMENT_HERE 
		///
		public class PriceList
		{
			///
			///Basic audit info about the object, including date, time, and user account. Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceList defaultForSites ApiTypeMember DOCUMENT_HERE 
			///
			public List<int> DefaultForSites { get; set; }

			///
			///The localized description in text for the object, displayed per the locale code. For example, descriptions are used for product descriptions, attributes, and pre-authorization transaction types.
			///
			public string Description { get; set; }

			///
			///Indicates if the capability or app is enabled for the tenant/site. If true, the capability/application is enabled for the tenant. System-supplied and read-only.
			///
			public bool? Enabled { get; set; }

			///
			///When true, only products with valid price list entries will be visible in the storefront. Default is false
			///
			public bool? FilteredInStorefront { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceList indexedSites ApiTypeMember DOCUMENT_HERE 
			///
			public List<int> IndexedSites { get; set; }

			///
			///List of customer segment code associated with this price list. Used to resolve default price list
			///
			public List<string> MappedCustomerSegments { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///Parent PriceList code, Can be null for root level priceLists
			///
			public string ParentPriceListCode { get; set; }

			///
			///Parent PriceList name, Can be null for root level priceLists. Read only in contract.
			///
			public string ParentPriceListName { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceList priceListCode ApiTypeMember DOCUMENT_HERE 
			///
			public string PriceListCode { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceList priceListSequence ApiTypeMember DOCUMENT_HERE 
			///
			public int PriceListSequence { get; set; }

			///
			///Used to prioritize price list resolution when more than 1 price list maps
			///
			public int? Rank { get; set; }

			///
			///Determines if this price list can be resolved as the current price list within a session.
			///
			public bool? Resolvable { get; set; }

			///
			///When true, no valid sites need to be specifiied. Price list is considered valid for all sites. Default is true
			///
			public bool? ValidForAllSites { get; set; }

			///
			///When ValidForAllSites = false, a list of siteIDs that the price list is valid for should be supplied
			///
			public List<int> ValidSites { get; set; }

		}

}