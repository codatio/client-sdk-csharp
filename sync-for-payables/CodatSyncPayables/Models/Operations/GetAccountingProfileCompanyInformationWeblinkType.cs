
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Operations
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of the weblink.
    /// </summary>
    public enum GetAccountingProfileCompanyInformationWeblinkType
    {
        [JsonProperty("Website")]
        Website,
        [JsonProperty("Social")]
        Social,
        [JsonProperty("Unknown")]
        Unknown,
    }

    public static class GetAccountingProfileCompanyInformationWeblinkTypeExtension
    {
        public static string Value(this GetAccountingProfileCompanyInformationWeblinkType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetAccountingProfileCompanyInformationWeblinkType ToEnum(this string value)
        {
            foreach(var field in typeof(GetAccountingProfileCompanyInformationWeblinkType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is GetAccountingProfileCompanyInformationWeblinkType)
                    {
                        return (GetAccountingProfileCompanyInformationWeblinkType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetAccountingProfileCompanyInformationWeblinkType");
        }
    }
}