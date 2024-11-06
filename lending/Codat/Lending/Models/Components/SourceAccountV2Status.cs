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
    /// Status of the source account.
    /// </summary>
    public enum SourceAccountV2Status
    {
        [JsonProperty("pending")]
        Pending,
        [JsonProperty("connected")]
        Connected,
        [JsonProperty("connecting")]
        Connecting,
        [JsonProperty("disconnected")]
        Disconnected,
        [JsonProperty("unknown")]
        Unknown,
    }

    public static class SourceAccountV2StatusExtension
    {
        public static string Value(this SourceAccountV2Status value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SourceAccountV2Status ToEnum(this string value)
        {
            foreach(var field in typeof(SourceAccountV2Status).GetFields())
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

                    if (enumVal is SourceAccountV2Status)
                    {
                        return (SourceAccountV2Status)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SourceAccountV2Status");
        }
    }

}