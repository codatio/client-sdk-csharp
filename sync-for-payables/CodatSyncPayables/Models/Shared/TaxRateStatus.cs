
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Status of the tax rate in the accounting platform.  <br/>
    /// 
    /// <remarks>
    /// - `Active` - An active tax rate in use by a company.  <br/>
    /// - `Archived` - A tax rate that has been archived or is inactive in the accounting platform.  <br/>
    /// - `Unknown` - Where the status of the tax rate cannot be determined from the underlying platform.
    /// </remarks>
    /// </summary>
    public enum TaxRateStatus
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Active")]
        Active,
        [JsonProperty("Archived")]
        Archived,
    }

    public static class TaxRateStatusExtension
    {
        public static string Value(this TaxRateStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TaxRateStatus ToEnum(this string value)
        {
            foreach(var field in typeof(TaxRateStatus).GetFields())
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

                    if (enumVal is TaxRateStatus)
                    {
                        return (TaxRateStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TaxRateStatus");
        }
    }
}