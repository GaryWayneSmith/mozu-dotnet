
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Couponsets
{
	/// <summary>
	/// Use the AssignedDiscounts resource to manage the discounts assigned to coupon sets.
	/// </summary>
	public partial class AssignedDiscountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AssignedDiscountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AssignedDiscountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AssignedDiscountResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the discountIds of any assigned discounts for the specified coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AssignedDiscount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   var assignedDiscount = assigneddiscount.GetAssignedDiscounts( couponSetCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AssignedDiscount> GetAssignedDiscounts(string couponSetCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AssignedDiscount>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.GetAssignedDiscountsClient( couponSetCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the discountIds of any assigned discounts for the specified coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AssignedDiscount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   var assignedDiscount = await assigneddiscount.GetAssignedDiscountsAsync( couponSetCode);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AssignedDiscount>> GetAssignedDiscountsAsync(string couponSetCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AssignedDiscount>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.GetAssignedDiscountsClient( couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Assigns or associates an existing discount to a specified coupon set. Use the couponSetCode parameter to specify the coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="assignedDiscount">Mozu.ProductAdmin.Contracts.AssignedDiscount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   assigneddiscount.AssignDiscount( assignedDiscount,  couponSetCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void AssignDiscount(Mozu.Api.Contracts.ProductAdmin.AssignedDiscount assignedDiscount, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.AssignDiscountClient( assignedDiscount,  couponSetCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Assigns or associates an existing discount to a specified coupon set. Use the couponSetCode parameter to specify the coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="assignedDiscount">Mozu.ProductAdmin.Contracts.AssignedDiscount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   await assigneddiscount.AssignDiscountAsync( assignedDiscount,  couponSetCode);
		/// </code>
		/// </example>
		public virtual async Task AssignDiscountAsync(Mozu.Api.Contracts.ProductAdmin.AssignedDiscount assignedDiscount, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.AssignDiscountClient( assignedDiscount,  couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Unassigns or disassociates the specified discount with the specified coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   assigneddiscount.UnAssignDiscount( couponSetCode,  discountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UnAssignDiscount(string couponSetCode, int discountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.UnAssignDiscountClient( couponSetCode,  discountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Unassigns or disassociates the specified discount with the specified coupon set.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var assigneddiscount = new AssignedDiscount();
		///   await assigneddiscount.UnAssignDiscountAsync( couponSetCode,  discountId);
		/// </code>
		/// </example>
		public virtual async Task UnAssignDiscountAsync(string couponSetCode, int discountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.AssignedDiscountClient.UnAssignDiscountClient( couponSetCode,  discountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

