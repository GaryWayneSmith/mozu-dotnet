
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Extras resource to configure an extra product attribute for products associated with the product type that uses the extra attribute.
	/// </summary>
	public partial class ProductExtraClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtras(dataViewMode,  productCode);
		///   var productExtraClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtra>> GetExtrasClient(DataViewMode dataViewMode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.GetExtrasUrl(productCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtra>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtraValueLocalizedDeltaPrices(dataViewMode,  productCode,  attributeFQN,  value);
		///   var productExtraValueDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>> GetExtraValueLocalizedDeltaPricesClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.GetExtraValueLocalizedDeltaPricesUrl(productCode, attributeFQN, value);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtraValueLocalizedDeltaPrice(dataViewMode,  productCode,  attributeFQN,  value,  currencyCode,  responseFields);
		///   var productExtraValueDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice> GetExtraValueLocalizedDeltaPriceClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value, string currencyCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.GetExtraValueLocalizedDeltaPriceUrl(productCode, attributeFQN, value, currencyCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtra(dataViewMode,  productCode,  attributeFQN,  responseFields);
		///   var productExtraClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> GetExtraClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.GetExtraUrl(productCode, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddExtraValueLocalizedDeltaPrice(dataViewMode,  localizedDeltaPrice,  productCode,  attributeFQN,  value,  responseFields);
		///   var productExtraValueDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice> AddExtraValueLocalizedDeltaPriceClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice localizedDeltaPrice, string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.AddExtraValueLocalizedDeltaPriceUrl(productCode, attributeFQN, value, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productExtra">Properties of the product extra to configure for the specified product.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddExtra(dataViewMode,  productExtra,  productCode,  responseFields);
		///   var productExtraClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> AddExtraClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, string productCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.AddExtraUrl(productCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductExtra>(productExtra)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtraValueLocalizedDeltaPrices(dataViewMode,  localizedDeltaPrice,  productCode,  attributeFQN,  value);
		///   var productExtraValueDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>> UpdateExtraValueLocalizedDeltaPricesClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice> localizedDeltaPrice, string productCode, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.UpdateExtraValueLocalizedDeltaPricesUrl(productCode, attributeFQN, value);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtraValueLocalizedDeltaPrice(dataViewMode,  localizedDeltaPrice,  productCode,  attributeFQN,  value,  currencyCode,  responseFields);
		///   var productExtraValueDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice> UpdateExtraValueLocalizedDeltaPriceClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice localizedDeltaPrice, string productCode, string attributeFQN, string value, string currencyCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.UpdateExtraValueLocalizedDeltaPriceUrl(productCode, attributeFQN, value, currencyCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductExtraValueDeltaPrice>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productExtra">Properties of the extra attribute to update for the specified product.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtra(dataViewMode,  productExtra,  productCode,  attributeFQN,  responseFields);
		///   var productExtraClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> UpdateExtraClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.UpdateExtraUrl(productCode, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductExtra>(productExtra)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtra(dataViewMode,  productCode,  attributeFQN);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteExtraClient(DataViewMode dataViewMode, string productCode, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.DeleteExtraUrl(productCode, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtraValueLocalizedDeltaPrice(dataViewMode,  productCode,  attributeFQN,  value,  currencyCode);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteExtraValueLocalizedDeltaPriceClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value, string currencyCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductExtraUrl.DeleteExtraValueLocalizedDeltaPriceUrl(productCode, attributeFQN, value, currencyCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


