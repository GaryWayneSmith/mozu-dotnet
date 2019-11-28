
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

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Segments resource to manage the segments that enable a client to manage groups of customers and target discounts for these segments. After a customer segment is defined, you can associate any number of customer accounts with it.
	/// </summary>
	public partial class CustomerSegmentClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegmentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSegments( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerSegmentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> GetSegmentsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.GetSegmentsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSegment( id,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> GetSegmentClient(int id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.GetSegmentUrl(id, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="segment">Properties of the customer segment to add.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSegment( segment,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> AddSegmentClient(Mozu.Api.Contracts.Customer.CustomerSegment segment, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.AddSegmentUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerSegment>(segment);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment for which to add the associated customer accounts.</param>
		/// <param name="accountIds">List of customer account IDs to add to the customer segment specified in the request.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSegmentAccounts( accountIds,  id);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> AddSegmentAccountsClient(List<int> accountIds, int id)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.AddSegmentAccountsUrl(id);
			const string verb = "POST";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(accountIds);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment.</param>
		/// <param name="responseFields"></param>
		/// <param name="segment">Properties of the customer segment to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSegment( segment,  id,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> UpdateSegmentClient(Mozu.Api.Contracts.Customer.CustomerSegment segment, int id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.UpdateSegmentUrl(id, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerSegment>(segment);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteSegment( id);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> DeleteSegmentClient(int id)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.DeleteSegmentUrl(id);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="id"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveSegmentAccount( id,  accountId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> RemoveSegmentAccountClient(int id, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.RemoveSegmentAccountUrl(id, accountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


