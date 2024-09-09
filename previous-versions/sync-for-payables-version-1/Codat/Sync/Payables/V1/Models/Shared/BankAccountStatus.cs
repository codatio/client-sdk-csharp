//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Status of the bank account.
    /// </summary>
    public enum BankAccountStatus
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

    public static class BankAccountStatusExtension
    {
        public static string Value(this BankAccountStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BankAccountStatus ToEnum(this string value)
        {
            foreach(var field in typeof(BankAccountStatus).GetFields())
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

                    if (enumVal is BankAccountStatus)
                    {
                        return (BankAccountStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BankAccountStatus");
        }
    }

}