
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Method of payment.
    /// </summary>
    public enum PaymentMethodType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Cash")]
        Cash,
        [JsonProperty("Check")]
        Check,
        [JsonProperty("CreditCard")]
        CreditCard,
        [JsonProperty("DebitCard")]
        DebitCard,
        [JsonProperty("BankTransfer")]
        BankTransfer,
        [JsonProperty("Other")]
        Other,
    }

    public static class PaymentMethodTypeExtension
    {
        public static string Value(this PaymentMethodType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PaymentMethodType ToEnum(this string value)
        {
            foreach(var field in typeof(PaymentMethodType).GetFields())
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

                    if (enumVal is PaymentMethodType)
                    {
                        return (PaymentMethodType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PaymentMethodType");
        }
    }
}