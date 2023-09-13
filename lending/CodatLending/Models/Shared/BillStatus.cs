
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
    
    
    /// <summary>
    /// Current state of the bill.
    /// </summary>
    public enum BillStatus
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Open")]
		Open,
		[JsonProperty("PartiallyPaid")]
		PartiallyPaid,
		[JsonProperty("Paid")]
		Paid,
		[JsonProperty("Void")]
		Void,
		[JsonProperty("Draft")]
		Draft,
    }
    
    public static class BillStatusExtension
    {
        public static string Value(this BillStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BillStatus ToEnum(this string value)
        {
            foreach(var field in typeof(BillStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (BillStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum BillStatus");
        }
    }
    
}