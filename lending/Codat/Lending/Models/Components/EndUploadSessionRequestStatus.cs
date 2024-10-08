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
    /// An indicator to cancel the dataset processing or trigger ingestion and enrichment of data.
    /// </summary>
    public enum EndUploadSessionRequestStatus
    {
        [JsonProperty("Cancel")]
        Cancel,
        [JsonProperty("Process")]
        Process,
    }

    public static class EndUploadSessionRequestStatusExtension
    {
        public static string Value(this EndUploadSessionRequestStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EndUploadSessionRequestStatus ToEnum(this string value)
        {
            foreach(var field in typeof(EndUploadSessionRequestStatus).GetFields())
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

                    if (enumVal is EndUploadSessionRequestStatus)
                    {
                        return (EndUploadSessionRequestStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EndUploadSessionRequestStatus");
        }
    }

}