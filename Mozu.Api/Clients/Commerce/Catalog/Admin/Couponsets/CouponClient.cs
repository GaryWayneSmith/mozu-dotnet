
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CouponClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="couponSetCode"></param>
		/// <param name="includeCounts"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Coupon"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCoupon( couponSetCode,  couponCode,  includeCounts,  responseFields);
		///   var couponClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Coupon> GetCouponClient(string couponSetCode, string couponCode, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets.CouponUrl.GetCouponUrl(couponSetCode, couponCode, includeCounts, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Coupon>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="filter"></param>
		/// <param name="includeCounts"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CouponCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCoupons( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
		///   var couponCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponCollection> GetCouponsClient(string couponSetCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets.CouponUrl.GetCouponsUrl(couponSetCode, startIndex, pageSize, sortBy, filter, includeCounts, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="coupons"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddCoupons( coupons,  couponSetCode);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> AddCouponsClient(List<Mozu.Api.Contracts.ProductAdmin.Coupon> coupons, string couponSetCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets.CouponUrl.AddCouponsUrl(couponSetCode);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.Coupon>>(coupons);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="couponCodes"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCoupons( couponCodes,  couponSetCode);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteCouponsClient(List<string> couponCodes, string couponSetCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets.CouponUrl.DeleteCouponsUrl(couponSetCode);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(couponCodes);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="couponSetCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCoupon( couponSetCode,  couponCode);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteCouponClient(string couponSetCode, string couponCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Couponsets.CouponUrl.DeleteCouponUrl(couponSetCode, couponCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


