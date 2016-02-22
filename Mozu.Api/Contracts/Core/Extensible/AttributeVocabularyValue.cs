
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Properties of a vocabulary value defined for an extensible attribute.
		///
		public class AttributeVocabularyValue
		{
			///
			///List of content associated with a vocabulary value defined for an extensible attribute.
			///
			public AttributeValueLocalizedContent Content { get; set; }

			///
			///If true, the attribute vocabulary value does not appear in the list when defining a value for the attribute.
			///
			public bool? IsHidden { get; set; }

			///
			///The numeric order of a vocabulary value defined for an extensible attribute.
			///
			public int? Sequence { get; set; }

			///
			///Possible value associated with a vocabulary value defined for an extensible attribute.
			///
			public string Value { get; set; }

		}

}