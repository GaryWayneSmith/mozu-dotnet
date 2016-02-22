
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

namespace Mozu.Api.Urls.Content
{
	public partial class PublishSetSummaryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPublishSets
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPublishSetsUrl(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/?pageSize={pageSize}&startIndex={startIndex}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPublishSetItems
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPublishSetItemsUrl(string code, int? pageSize =  null, int? startIndex =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}/items?pageSize={pageSize}&startIndex={startIndex}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePublishSet
        /// </summary>
        /// <param name="code"></param>
        /// <param name="responseFields"></param>
        /// <param name="shouldDiscard"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePublishSetUrl(string code, bool? shouldDiscard =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}?shouldDiscard={shouldDiscard}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "shouldDiscard", shouldDiscard);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddPublishSetItems
        /// </summary>
        /// <param name="code"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPublishSetItemsUrl(string code, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}/items?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

