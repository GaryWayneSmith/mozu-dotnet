
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of an attribute used to describe customers or orders.
		///
		public class Attribute
		{
			public string AdminName { get; set; }

			public string AttributeCode { get; set; }

			public int? AttributeDataTypeSequence { get; set; }

			public string AttributeFQN { get; set; }

			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			public int? AttributeSequence { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public AttributeLocalizedContent Content { get; set; }

			public string DataType { get; set; }

			public string InputType { get; set; }

			public bool? IsExtra { get; set; }

			public bool? IsOption { get; set; }

			public bool? IsProperty { get; set; }

			public bool? IsValueMappingAttribute { get; set; }

			///
			///The localized content associated with the object.
			///
			public List<AttributeLocalizedContent> LocalizedContent { get; set; }

			public int? MasterCatalogId { get; set; }

			public string Namespace { get; set; }

			///
			///This API type provides the search and indexing settings for the attribute.
			///
			public AttributeSearchSettings SearchSettings { get; set; }

			public AttributeValidation Validation { get; set; }

			public string ValueMappingAttributeFQN { get; set; }

			public string ValueType { get; set; }

			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}