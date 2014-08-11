
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Platform
{
	public partial class TenantDataUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDBValue
        /// </summary>
        /// <param name="dbEntryQuery">The database entry query string used to retrieve the record information.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDBValueUrl(string dbEntryQuery, string responseFields =  null)
		{
			var url = "/api/platform/tenantdata/{*dbEntryQuery}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDBValue
        /// </summary>
        /// <param name="dbEntryQuery">The database entry string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDBValueUrl(string dbEntryQuery)
		{
			var url = "/api/platform/tenantdata/{*dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDBValue
        /// </summary>
        /// <param name="dbEntryQuery">The database entry query string used to update the record information.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDBValueUrl(string dbEntryQuery)
		{
			var url = "/api/platform/tenantdata/{*dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteDBValue
        /// </summary>
        /// <param name="dbEntryQuery">The database entry string to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDBValueUrl(string dbEntryQuery)
		{
			var url = "/api/platform/tenantdata/{*dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

		
	}
}
