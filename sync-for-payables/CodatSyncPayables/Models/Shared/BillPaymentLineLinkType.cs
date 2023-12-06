
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Types of links to bill payment lines.
    /// </summary>
    public enum BillPaymentLineLinkType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Unlinked")]
        Unlinked,
        [JsonProperty("Bill")]
        Bill,
        [JsonProperty("Other")]
        Other,
        [JsonProperty("CreditNote")]
        CreditNote,
        [JsonProperty("BillPayment")]
        BillPayment,
        [JsonProperty("PaymentOnAccount")]
        PaymentOnAccount,
        [JsonProperty("Refund")]
        Refund,
        [JsonProperty("ManualJournal")]
        ManualJournal,
        [JsonProperty("Discount")]
        Discount,
    }

    public static class BillPaymentLineLinkTypeExtension
    {
        public static string Value(this BillPaymentLineLinkType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BillPaymentLineLinkType ToEnum(this string value)
        {
            foreach(var field in typeof(BillPaymentLineLinkType).GetFields())
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

                    if (enumVal is BillPaymentLineLinkType)
                    {
                        return (BillPaymentLineLinkType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BillPaymentLineLinkType");
        }
    }
}