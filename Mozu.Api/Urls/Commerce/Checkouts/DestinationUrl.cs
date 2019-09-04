
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

namespace Mozu.Api.Urls.Commerce.Checkouts
{
	public partial class DestinationUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDestinations
        /// </summary>
        /// <param name="checkoutId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDestinationsUrl(string checkoutId)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/destinations";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDestination
        /// </summary>
        /// <param name="checkoutId"></param>
        /// <param name="destinationId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDestinationUrl(string checkoutId, string destinationId, string responseFields =  null)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/destinations/{destinationId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "destinationId", destinationId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddDestination
        /// </summary>
        /// <param name="checkoutId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddDestinationUrl(string checkoutId, string responseFields =  null)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/destinations?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDestination
        /// </summary>
        /// <param name="checkoutId"></param>
        /// <param name="destinationId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDestinationUrl(string checkoutId, string destinationId, string responseFields =  null)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/destinations/{destinationId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "destinationId", destinationId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RemoveDestination
        /// </summary>
        /// <param name="checkoutId"></param>
        /// <param name="destinationId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveDestinationUrl(string checkoutId, string destinationId)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/destinations/{destinationId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "destinationId", destinationId);
			return mozuUrl;
		}

		
	}
}

