
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
    /// The datatype being referred to.
    /// </summary>
    public enum LoanSummaryRecordRefType
    {
        [JsonProperty("accounts")]
        Accounts,
        [JsonProperty("banking-accounts")]
        BankingAccounts,
        [JsonProperty("commerce-transactions")]
        CommerceTransactions,
    }

    public static class LoanSummaryRecordRefTypeExtension
    {
        public static string Value(this LoanSummaryRecordRefType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LoanSummaryRecordRefType ToEnum(this string value)
        {
            foreach(var field in typeof(LoanSummaryRecordRefType).GetFields())
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

                    if (enumVal is LoanSummaryRecordRefType)
                    {
                        return (LoanSummaryRecordRefType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LoanSummaryRecordRefType");
        }
    }
}