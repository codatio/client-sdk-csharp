//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
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
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is TransactionCode)
                    {
                        return (TransactionCode)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TransactionCode");
        }
    }

}