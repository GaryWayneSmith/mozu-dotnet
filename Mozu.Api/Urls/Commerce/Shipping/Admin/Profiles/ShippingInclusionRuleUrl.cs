
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

namespace Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles
{
	public partial class ShippingInclusionRuleUrl 
	{

		/// <summary>
        /// Get Resource Url for GetShippingInclusionRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShippingInclusionRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetShippingInclusionRules
        /// </summary>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShippingInclusionRulesUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateShippingInclusionRule
        /// </summary>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateShippingInclusionRuleUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateShippingInclusionRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateShippingInclusionRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteShippingInclusionRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteShippingInclusionRuleUrl(string profilecode, string id)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			return mozuUrl;
		}

		
	}
}

