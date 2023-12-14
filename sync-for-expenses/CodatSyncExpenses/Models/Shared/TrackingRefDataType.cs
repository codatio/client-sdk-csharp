
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
    /// The type of the linked reference
    /// </summary>
    public enum TrackingRefDataType
    {
        [JsonProperty("trackingCategories")]
        TrackingCategories,
        [JsonProperty("customers")]
        Customers,
    }

    public static class TrackingRefDataTypeExtension
    {
        public static string Value(this TrackingRefDataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TrackingRefDataType ToEnum(this string value)
        {
            foreach(var field in typeof(TrackingRefDataType).GetFields())
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

                    if (enumVal is TrackingRefDataType)
                    {
                        return (TrackingRefDataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TrackingRefDataType");
        }
    }
}