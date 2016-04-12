
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

namespace Mozu.Api.Resources.Commerce.Settings.General
{
	/// <summary>
	/// Use the Custom Routes resource to manage your custom route settings. Custom routing allows you to display SEO-friendly URLs on your site that map behind-the-scenes to conventional Mozu resources such as a product page or a search results page. With custom routing, you gain advanced control over the URL structures on your site and can more visibly highlight the products or categories your shoppers are interested in purchasing.To learn more about custom routing, refer to the [Custom Route Settings](../../../guides/settings/custom-routes.htm) topic.
	/// </summary>
	public partial class CustomRouteSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomRouteSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomRouteSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomRouteSettingsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the custom route settings configured for a site. These are the same settings configured through  in the Custom Routing JSON Editor.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = customroutesettings.GetCustomRouteSettings( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings GetCustomRouteSettings(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.GetCustomRouteSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the custom route settings configured for a site. These are the same settings configured through  in the Custom Routing JSON Editor.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = await customroutesettings.GetCustomRouteSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> GetCustomRouteSettingsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.GetCustomRouteSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Create new custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = customroutesettings.CreateCustomRouteSettings( settings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings CreateCustomRouteSettings(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.CreateCustomRouteSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Create new custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = await customroutesettings.CreateCustomRouteSettingsAsync( settings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> CreateCustomRouteSettingsAsync(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.CreateCustomRouteSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = customroutesettings.UpdateCustomRouteSettings( settings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings UpdateCustomRouteSettings(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.UpdateCustomRouteSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   var customRouteSettings = await customroutesettings.UpdateCustomRouteSettingsAsync( settings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> UpdateCustomRouteSettingsAsync(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.UpdateCustomRouteSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes all the custom route settings for a site, returning all routes to their Mozu defaults.
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   customroutesettings.DeleteCustomRouteSettings();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCustomRouteSettings()
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.DeleteCustomRouteSettingsClient();
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes all the custom route settings for a site, returning all routes to their Mozu defaults.
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customroutesettings = new CustomRouteSettings();
		///   await customroutesettings.DeleteCustomRouteSettingsAsync();
		/// </code>
		/// </example>
		public virtual async Task DeleteCustomRouteSettingsAsync()
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.DeleteCustomRouteSettingsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

