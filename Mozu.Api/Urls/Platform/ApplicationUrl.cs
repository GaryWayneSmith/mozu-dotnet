
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

namespace Mozu.Api.Urls.Platform
{
	public partial class ApplicationUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAppPackageNames
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAppPackageNamesUrl(string applicationKey, string responseFields =  null)
		{
			var url = "/api/platform/developer/applications/{applicationKey}/packagenames?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAppVersions
        /// </summary>
        /// <param name="nsAndAppId"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAppVersionsUrl(string nsAndAppId, string responseFields =  null)
		{
			var url = "/api/platform/developer/applications/versions/{nsAndAppId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "nsAndAppId", nsAndAppId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageFileMetadata
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="filepath"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageFileMetadataUrl(string applicationKey, string filepath, string responseFields =  null)
		{
			var url = "/api/platform/developer/packages/{applicationKey}/filemetadata/{*filepath}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "filepath", filepath);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageMetadata
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageMetadataUrl(string applicationKey, string responseFields =  null)
		{
			var url = "/api/platform/developer/packages/{applicationKey}/metadata?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpsertPackageFile
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="filepath"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpsertPackageFileUrl(string applicationKey, string filepath, string lastModifiedTime =  null, string responseFields =  null)
		{
			var url = "/api/platform/developer/packages/{applicationKey}/files/{*filepath}?lastModifiedTime={lastModifiedTime}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "filepath", filepath);
			mozuUrl.FormatUrl( "lastModifiedTime", lastModifiedTime);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RenamePackageFile
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RenamePackageFileUrl(string applicationKey, string responseFields =  null)
		{
			var url = "/api/platform/developer/packages/{applicationKey}/files_rename?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for DeletePackageFile
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="filepath"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePackageFileUrl(string applicationKey, string filepath)
		{
			var url = "/api/platform/developer/packages/{applicationKey}/files/{*filepath}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "applicationKey", applicationKey);
			mozuUrl.FormatUrl( "filepath", filepath);
			return mozuUrl;
		}

		
	}
}

