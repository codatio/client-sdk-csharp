
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
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
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is AccountStatus)
                    {
                        return (AccountStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountStatus");
        }
    }
}