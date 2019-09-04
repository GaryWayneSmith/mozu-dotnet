
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Vocabulary values are predefined for an attribute.
	/// </summary>
	public partial class AttributeVocabularyValueResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AttributeVocabularyValueResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AttributeVocabularyValueResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AttributeVocabularyValueResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = await attributevocabularyvalue.GetAttributeVocabularyValuesAsync( attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> GetAttributeVocabularyValuesAsync(string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = await attributevocabularyvalue.GetAttributeVocabularyValueLocalizedContentsAsync( attributeFQN,  value);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> GetAttributeVocabularyValueLocalizedContentsAsync(string attributeFQN, string value, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentsClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = await attributevocabularyvalue.GetAttributeVocabularyValueLocalizedContentAsync( attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> GetAttributeVocabularyValueLocalizedContentAsync(string attributeFQN, string value, string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary to retrieve. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = await attributevocabularyvalue.GetAttributeVocabularyValueAsync( attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> GetAttributeVocabularyValueAsync(string attributeFQN, string value, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueClient( attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = await attributevocabularyvalue.AddAttributeVocabularyValueLocalizedContentAsync( localizedContent,  attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> AddAttributeVocabularyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = await attributevocabularyvalue.AddAttributeVocabularyValueAsync( attributeVocabularyValue,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> AddAttributeVocabularyValueAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="vocabularyValues">The actual vocabulary values for the attribute being updated.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = await attributevocabularyvalue.UpdateAttributeVocabularyValuesAsync( vocabularyValues,  attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> UpdateAttributeVocabularyValuesAsync(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> vocabularyValues, string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValuesClient( vocabularyValues,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = await attributevocabularyvalue.UpdateAttributeVocabularyValueLocalizedContentsAsync( localizedContent,  attributeFQN,  value);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> UpdateAttributeVocabularyValueLocalizedContentsAsync(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> localizedContent, string attributeFQN, string value, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentsClient( localizedContent,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = await attributevocabularyvalue.UpdateAttributeVocabularyValueLocalizedContentAsync( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> UpdateAttributeVocabularyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary value to update. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = await attributevocabularyvalue.UpdateAttributeVocabularyValueAsync( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> UpdateAttributeVocabularyValueAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string value, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary to delete. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var stream = await attributevocabularyvalue.DeleteAttributeVocabularyValueAsync( attributeFQN,  value);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteAttributeVocabularyValueAsync(string attributeFQN, string value, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var stream = await attributevocabularyvalue.DeleteAttributeVocabularyValueLocalizedContentAsync( attributeFQN,  value,  localeCode);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteAttributeVocabularyValueLocalizedContentAsync(string attributeFQN, string value, string localeCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


