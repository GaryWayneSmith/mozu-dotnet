
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Mozu.Api.Contracts.Event;


namespace Mozu.Api.Events
{
	public interface IPaymentEvents
	{
		[Obsolete("This method is obsolete; use the async method instead")]
		void Refunded(IApiContext apiContext, Event eventPayLoad);

		Task RefundedAsync(IApiContext apiContext, Event eventPayLoad);

		[Obsolete("This method is obsolete; use the async method instead")]
		void TransactionError(IApiContext apiContext, Event eventPayLoad);

		Task TransactionErrorAsync(IApiContext apiContext, Event eventPayLoad);

	}

}