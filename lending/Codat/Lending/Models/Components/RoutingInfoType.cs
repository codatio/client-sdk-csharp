//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of routing number.
    /// </summary>
    public enum RoutingInfoType
    {
        [JsonProperty("rtn")]
        Rtn,
        [JsonProperty("aba")]
        Aba,
        [JsonProperty("swift")]
        Swift,
        [JsonProperty("bsb")]
        Bsb,
        [JsonProperty("iban")]
        Iban,
        [JsonProperty("nz2")]
        Nz2,
        [JsonProperty("trno")]
        Trno,
        [JsonProperty("sortcode")]
        Sortcode,
        [JsonProperty("blz")]
        Blz,
        [JsonProperty("ifsc")]
        Ifsc,
        [JsonProperty("bankcode")]
        Bankcode,
        [JsonProperty("apca")]
        Apca,
        [JsonProperty("clabe")]
        Clabe,
    }

    public static class RoutingInfoTypeExtension
    {
        public static string Value(this RoutingInfoType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RoutingInfoType ToEnum(this string value)
        {
            foreach(var field in typeof(RoutingInfoType).GetFields())
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

                    if (enumVal is RoutingInfoType)
                    {
                        return (RoutingInfoType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RoutingInfoType");
        }
    }

}