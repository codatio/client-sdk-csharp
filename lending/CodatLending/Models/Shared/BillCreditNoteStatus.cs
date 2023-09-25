
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
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is BillCreditNoteStatus)
                    {
                        return (BillCreditNoteStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BillCreditNoteStatus");
        }
    }
}