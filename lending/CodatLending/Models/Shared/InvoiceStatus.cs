
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
    /// Current state of the invoice:<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// - `Draft` - Invoice hasn&apos;t been submitted to the supplier. It may be in a pending state or is scheduled for future submission, for example by email.<br/>
    /// - `Submitted` - Invoice is no longer a draft. It has been processed and, or, sent to the customer. In this state, it will impact the ledger. It also has no payments made against it (amountDue == totalAmount).<br/>
    /// - `PartiallyPaid` - The balance paid against the invoice is positive, but less than the total invoice amount (0 &lt; amountDue &lt; totalAmount).<br/>
    /// - `Paid` - Invoice is paid in full. This includes if the invoice has been credited or overpaid (amountDue == 0).<br/>
    /// - `Void` - An invoice can become Void when it&apos;s deleted, refunded, written off, or cancelled. A voided invoice may still be PartiallyPaid, and so all outstanding amounts on voided invoices are removed from the accounts receivable account.
    /// </remarks>
    /// </summary>
    public enum InvoiceStatus
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Draft")]
        Draft,
        [JsonProperty("Submitted")]
        Submitted,
        [JsonProperty("PartiallyPaid")]
        PartiallyPaid,
        [JsonProperty("Paid")]
        Paid,
        [JsonProperty("Void")]
        Void,
    }

    public static class InvoiceStatusExtension
    {
        public static string Value(this InvoiceStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static InvoiceStatus ToEnum(this string value)
        {
            foreach(var field in typeof(InvoiceStatus).GetFields())
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

                    if (enumVal is InvoiceStatus)
                    {
                        return (InvoiceStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum InvoiceStatus");
        }
    }
}