
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Allows you to temporarily hold a product from inventory while a shopper is filling out payment information. You create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class SoftAllocationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SoftAllocationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SoftAllocationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SoftAllocationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of sof allocations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocationCollection = softallocation.GetSoftAllocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection GetSoftAllocations(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of sof allocations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocationCollection = await softallocation.GetSoftAllocationsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> GetSoftAllocationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a soft allocation.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.GetSoftAllocation( softAllocationId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SoftAllocation GetSoftAllocation(int softAllocationId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationClient( softAllocationId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a soft allocation.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.GetSoftAllocationAsync( softAllocationId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> GetSoftAllocationAsync(int softAllocationId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.GetSoftAllocationClient( softAllocationId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new product reservation for a product. This places a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationsIn">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.AddSoftAllocations( softAllocationsIn);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> AddSoftAllocations(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocationsIn)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.AddSoftAllocationsClient( softAllocationsIn);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new product reservation for a product. This places a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationsIn">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.AddSoftAllocationsAsync( softAllocationsIn);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> AddSoftAllocationsAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocationsIn)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.AddSoftAllocationsClient( softAllocationsIn);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Converts a set of existing softAllocations into productReservations
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var productReservation = softallocation.ConvertToProductReservation( softAllocations);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> ConvertToProductReservation(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.ConvertToProductReservationClient( softAllocations);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Converts a set of existing softAllocations into productReservations
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var productReservation = await softallocation.ConvertToProductReservationAsync( softAllocations);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> ConvertToProductReservationAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.ConvertToProductReservationClient( softAllocations);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates a set of softAllocations expiration time in a non trassactional batch
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationRenew">Mozu.ProductAdmin.Contracts.SoftAllocationRenew ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.RenewSoftAllocations( softAllocationRenew);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> RenewSoftAllocations(Mozu.Api.Contracts.ProductAdmin.SoftAllocationRenew softAllocationRenew)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.RenewSoftAllocationsClient( softAllocationRenew);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a set of softAllocations expiration time in a non trassactional batch
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationRenew">Mozu.ProductAdmin.Contracts.SoftAllocationRenew ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.RenewSoftAllocationsAsync( softAllocationRenew);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> RenewSoftAllocationsAsync(Mozu.Api.Contracts.ProductAdmin.SoftAllocationRenew softAllocationRenew)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.RenewSoftAllocationsClient( softAllocationRenew);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates a soft allocationt. This updates a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = softallocation.UpdateSoftAllocations( softAllocations);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> UpdateSoftAllocations(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.UpdateSoftAllocationsClient( softAllocations);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a soft allocationt. This updates a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations">Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   var softAllocation = await softallocation.UpdateSoftAllocationsAsync( softAllocations);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> UpdateSoftAllocationsAsync(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.UpdateSoftAllocationsClient( softAllocations);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a soft allocation. You might delete a allocation when an order or cart is not processed to return the product quantity back to inventory.
		/// </summary>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   softallocation.DeleteSoftAllocation( softAllocationId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteSoftAllocation(int softAllocationId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.DeleteSoftAllocationClient( softAllocationId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a soft allocation. You might delete a allocation when an order or cart is not processed to return the product quantity back to inventory.
		/// </summary>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var softallocation = new SoftAllocation();
		///   await softallocation.DeleteSoftAllocationAsync( softAllocationId);
		/// </code>
		/// </example>
		public virtual async Task DeleteSoftAllocationAsync(int softAllocationId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SoftAllocationClient.DeleteSoftAllocationClient( softAllocationId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

