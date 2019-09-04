
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class LocationInventoryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocationInventory
        /// </summary>
        /// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoryUrl(string locationCode, string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}/{productCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationInventories
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="filterFunctions"></param>
        /// <param name="locationCode"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoriesUrl(string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string filterFunctions =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&filterFunctions={filterFunctions}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "filterFunctions", filterFunctions);
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddLocationInventory
        /// </summary>
        /// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
        /// <param name="performUpserts"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLocationInventoryUrl(string locationCode, bool? performUpserts =  null)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}?performUpserts={performUpserts}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "performUpserts", performUpserts);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateLocationInventory
        /// </summary>
        /// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocationInventoryUrl(string locationCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteLocationInventory
        /// </summary>
        /// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteLocationInventoryUrl(string locationCode, string productCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}/{productCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		
	}
}

