
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
    
    
    public enum ReportItemsLoanTransactionType
    {
    	[JsonProperty("Investment")]
		Investment,
		[JsonProperty("Repayment")]
		Repayment,
		[JsonProperty("Interest")]
		Interest,
		[JsonProperty("AccuredInterest")]
		AccuredInterest,
    }
    
    public static class ReportItemsLoanTransactionTypeExtension
    {
        public static string Value(this ReportItemsLoanTransactionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ReportItemsLoanTransactionType ToEnum(this string value)
        {
            foreach(var field in typeof(ReportItemsLoanTransactionType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ReportItemsLoanTransactionType)
                    {
                        return (ReportItemsLoanTransactionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ReportItemsLoanTransactionType");
        }
    }
    
}