
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

namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// Use the Return Packages subresource to manage physical packages used to ship return replacement items.
	/// </summary>
	public partial class PackageClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package for which to retrieve the label.</param>
		/// <param name="returnAsBase64Png"></param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package label to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageLabel( returnId,  packageId,  returnAsBase64Png);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetPackageLabelClient(string returnId, string packageId, bool? returnAsBase64Png =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageLabelUrl(returnId, packageId, returnAsBase64Png);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackage( returnId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> GetPackageClient(string returnId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageUrl(returnId, packageId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return for which to create a replacement package.</param>
		/// <param name="package">Properties of the physical package for a return replacement.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackage( pkg,  returnId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.CreatePackageUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to update.</param>
		/// <param name="package">Properties of the return replacement package to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePackage( pkg,  returnId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> UpdatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.UpdatePackageUrl(returnId, packageId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to delete.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackage( returnId,  packageId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeletePackageClient(string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.DeletePackageUrl(returnId, packageId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


