
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

namespace Mozu.Api.Urls.Platform.Extensions
{
	public partial class CredentialStoreEntryUrl 
	{

				/// <summary>
        /// Get Resource Url for StoreCredentials
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl StoreCredentialsUrl()
		{
			var url = "/api/platform/extensions/credentialStore/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

						
	}
}
