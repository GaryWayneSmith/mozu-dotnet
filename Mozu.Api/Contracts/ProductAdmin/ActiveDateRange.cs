
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Specifies a start date and end date for when associated object is on the live site, if  is set to .If  is set to  ignores this property.
		///
		public class ActiveDateRange
		{
			///
			///The date that the product is no longer active on the site.
			///
			public DateTime? EndDate { get; set; }

			///
			///The date that the product starts being active on the site.
			///
			public DateTime? StartDate { get; set; }

		}

}