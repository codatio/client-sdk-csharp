
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Current status of the dispute
    /// </summary>
    public enum DisputeStatus
    {
        [JsonProperty("Won")]
        Won,
        [JsonProperty("Lost")]
        Lost,
        [JsonProperty("Accepted")]
        Accepted,
        [JsonProperty("Processing")]
        Processing,
        [JsonProperty("ChargeRefunded")]
        ChargeRefunded,
        [JsonProperty("EvidenceRequired")]
        EvidenceRequired,
        [JsonProperty("InquiryEvidenceRequired")]
        InquiryEvidenceRequired,
        [JsonProperty("InquiryProcessing")]
        InquiryProcessing,
        [JsonProperty("InquiryClosed")]
        InquiryClosed,
        [JsonProperty("WaitingThirdParty")]
        WaitingThirdParty,
        [JsonProperty("Unknown")]
        Unknown,
    }

    public static class DisputeStatusExtension
    {
        public static string Value(this DisputeStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DisputeStatus ToEnum(this string value)
        {
            foreach(var field in typeof(DisputeStatus).GetFields())
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

                    if (enumVal is DisputeStatus)
                    {
                        return (DisputeStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DisputeStatus");
        }
    }
}