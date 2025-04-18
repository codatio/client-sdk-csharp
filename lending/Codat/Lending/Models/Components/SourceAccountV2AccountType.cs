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
    /// The type of bank account e.g. checking, savings, loan, creditCard, prepaidCard.
    /// </summary>
    public enum SourceAccountV2AccountType
    {
        [JsonProperty("checking")]
        Checking,
        [JsonProperty("savings")]
        Savings,
        [JsonProperty("loan")]
        Loan,
        [JsonProperty("creditCard")]
        CreditCard,
        [JsonProperty("prepaidCard")]
        PrepaidCard,
    }

    public static class SourceAccountV2AccountTypeExtension
    {
        public static string Value(this SourceAccountV2AccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SourceAccountV2AccountType ToEnum(this string value)
        {
            foreach(var field in typeof(SourceAccountV2AccountType).GetFields())
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

                    if (enumVal is SourceAccountV2AccountType)
                    {
                        return (SourceAccountV2AccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SourceAccountV2AccountType");
        }
    }

}