
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
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Allowed name of the &apos;dataType&apos;.
    /// </summary>
    public enum BillLineItemDataType
    {
        [JsonProperty("purchaseOrders")]
        PurchaseOrders,
    }

    public static class BillLineItemDataTypeExtension
    {
        public static string Value(this BillLineItemDataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BillLineItemDataType ToEnum(this string value)
        {
            foreach(var field in typeof(BillLineItemDataType).GetFields())
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

                    if (enumVal is BillLineItemDataType)
                    {
                        return (BillLineItemDataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BillLineItemDataType");
        }
    }

}