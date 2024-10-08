//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Models.Components
{
    using Codat.Sync.Payroll.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The current status of the dataset.
    /// </summary>
    public enum Status
    {
        [JsonProperty("Initial")]
        Initial,
        [JsonProperty("Queued")]
        Queued,
        [JsonProperty("Fetching")]
        Fetching,
        [JsonProperty("MapQueued")]
        MapQueued,
        [JsonProperty("Mapping")]
        Mapping,
        [JsonProperty("Complete")]
        Complete,
        [JsonProperty("FetchError")]
        FetchError,
        [JsonProperty("MapError")]
        MapError,
        [JsonProperty("InternalError")]
        InternalError,
        [JsonProperty("ProcessingQueued")]
        ProcessingQueued,
        [JsonProperty("Processing")]
        Processing,
        [JsonProperty("ProcessingError")]
        ProcessingError,
        [JsonProperty("ValidationQueued")]
        ValidationQueued,
        [JsonProperty("Validating")]
        Validating,
        [JsonProperty("ValidationError")]
        ValidationError,
        [JsonProperty("AuthError")]
        AuthError,
        [JsonProperty("Cancelled")]
        Cancelled,
        [JsonProperty("NotSupported")]
        NotSupported,
        [JsonProperty("RateLimitError")]
        RateLimitError,
        [JsonProperty("PermissionsError")]
        PermissionsError,
        [JsonProperty("PrerequisiteNotMet")]
        PrerequisiteNotMet,
    }

    public static class StatusExtension
    {
        public static string Value(this Status value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Status ToEnum(this string value)
        {
            foreach(var field in typeof(Status).GetFields())
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

                    if (enumVal is Status)
                    {
                        return (Status)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Status");
        }
    }

}