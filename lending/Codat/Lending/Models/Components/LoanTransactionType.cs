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
    /// The type of loan transaction.
    /// </summary>
    public enum LoanTransactionType
    {
        [JsonProperty("Investment")]
        Investment,
        [JsonProperty("Repayment")]
        Repayment,
        [JsonProperty("Interest")]
        Interest,
        [JsonProperty("AccuredInterest")]
        AccuredInterest,
    }

    public static class LoanTransactionTypeExtension
    {
        public static string Value(this LoanTransactionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LoanTransactionType ToEnum(this string value)
        {
            foreach(var field in typeof(LoanTransactionType).GetFields())
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

                    if (enumVal is LoanTransactionType)
                    {
                        return (LoanTransactionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LoanTransactionType");
        }
    }

}