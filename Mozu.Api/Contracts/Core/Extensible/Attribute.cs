
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

namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Properties of an attribute used to describe customers or orders.
		///
		public class Attribute
		{
			///
			///Name of this extensible attribute defined in Mozu Admin.
			///
			public string AdminName { get; set; }

			///
			///Merchant-defined code for an extensible attribute.
			///
			public string AttributeCode { get; set; }

			public string AttributeFQN { get; set; }

			///
			///List of metadata key-value pairs defined for an extensible attribute.
			///
			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			public AuditInfo AuditInfo { get; set; }

			///
			///The localized name and description of the attribute, displayed in the locale code specified for the master catalog.
			///
			public AttributeLocalizedContent Content { get; set; }

			///
			///The data type of the customer or order attribute, which is Bool, DateTime, Number, or String.
			///
			public string DataType { get; set; }

			///
			///Whether the customer or order attribute appears in Mozu Admin only, or in both Mozu Admin and the website storefront. Possible values are Admin and AdminAndStorefront.
			///
			public string DisplayGroup { get; set; }

			public int? Id { get; set; }

			///
			///The type of input selection used to define a value for the attribute, which is YesNo, Date, DateTime, List, TextBox, or TextArea.
			///
			public string InputType { get; set; }

			///
			///If true, the customer or order attribute is active.
			///
			public bool? IsActive { get; set; }

			///
			///If true, the attribute can have more than one value.
			///
			public bool? IsMultiValued { get; set; }

			public bool IsReadOnly { get; set; }

			///
			///If true, the attribute must have a defined value.
			///
			public bool? IsRequired { get; set; }

			///
			///If true, the attribute is visible in its defined display group.
			///
			public bool? IsVisible { get; set; }

			///
			///Namespace associated with this extensible attribute.
			///
			public string Namespace { get; set; }

			///
			///Integer that represents the sequence of the attribute.
			///
			public int? Order { get; set; }

			///
			///Properties used when validating a value entered for an extensible attribute.
			///
			public AttributeValidation Validation { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during attribute set up or it can be "AdminEntered" or "ShopperEntered". The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

			///
			///List of valid vocabulary values defined for an attribute.
			///
			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}