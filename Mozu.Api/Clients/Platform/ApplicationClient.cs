
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ApplicationClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.PackageNamesCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAppPackageNames( applicationKey,  responseFields);
		///   var packageNamesCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.PackageNamesCollection> GetAppPackageNamesClient(string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetAppPackageNamesUrl(applicationKey, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.PackageNamesCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="nsAndAppId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAppVersions( nsAndAppId,  responseFields);
		///   var applicationVersionsCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection> GetAppVersionsClient(string nsAndAppId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetAppVersionsUrl(nsAndAppId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageFileMetadata( applicationKey,  filepath,  responseFields);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> GetPackageFileMetadataClient(string applicationKey, string filepath, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetPackageFileMetadataUrl(applicationKey, filepath, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FolderMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageMetadata( applicationKey,  responseFields);
		///   var folderMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FolderMetadata> GetPackageMetadataClient(string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetPackageMetadataUrl(applicationKey, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FolderMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <param name="lastModifiedTime"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpsertPackageFile( applicationKey,  filepath,  lastModifiedTime,  responseFields);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> UpsertPackageFileClient(string applicationKey, string filepath, string lastModifiedTime =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.UpsertPackageFileUrl(applicationKey, filepath, lastModifiedTime, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields"></param>
		/// <param name="renameInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RenamePackageFile( renameInfo,  applicationKey,  responseFields);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> RenamePackageFileClient(Mozu.Api.Contracts.AppDev.RenameInfo renameInfo, string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.RenamePackageFileUrl(applicationKey, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.AppDev.RenameInfo>(renameInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackageFile( applicationKey,  filepath);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeletePackageFileClient(string applicationKey, string filepath)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.DeletePackageFileUrl(applicationKey, filepath);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


