
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EntityListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EntityListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EntityListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EntityListResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityListCollection = await entitylist.GetEntityListsAsync( pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityListCollection> GetEntityListsAsync(int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityListCollection> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListsClient( pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.GetEntityListAsync( entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> GetEntityListAsync(string entityListFullName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListClient( entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="entityList"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.CreateEntityListAsync( entityList,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> CreateEntityListAsync(Mozu.Api.Contracts.MZDB.EntityList entityList, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.CreateEntityListClient( entityList,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields"></param>
		/// <param name="entityList"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.UpdateEntityListAsync( entityList,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> UpdateEntityListAsync(Mozu.Api.Contracts.MZDB.EntityList entityList, string entityListFullName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.UpdateEntityListClient( entityList,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var stream = await entitylist.DeleteEntityListAsync( entityListFullName);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> DeleteEntityListAsync(string entityListFullName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.DeleteEntityListClient( entityListFullName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


