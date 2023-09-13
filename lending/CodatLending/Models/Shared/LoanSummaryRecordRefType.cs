
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
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (LoanSummaryRecordRefType)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum LoanSummaryRecordRefType");
        }
    }
    
}