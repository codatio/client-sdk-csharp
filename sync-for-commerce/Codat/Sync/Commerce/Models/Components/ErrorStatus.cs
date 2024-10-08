//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Components
{
    using Codat.Sync.Commerce.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The current status of a transient error. Null statuses indicate that the error is not transient.
    /// </summary>
    public enum ErrorStatus
    {
        [JsonProperty("Active")]
        Active,
        [JsonProperty("Resolved")]
        Resolved,
    }

    public static class ErrorStatusExtension
    {
        public static string Value(this ErrorStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ErrorStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ErrorStatus).GetFields())
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

                    if (enumVal is ErrorStatus)
                    {
                        return (ErrorStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ErrorStatus");
        }
    }

}