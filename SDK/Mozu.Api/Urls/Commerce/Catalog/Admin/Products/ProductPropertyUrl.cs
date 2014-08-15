
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Products
{
	public partial class ProductPropertyUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProperties
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertiesUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPropertyValueLocalizedContents
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="productCode"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertyValueLocalizedContentsUrl(string productCode, string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPropertyValueLocalizedContent
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="localeCode"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertyValueLocalizedContentUrl(string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent/{localeCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertyUrl(string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddPropertyValueLocalizedContent
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPropertyValueLocalizedContentUrl(string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddProperty
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPropertyUrl(string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdatePropertyValueLocalizedContents
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="productCode"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePropertyValueLocalizedContentsUrl(string productCode, string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdatePropertyValueLocalizedContent
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="localeCode"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePropertyValueLocalizedContentUrl(string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent/{localeCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePropertyUrl(string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePropertyUrl(string productCode, string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeletePropertyValueLocalizedContent
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="localeCode"></param>
        /// <param name="productCode"></param>
        /// <param name="value"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePropertyValueLocalizedContentUrl(string productCode, string attributeFQN, string value, string localeCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}/values/{value}/LocalizedContent/{localeCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		
	}
}
