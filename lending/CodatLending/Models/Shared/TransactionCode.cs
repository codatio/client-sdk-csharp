
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
    /// Code to identify the underlying transaction.
    /// </summary>
    public enum TransactionCode
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Fee")]
		Fee,
		[JsonProperty("Payment")]
		Payment,
		[JsonProperty("Cash")]
		Cash,
		[JsonProperty("Transfer")]
		Transfer,
		[JsonProperty("Interest")]
		Interest,
		[JsonProperty("Cashback")]
		Cashback,
		[JsonProperty("Cheque")]
		Cheque,
		[JsonProperty("DirectDebit")]
		DirectDebit,
		[JsonProperty("Purchase")]
		Purchase,
		[JsonProperty("StandingOrder")]
		StandingOrder,
		[JsonProperty("Adjustment")]
		Adjustment,
		[JsonProperty("Credit")]
		Credit,
		[JsonProperty("Other")]
		Other,
		[JsonProperty("NotSupported")]
		NotSupported,
    }
    
    public static class TransactionCodeExtension
    {
        public static string Value(this TransactionCode value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TransactionCode ToEnum(this string value)
        {
            foreach(var field in typeof(TransactionCode).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (TransactionCode)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum TransactionCode");
        }
    }
    
}