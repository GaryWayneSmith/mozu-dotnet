
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

using Mozu.Api.Contracts.PaymentService;

namespace Mozu.Api.Contracts.PaymentService.Request
{
		///
		///	Mozu.PaymentService.Contracts.Request.FraudScreenRequest ApiType DOCUMENT_HERE 
		///
		public class FraudScreenRequest
		{
			///
			///Contains the avs codes from the gateway.
			///
			public string AvsCodes { get; set; }

			///
			///The billing address used in the transaction.
			///
			public Address BillingAddress { get; set; }

			///
			///The cardholder's billing contact information, including addresses.
			///
			public Contact BillingContact { get; set; }

			///
			///Unique identifier of the card associated with the customer account billing contact.
			///
			public string CardId { get; set; }

			///
			///The masked credit card number part returned from the payment gateway.
			///
			public string CardNumberPart { get; set; }

			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest credentialFieldsOverride ApiTypeMember DOCUMENT_HERE 
			///
			public List<GatewayCredentialFieldValue> CredentialFieldsOverride { get; set; }

			///
			///The localized currency code for the monetary amount. 
			///
			public string CurrencyCode { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest customData ApiTypeMember DOCUMENT_HERE 
			///
			public List<CustomData> CustomData { get; set; }

			///
			///Unique identifier of the customer in , used to associate customers with data, orders, returns, and in-store credit.
			///
			public string CustomerId { get; set; }

			///
			///The CVV code for the credit card.
			///
			public string CvV2Codes { get; set; }

			///
			///The two-digit month a credit card expires for a payment method.
			///
			public int ExpireMonth { get; set; }

			///
			///The four-digit year the credit card expires for a payment method.
			///
			public int ExpireYear { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest gatewayAccountId ApiTypeMember DOCUMENT_HERE 
			///
			public string GatewayAccountId { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest merchantTransactionId ApiTypeMember DOCUMENT_HERE 
			///
			public string MerchantTransactionId { get; set; }

			///
			///A list of items included in the order.
			///
			public List<OrderItem> OrderItems { get; set; }

			///
			///The unique identifier of the order.
			///
			public int OrderNumber { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest paymentTransactionId ApiTypeMember DOCUMENT_HERE 
			///
			public string PaymentTransactionId { get; set; }

			///
			///The type of payment, such as credit card, check, or PayPal Express. Additional payment types will be supported in future releases.
			///
			public string PaymentType { get; set; }

			///
			///Contains the IP the customer is using.
			///
			public string RequestorIp { get; set; }

			///
			///Contains the url the customer is using.
			///
			public string RequestorUrl { get; set; }

			///
			///Contains the user agent the customer is using.
			///
			public string RequestorUserAgent { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest shippingAddress ApiTypeMember DOCUMENT_HERE 
			///
			public Address ShippingAddress { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest shippingContact ApiTypeMember DOCUMENT_HERE 
			///
			public Contact ShippingContact { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest shipType ApiTypeMember DOCUMENT_HERE 
			///
			public string ShipType { get; set; }

			///
			///Total is used to indicate the monetary, estimated total amount of the cart or order, including items, sales tax, shipping costs, and other fees. Totals are not estimated for wish lists at this time.
			///
			public decimal Total { get; set; }

		}

}