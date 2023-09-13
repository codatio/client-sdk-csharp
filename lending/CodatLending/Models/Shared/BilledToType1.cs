
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    public enum BilledToType1
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("NotApplicable")]
		NotApplicable,
		[JsonProperty("Project")]
		Project,
    }
    
    public static class BilledToType1Extension
    {
        public static string Value(this BilledToType1 value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BilledToType1 ToEnum(this string value)
        {
            foreach(var field in typeof(BilledToType1).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is BilledToType1)
                    {
                        return (BilledToType1)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BilledToType1");
        }
    }
    
}