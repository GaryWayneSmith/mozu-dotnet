
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Carts resource to manage storefront shopping carts as items are added and removed. Each time a shopper's cart is modified, the Carts resource updates the estimated total with any applicable discounts.
	/// </summary>
	public partial class CartResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CartResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CartResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CartResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cartSummary = await cart.GetCartSummaryByCartIdAsync( cartId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetCartSummaryByCartIdAsync(string cartId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetCartSummaryByCartIdClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId">Identifier of the cart to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetCartAsync( cartId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetCartAsync(string cartId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetCartClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetOrCreateCartAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetOrCreateCartAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetOrCreateCartClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cartSummary = await cart.GetCartSummaryAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetCartSummaryAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetCartSummaryClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId">Unique identifier of the user whose cart details you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cartSummary = await cart.GetUserCartSummaryAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetUserCartSummaryAsync(string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetUserCartSummaryClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId">Unique identifier of the user whose cart you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetUserCartAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetUserCartAsync(string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetUserCartClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="discountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.RejectSuggestedDiscountAsync( cartId,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RejectSuggestedDiscountAsync(string cartId, int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.RejectSuggestedDiscountClient( cartId,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetOrCreateUserCartAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetOrCreateUserCartAsync(string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetOrCreateUserCartClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="responseFields"></param>
		/// <param name="cart"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.UpdateCartByCartIdAsync( cart,  cartId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> UpdateCartByCartIdAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.Cart cart, string cartId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.UpdateCartByCartIdClient( cart,  cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="cart">All of the properties of the cart to update. The product code is required.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.UpdateCartAsync( cart,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> UpdateCartAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.Cart cart, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.UpdateCartClient( cart,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId"></param>
		/// <param name="cart"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.UpdateUserCartAsync( cart,  userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> UpdateUserCartAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.Cart cart, string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.UpdateUserCartClient( cart,  userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var stream = await cart.DeleteCartAsync( cartId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteCartAsync(string cartId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.DeleteCartClient( cartId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="userId"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var stream = await cart.DeleteUserCartAsync( userId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteUserCartAsync(string userId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.DeleteUserCartClient( userId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var stream = await cart.DeleteCurrentCartAsync();
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteCurrentCartAsync(CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.DeleteCurrentCartClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


