
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
    /// The type of feature.
    /// </summary>
    public enum FeatureType
    {
        [JsonProperty("Get")]
        Get,
        [JsonProperty("Post")]
        Post,
        [JsonProperty("Categorization")]
        Categorization,
        [JsonProperty("Delete")]
        Delete,
        [JsonProperty("Put")]
        Put,
        [JsonProperty("GetAsPdf")]
        GetAsPdf,
        [JsonProperty("DownloadAttachment")]
        DownloadAttachment,
        [JsonProperty("GetAttachment")]
        GetAttachment,
        [JsonProperty("GetAttachments")]
        GetAttachments,
        [JsonProperty("UploadAttachment")]
        UploadAttachment,
    }

    public static class FeatureTypeExtension
    {
        public static string Value(this FeatureType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static FeatureType ToEnum(this string value)
        {
            foreach(var field in typeof(FeatureType).GetFields())
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

                    if (enumVal is FeatureType)
                    {
                        return (FeatureType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum FeatureType");
        }
    }
}