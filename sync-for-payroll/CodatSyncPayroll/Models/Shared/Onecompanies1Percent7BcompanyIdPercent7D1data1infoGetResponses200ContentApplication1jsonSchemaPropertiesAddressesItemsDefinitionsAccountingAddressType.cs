
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of the address
    /// </summary>
    public enum Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Billing")]
        Billing,
        [JsonProperty("Delivery")]
        Delivery,
    }

    public static class Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressTypeExtension
    {
        public static string Value(this Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType ToEnum(this string value)
        {
            foreach(var field in typeof(Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType)
                    {
                        return (Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Onecompanies1Percent7BcompanyIdPercent7D1data1infoGetResponses200ContentApplication1jsonSchemaPropertiesAddressesItemsDefinitionsAccountingAddressType");
        }
    }
}