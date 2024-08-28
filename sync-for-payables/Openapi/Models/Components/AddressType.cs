//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Components
{
    using Newtonsoft.Json;
    using Openapi.Utils;
    using System;
    
    /// <summary>
    /// The type of the address
    /// </summary>
    public enum AddressType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Billing")]
        Billing,
        [JsonProperty("Delivery")]
        Delivery,
    }

    public static class AddressTypeExtension
    {
        public static string Value(this AddressType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AddressType ToEnum(this string value)
        {
            foreach(var field in typeof(AddressType).GetFields())
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

                    if (enumVal is AddressType)
                    {
                        return (AddressType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AddressType");
        }
    }

}