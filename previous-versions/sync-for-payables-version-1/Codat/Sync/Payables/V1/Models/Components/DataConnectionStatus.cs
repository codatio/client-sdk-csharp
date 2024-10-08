//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Components
{
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The current authorization status of the data connection.
    /// </summary>
    public enum DataConnectionStatus
    {
        [JsonProperty("PendingAuth")]
        PendingAuth,
        [JsonProperty("Linked")]
        Linked,
        [JsonProperty("Unlinked")]
        Unlinked,
        [JsonProperty("Deauthorized")]
        Deauthorized,
    }

    public static class DataConnectionStatusExtension
    {
        public static string Value(this DataConnectionStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DataConnectionStatus ToEnum(this string value)
        {
            foreach(var field in typeof(DataConnectionStatus).GetFields())
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

                    if (enumVal is DataConnectionStatus)
                    {
                        return (DataConnectionStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DataConnectionStatus");
        }
    }

}