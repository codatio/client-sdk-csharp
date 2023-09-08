
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    /// <summary>
    /// Types of payment line links, either:  
    /// 
    /// <remarks>
    /// `Unknown`  
    /// `Unlinked` - Not used  
    /// `Invoice` - ID refers to the invoice  
    /// `CreditNote` - ID refers to the credit note  
    /// `Refund` - ID refers to the sibling payment  
    /// `Payment` - ID refers to the sibling payment  
    /// `PaymentOnAccount` - ID refers to the customer  
    /// `Other` - ID refers to the customer  
    /// `Manual Journal`  
    /// `Discount` - ID refers to the payment
    /// </remarks>
    /// </summary>
    public enum PaymentLinkType
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Unlinked")]
		Unlinked,
		[JsonProperty("Invoice")]
		Invoice,
		[JsonProperty("CreditNote")]
		CreditNote,
		[JsonProperty("Other")]
		Other,
		[JsonProperty("Refund")]
		Refund,
		[JsonProperty("Payment")]
		Payment,
		[JsonProperty("PaymentOnAccount")]
		PaymentOnAccount,
		[JsonProperty("ManualJournal")]
		ManualJournal,
		[JsonProperty("Discount")]
		Discount,
    }
    
    public static class PaymentLinkTypeExtension
    {
        public static string Value(this PaymentLinkType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PaymentLinkType ToEnum(this string value)
        {
            foreach(var field in typeof(PaymentLinkType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is PaymentLinkType)
                    {
                        return (PaymentLinkType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PaymentLinkType");
        }
    }
    
}