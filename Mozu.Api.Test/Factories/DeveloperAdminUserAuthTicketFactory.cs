//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use this resource to manage authentication tickets for your developer account.
	/// </summary>
	public partial class DeveloperAdminUserAuthTicketFactory : BaseDataFactory
	{

		/// <summary> 
		/// Generate an authentication ticket for a developer account.
		/// <example> 
		///  <code> 
		/// var result = DeveloperAdminUserAuthTicketFactory.CreateDeveloperUserAuthTicket(handler : handler,  userAuthInfo :  userAuthInfo,  developerAccountId :  developerAccountId,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DeveloperAdminUserAuthTicket/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket CreateDeveloperUserAuthTicket(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? developerAccountId = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.CreateDeveloperUserAuthTicketClient(
				 userAuthInfo :  userAuthInfo,  developerAccountId :  developerAccountId		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Generates a new developer account authentication ticket for the specified tenant by supplying the defined refresh token information.
		/// <example> 
		///  <code> 
		/// var result = DeveloperAdminUserAuthTicketFactory.RefreshDeveloperAuthTicket(handler : handler,  existingAuthTicket :  existingAuthTicket,  developerAccountId :  developerAccountId,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DeveloperAdminUserAuthTicket/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket RefreshDeveloperAuthTicket(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket, int? developerAccountId = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.RefreshDeveloperAuthTicketClient(
				 existingAuthTicket :  existingAuthTicket,  developerAccountId :  developerAccountId		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Deletes the authentication ticket for the developer account by supplying the refresh token.
		/// <example> 
		///  <code> 
		/// var result = DeveloperAdminUserAuthTicketFactory.DeleteUserAuthTicket(handler : handler,  refreshToken :  refreshToken,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteUserAuthTicket(ServiceClientMessageHandler handler, 
 		string refreshToken, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.DeleteUserAuthTicketClient(
				 refreshToken :  refreshToken		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
			}
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


