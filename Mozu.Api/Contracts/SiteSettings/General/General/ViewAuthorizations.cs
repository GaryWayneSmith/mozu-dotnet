
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.SiteSettings.General.General
{
		///
		///	Set whether you require users to be authenticated to preview content or view the live site.
		///
		public class ViewAuthorizations
		{
			public bool? EnforceSitewideSSL { get; set; }

			///
			///Mozu.SiteSettings.General.Contracts.General.ViewAuthorizations requireAuthForLive ApiTypeMember DOCUMENT_HERE 
			///
			public bool RequireAuthForLive { get; set; }

			///
			///Mozu.SiteSettings.General.Contracts.General.ViewAuthorizations requireAuthForPending ApiTypeMember DOCUMENT_HERE 
			///
			public bool RequireAuthForPending { get; set; }

		}

}