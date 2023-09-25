
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
    /// The option type.
    /// </summary>
    public enum PushOptionType
    {
        [JsonProperty("Array")]
        Array,
        [JsonProperty("Object")]
        Object,
        [JsonProperty("String")]
        String,
        [JsonProperty("Number")]
        Number,
        [JsonProperty("Boolean")]
        Boolean,
        [JsonProperty("DateTime")]
        DateTime,
        [JsonProperty("File")]
        File,
        [JsonProperty("MultiPart")]
        MultiPart,
    }

    public static class PushOptionTypeExtension
    {
        public static string Value(this PushOptionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PushOptionType ToEnum(this string value)
        {
            foreach(var field in typeof(PushOptionType).GetFields())
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

                    if (enumVal is PushOptionType)
                    {
                        return (PushOptionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PushOptionType");
        }
    }
}