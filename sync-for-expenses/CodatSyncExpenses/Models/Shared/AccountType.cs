
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    /// <summary>
    /// Type of account
    /// </summary>
    public enum AccountType
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Asset")]
		Asset,
		[JsonProperty("Expense")]
		Expense,
		[JsonProperty("Income")]
		Income,
		[JsonProperty("Liability")]
		Liability,
		[JsonProperty("Equity")]
		Equity,
    }
    
    public static class AccountTypeExtension
    {
        public static string Value(this AccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountType ToEnum(this string value)
        {
            foreach(var field in typeof(AccountType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (AccountType)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountType");
        }
    }
    
}