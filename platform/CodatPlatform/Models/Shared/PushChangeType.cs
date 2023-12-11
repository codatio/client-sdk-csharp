
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Type of change being applied to record in third party platform.
    /// </summary>
    public enum PushChangeType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Created")]
        Created,
        [JsonProperty("Modified")]
        Modified,
        [JsonProperty("Deleted")]
        Deleted,
        [JsonProperty("AttachmentUploaded")]
        AttachmentUploaded,
    }

    public static class PushChangeTypeExtension
    {
        public static string Value(this PushChangeType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PushChangeType ToEnum(this string value)
        {
            foreach(var field in typeof(PushChangeType).GetFields())
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

                    if (enumVal is PushChangeType)
                    {
                        return (PushChangeType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PushChangeType");
        }
    }
}