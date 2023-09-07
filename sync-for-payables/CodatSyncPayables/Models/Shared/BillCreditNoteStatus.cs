
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    /// <summary>
    /// Current state of the bill credit note
    /// </summary>
    public enum BillCreditNoteStatus
    {
    	[JsonProperty("Unknown")]
		Unknown,
		[JsonProperty("Draft")]
		Draft,
		[JsonProperty("Submitted")]
		Submitted,
		[JsonProperty("Paid")]
		Paid,
		[JsonProperty("Void")]
		Void,
		[JsonProperty("PartiallyPaid")]
		PartiallyPaid,
    }
    
    public static class BillCreditNoteStatusExtension
    {
        public static string Value(this BillCreditNoteStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BillCreditNoteStatus ToEnum(this string value)
        {
            foreach(var field in typeof(BillCreditNoteStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (BillCreditNoteStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum BillCreditNoteStatus");
        }
    }
    
}