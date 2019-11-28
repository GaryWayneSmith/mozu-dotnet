
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

namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CheckoutClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="q"></param>
		/// <param name="qLimit"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCheckouts( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		///   var checkoutCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutCollection> GetCheckoutsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.GetCheckoutsUrl(startIndex, pageSize, sortBy, filter, q, qLimit, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableActions( checkoutId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableActionsClient(string checkoutId)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.GetAvailableActionsUrl(checkoutId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutGroupRates"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableShippingMethods( checkoutId);
		///   var checkoutGroupRatesClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutGroupRates>> GetAvailableShippingMethodsClient(string checkoutId)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.GetAvailableShippingMethodsUrl(checkoutId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutGroupRates>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCheckout( checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> GetCheckoutClient(string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.GetCheckoutUrl(checkoutId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateCheckoutFromCart( cartId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> CreateCheckoutFromCartClient(string cartId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.CreateCheckoutFromCartUrl(cartId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="action"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformCheckoutAction( action,  checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> PerformCheckoutActionClient(Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutAction action, string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.PerformCheckoutActionUrl(checkoutId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendCheckoutConfirmationEmail( checkoutId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> ResendCheckoutConfirmationEmailClient(string checkoutId)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.ResendCheckoutConfirmationEmailUrl(checkoutId);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="groupShippingMethods"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetShippingMethods( groupShippingMethods,  checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> SetShippingMethodsClient(List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutGroupShippingMethod> groupShippingMethods, string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.SetShippingMethodsUrl(checkoutId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.CheckoutGroupShippingMethod>>(groupShippingMethods);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="checkout"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCheckout( checkout,  checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> UpdateCheckoutClient(Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout checkout, string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.UpdateCheckoutUrl(checkoutId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>(checkout);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="digitalWalletType"></param>
		/// <param name="responseFields"></param>
		/// <param name="digitalWallet"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ProcessDigitalWallet( digitalWallet,  checkoutId,  digitalWalletType,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> ProcessDigitalWalletClient(Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet digitalWallet, string checkoutId, string digitalWalletType, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.ProcessDigitalWalletUrl(checkoutId, digitalWalletType, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet>(digitalWallet);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="priceListCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangeCheckoutPriceList( priceListCode,  checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> ChangeCheckoutPriceListClient(string priceListCode, string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CheckoutUrl.ChangeCheckoutPriceListUrl(checkoutId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(priceListCode);
			return mozuClient;

		}


	}

}


