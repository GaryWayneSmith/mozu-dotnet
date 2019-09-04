
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

namespace Mozu.Api.Clients.Commerce.Carts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ExtendedPropertyClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtendedProperties();
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> GetExtendedPropertiesClient()
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.GetExtendedPropertiesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="extendedProperties"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddExtendedProperties( extendedProperties);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> AddExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.AddExtendedPropertiesUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <param name="responseFields"></param>
		/// <param name="upsert"></param>
		/// <param name="extendedProperty"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperty( extendedProperty,  key,  upsert,  responseFields);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> UpdateExtendedPropertyClient(Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty extendedProperty, string key, bool? upsert =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.UpdateExtendedPropertyUrl(key, upsert, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>(extendedProperty);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="upsert"></param>
		/// <param name="extendedProperties"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperties( extendedProperties,  upsert);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> UpdateExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, bool? upsert =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.UpdateExtendedPropertiesUrl(upsert);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="keys"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperties( keys);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteExtendedPropertiesClient(List<string> keys)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.DeleteExtendedPropertiesUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(keys);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperty( key);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteExtendedPropertyClient(string key)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.DeleteExtendedPropertyUrl(key);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


