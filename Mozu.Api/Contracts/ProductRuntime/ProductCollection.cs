
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Collection of products and their related properties.
		///
		public class ProductCollection
		{
			public List<Product> Items { get; set; }

			public string NextCursorMark { get; set; }

			public int PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public int TotalCount { get; set; }

		}

}