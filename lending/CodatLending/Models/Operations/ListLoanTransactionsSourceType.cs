
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
    public enum ListLoanTransactionsSourceType
    {
        [JsonProperty("banking")]
        Banking,
        [JsonProperty("commerce")]
        Commerce,
        [JsonProperty("accounting")]
        Accounting,
    }

    public static class ListLoanTransactionsSourceTypeExtension
    {
        public static string Value(this ListLoanTransactionsSourceType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ListLoanTransactionsSourceType ToEnum(this string value)
        {
            foreach(var field in typeof(ListLoanTransactionsSourceType).GetFields())
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

                    if (enumVal is ListLoanTransactionsSourceType)
                    {
                        return (ListLoanTransactionsSourceType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ListLoanTransactionsSourceType");
        }
    }
}