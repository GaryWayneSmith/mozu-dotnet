
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Location Inventory resource to manage the level of active product inventory maintained at each defined location, at the location level.
	/// </summary>
	public partial class LocationInventoryClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventory(dataViewMode,  locationCode,  productCode,  responseFields);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> GetLocationInventoryClient(DataViewMode dataViewMode, string locationCode, string productCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventoryUrl.GetLocationInventoryUrl(locationCode, productCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="filterFunctions"></param>
		/// <param name="locationCode"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventories(dataViewMode,  locationCode,  startIndex,  pageSize,  sortBy,  filter,  filterFunctions,  responseFields);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesClient(DataViewMode dataViewMode, string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string filterFunctions =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventoryUrl.GetLocationInventoriesUrl(locationCode, startIndex, pageSize, sortBy, filter, filterFunctions, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="performUpserts"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryList">Array list of product inventory definitions for all associated locations. For each location inventory in the list, define the productCode and stockOnHand values.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocationInventory(dataViewMode,  locationInventoryList,  locationCode,  performUpserts);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode, bool? performUpserts =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventoryUrl.AddLocationInventoryUrl(locationCode, performUpserts);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>(locationInventoryList)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryAdjustments">Properties of the inventory adjustments to perform for the specified location.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocationInventory(dataViewMode,  locationInventoryAdjustments,  locationCode);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> UpdateLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string locationCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventoryUrl.UpdateLocationInventoryUrl(locationCode);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment>>(locationInventoryAdjustments)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteLocationInventory(dataViewMode,  locationCode,  productCode);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteLocationInventoryClient(DataViewMode dataViewMode, string locationCode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventoryUrl.DeleteLocationInventoryUrl(locationCode, productCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


