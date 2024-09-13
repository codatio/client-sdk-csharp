//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of contact.
    /// </summary>
    public enum ExpenseContactRefType
    {
        [JsonProperty("Supplier")]
        Supplier,
    }

    public static class ExpenseContactRefTypeExtension
    {
        public static string Value(this ExpenseContactRefType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ExpenseContactRefType ToEnum(this string value)
        {
            foreach(var field in typeof(ExpenseContactRefType).GetFields())
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

                    if (enumVal is ExpenseContactRefType)
                    {
                        return (ExpenseContactRefType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ExpenseContactRefType");
        }
    }

}