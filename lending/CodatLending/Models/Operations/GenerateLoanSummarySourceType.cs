
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Operations
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Data source type.
    /// </summary>
    public enum GenerateLoanSummarySourceType
    {
        [JsonProperty("banking")]
        Banking,
        [JsonProperty("commerce")]
        Commerce,
        [JsonProperty("accounting")]
        Accounting,
    }

    public static class GenerateLoanSummarySourceTypeExtension
    {
        public static string Value(this GenerateLoanSummarySourceType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GenerateLoanSummarySourceType ToEnum(this string value)
        {
            foreach(var field in typeof(GenerateLoanSummarySourceType).GetFields())
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

                    if (enumVal is GenerateLoanSummarySourceType)
                    {
                        return (GenerateLoanSummarySourceType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GenerateLoanSummarySourceType");
        }
    }
}