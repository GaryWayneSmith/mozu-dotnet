
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

namespace Mozu.Api.Urls.Commerce.Admin
{
	public partial class LocationGroupConfigurationUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocationGroupConfiguration
        /// </summary>
        /// <param name="locationGroupCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationGroupConfigurationUrl(string locationGroupCode, string responseFields =  null)
		{
			var url = "/api/commerce/admin/locationGroupConfiguration/{locationGroupCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationGroupCode", locationGroupCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationGroupConfigurationByLocationCode
        /// </summary>
        /// <param name="locationCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationGroupConfigurationByLocationCodeUrl(string locationCode, string responseFields =  null)
		{
			var url = "/api/commerce/admin/locationGroupConfiguration/location/{locationCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for SetLocationGroupConfiguration
        /// </summary>
        /// <param name="locationGroupCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SetLocationGroupConfigurationUrl(string locationGroupCode, string responseFields =  null)
		{
			var url = "/api/commerce/admin/locationGroupConfiguration/{locationGroupCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationGroupCode", locationGroupCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

