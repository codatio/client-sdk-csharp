
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
    /// Accounting method used when aggregating the report data. In this case, `Cash`.
    /// </summary>
    public enum ReportBasis
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Accrual")]
		Accrual,
		[JsonProperty("Cash")]
		Cash,
    }
    
    public static class ReportBasisExtension
    {
        public static string Value(this ReportBasis value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ReportBasis ToEnum(this string value)
        {
            foreach(var field in typeof(ReportBasis).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ReportBasis)
                    {
                        return (ReportBasis)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ReportBasis");
        }
    }
    
}