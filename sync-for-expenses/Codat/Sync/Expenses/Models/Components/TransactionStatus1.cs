//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Status of transaction.
    /// </summary>
    public enum TransactionStatus1
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("PushError")]
        PushError,
        [JsonProperty("Completed")]
        Completed,
        [JsonProperty("Failed")]
        Failed,
        [JsonProperty("Pending")]
        Pending,
    }

    public static class TransactionStatus1Extension
    {
        public static string Value(this TransactionStatus1 value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TransactionStatus1 ToEnum(this string value)
        {
            foreach(var field in typeof(TransactionStatus1).GetFields())
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

                    if (enumVal is TransactionStatus1)
                    {
                        return (TransactionStatus1)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TransactionStatus1");
        }
    }

}