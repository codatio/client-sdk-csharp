
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
    /// Status of the account
    /// </summary>
    public enum AccountStatus
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Active")]
		Active,
		[JsonProperty("Archived")]
		Archived,
		[JsonProperty("Pending")]
		Pending,
    }
    
    public static class AccountStatusExtension
    {
        public static string Value(this AccountStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountStatus ToEnum(this string value)
        {
            foreach(var field in typeof(AccountStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (AccountStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountStatus");
        }
    }
    
}