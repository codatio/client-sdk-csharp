
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Allowed name of the &apos;dataType&apos;.
    /// </summary>
    public enum AccountingCreateDirectCostResponseDataType
    {
        [JsonProperty("customers")]
        Customers,
        [JsonProperty("suppliers")]
        Suppliers,
    }

    public static class AccountingCreateDirectCostResponseDataTypeExtension
    {
        public static string Value(this AccountingCreateDirectCostResponseDataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountingCreateDirectCostResponseDataType ToEnum(this string value)
        {
            foreach(var field in typeof(AccountingCreateDirectCostResponseDataType).GetFields())
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

                    if (enumVal is AccountingCreateDirectCostResponseDataType)
                    {
                        return (AccountingCreateDirectCostResponseDataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountingCreateDirectCostResponseDataType");
        }
    }

}