
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
    /// The integration type begin referred to.
    /// </summary>
    public enum LoanSummaryIntegrationType
    {
    	[JsonProperty("Accounting")]
		Accounting,
		[JsonProperty("Banking")]
		Banking,
		[JsonProperty("Commerce")]
		Commerce,
    }
    
    public static class LoanSummaryIntegrationTypeExtension
    {
        public static string Value(this LoanSummaryIntegrationType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LoanSummaryIntegrationType ToEnum(this string value)
        {
            foreach(var field in typeof(LoanSummaryIntegrationType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is LoanSummaryIntegrationType)
                    {
                        return (LoanSummaryIntegrationType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LoanSummaryIntegrationType");
        }
    }
    
}