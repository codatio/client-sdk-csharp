
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Current journal status.
    /// </summary>
    public enum JournalStatus
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Active")]
        Active,
        [JsonProperty("Archived")]
        Archived,
    }

    public static class JournalStatusExtension
    {
        public static string Value(this JournalStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static JournalStatus ToEnum(this string value)
        {
            foreach(var field in typeof(JournalStatus).GetFields())
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

                    if (enumVal is JournalStatus)
                    {
                        return (JournalStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum JournalStatus");
        }
    }
}