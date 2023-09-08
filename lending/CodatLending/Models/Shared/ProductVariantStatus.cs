
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
    
    
    public enum ProductVariantStatus
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Published")]
		Published,
		[JsonProperty("Unpublished")]
		Unpublished,
    }
    
    public static class ProductVariantStatusExtension
    {
        public static string Value(this ProductVariantStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ProductVariantStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ProductVariantStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ProductVariantStatus)
                    {
                        return (ProductVariantStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ProductVariantStatus");
        }
    }
    
}