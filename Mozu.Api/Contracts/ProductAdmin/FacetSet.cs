
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

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The list of category, price, and attribute facets defined or available for definition for the category.
		///
		public class FacetSet
		{
			///
			///The list of subcategories and attributes that have not been defined as facets for the category.
			///
			public List<FacetSource> Available { get; set; }

			///
			///The list of category, price, and attribute facets defined for the category.
			///
			public List<Facet> Configured { get; set; }

		}

}