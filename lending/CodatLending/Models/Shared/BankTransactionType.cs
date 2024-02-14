
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Type of transaction for the bank statement line.
    /// </summary>
    public enum BankTransactionType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Credit")]
        Credit,
        [JsonProperty("Debit")]
        Debit,
        [JsonProperty("Int")]
        Int,
        [JsonProperty("Div")]
        Div,
        [JsonProperty("Fee")]
        Fee,
        [JsonProperty("SerChg")]
        SerChg,
        [JsonProperty("Dep")]
        Dep,
        [JsonProperty("Atm")]
        Atm,
        [JsonProperty("Pos")]
        Pos,
        [JsonProperty("Xfer")]
        Xfer,
        [JsonProperty("Check")]
        Check,
        [JsonProperty("Payment")]
        Payment,
        [JsonProperty("Cash")]
        Cash,
        [JsonProperty("DirectDep")]
        DirectDep,
        [JsonProperty("DirectDebit")]
        DirectDebit,
        [JsonProperty("RepeatPmt")]
        RepeatPmt,
        [JsonProperty("Other")]
        Other,
    }

    public static class BankTransactionTypeExtension
    {
        public static string Value(this BankTransactionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BankTransactionType ToEnum(this string value)
        {
            foreach(var field in typeof(BankTransactionType).GetFields())
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

                    if (enumVal is BankTransactionType)
                    {
                        return (BankTransactionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BankTransactionType");
        }
    }

}