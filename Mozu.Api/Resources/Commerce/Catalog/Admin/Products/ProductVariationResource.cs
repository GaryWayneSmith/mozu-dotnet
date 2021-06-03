
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the product variations sub-resource to manage the variations of a product based on its attributes. For example, a t-shirt product could be offered in six variations: Small Black, Medium Black, Large Black, Small White, Medium White, and Large White.
	/// </summary>
	public partial class ProductVariationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductVariationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductVariationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductVariationResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductVariationResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.GetProductVariationLocalizedDeltaPricesAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> GetProductVariationLocalizedDeltaPricesAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPricesClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.GetProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> GetProductVariationLocalizedDeltaPriceAsync(string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.GetProductVariationLocalizedPricesAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> GetProductVariationLocalizedPricesAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedPricesClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.GetProductVariationLocalizedPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> GetProductVariationLocalizedPriceAsync(string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = await productvariation.GetProductVariationAsync(_dataViewMode,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariation> GetProductVariationAsync(string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationClient(_dataViewMode,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationPagedCollection = await productvariation.GetProductVariationsAsync(_dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> GetProductVariationsAsync(string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationsClient(_dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedDeltaPrice">The difference between the base price for the product and this variation of the product, which can be a positive or negative decimal value. For example, if the base price for a t-shirt product is $10, but the XL variation should cost $12, the DeltaPrice value should be "2". However, if the XS variation should only cost $8, the DeltaPrice value should be "-2".</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.AddProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> AddProductVariationLocalizedDeltaPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.AddProductVariationLocalizedDeltaPriceClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedPrice">The details of the product variation localized price.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.AddProductVariationLocalizedPriceAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> AddProductVariationLocalizedPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice localizedPrice, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.AddProductVariationLocalizedPriceClient(_dataViewMode,  localizedPrice,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedDeltaPrice">The difference between the base price for the product and this variation of the product, which can be a positive or negative decimal value. For example, if the base price for a t-shirt product is $10, but the XL variation should cost $12, the DeltaPrice value should be "2". However, if the XS variation should only cost $8, the DeltaPrice value should be "-2".</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.UpdateProductVariationLocalizedDeltaPricesAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> UpdateProductVariationLocalizedDeltaPricesAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> localizedDeltaPrice, string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPricesClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedDeltaPrice">The difference between the base price for the product and this variation of the product, which can be a positive or negative decimal value. For example, if the base price for a t-shirt product is $10, but the XL variation should cost $12, the DeltaPrice value should be "2". However, if the XS variation should only cost $8, the DeltaPrice value should be "-2".</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.UpdateProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> UpdateProductVariationLocalizedDeltaPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPriceClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedPrice">The details of the product variation localized price.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.UpdateProductVariationLocalizedPricesAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> UpdateProductVariationLocalizedPricesAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> localizedPrice, string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedPricesClient(_dataViewMode,  localizedPrice,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="localizedPrice">The details of the product variation localized price.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.UpdateProductVariationLocalizedPriceAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> UpdateProductVariationLocalizedPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice localizedPrice, string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedPriceClient(_dataViewMode,  localizedPrice,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="productVariation">Properties of a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = await productvariation.UpdateProductVariationAsync(_dataViewMode,  productVariation,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariation> UpdateProductVariationAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariation productVariation, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationClient(_dataViewMode,  productVariation,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="productVariations">Collection of variations configured for a product.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationCollection = await productvariation.UpdateProductVariationsAsync(_dataViewMode,  productVariations,  productCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> UpdateProductVariationsAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection productVariations, string productCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationsClient(_dataViewMode,  productVariations,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var stream = await productvariation.DeleteProductVariationAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteProductVariationAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var stream = await productvariation.DeleteProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteProductVariationLocalizedDeltaPriceAsync(string productCode, string variationKey, string currencyCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationLocalizedDeltaPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode">The three character ISOÂ currency code, such as USDÂ for US Dollars.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var stream = await productvariation.DeleteProductVariationLocalizedPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteProductVariationLocalizedPriceAsync(string productCode, string variationKey, string currencyCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationLocalizedPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


