
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of platform of the connection.
    /// </summary>
    public enum ConnectionSourceType
    {
        [JsonProperty("Accounting")]
        Accounting,
        [JsonProperty("Banking")]
        Banking,
        [JsonProperty("Commerce")]
        Commerce,
        [JsonProperty("Other")]
        Other,
        [JsonProperty("Unknown")]
        Unknown,
    }

    public static class ConnectionSourceTypeExtension
    {
        public static string Value(this ConnectionSourceType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ConnectionSourceType ToEnum(this string value)
        {
            foreach(var field in typeof(ConnectionSourceType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ConnectionSourceType)
                    {
                        return (ConnectionSourceType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ConnectionSourceType");
        }
    }
}