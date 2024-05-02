
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Type of transaction that has been processed e.g. Expense or Bank Feed.
    /// </summary>
    public enum IntegrationType
    {
        [JsonProperty("expenses")]
        Expenses,
        [JsonProperty("bankfeeds")]
        Bankfeeds,
    }

    public static class IntegrationTypeExtension
    {
        public static string Value(this IntegrationType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static IntegrationType ToEnum(this string value)
        {
            foreach(var field in typeof(IntegrationType).GetFields())
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

                    if (enumVal is IntegrationType)
                    {
                        return (IntegrationType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum IntegrationType");
        }
    }

}