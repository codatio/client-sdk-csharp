//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of the platform transaction:  <br/>
    /// 
    /// <remarks>
    /// - `Unknown`  <br/>
    /// - `FailedPayout` — Failed transfer of funds from the seller&apos;s merchant account to their bank account.  <br/>
    /// - `Payment` — Credit and debit card payments.  <br/>
    /// - `PaymentFee` — Payment provider&apos;s fee on each card payment.  <br/>
    /// - `PaymentFeeRefund` — Payment provider&apos;s fee that has been refunded to the seller.  <br/>
    /// - `Payout` — Transfer of funds from the seller&apos;s merchant account to their bank account.  <br/>
    /// - `Refund` — Refunds to a customer&apos;s credit or debit card.  <br/>
    /// - `Transfer` — Secure transfer of funds to the seller&apos;s bank account.  
    /// </remarks>
    /// </summary>
    public enum TransactionType
    {
        [JsonProperty("Payment")]
        Payment,
        [JsonProperty("Refund")]
        Refund,
        [JsonProperty("Payout")]
        Payout,
        [JsonProperty("FailedPayout")]
        FailedPayout,
        [JsonProperty("Transfer")]
        Transfer,
        [JsonProperty("PaymentFee")]
        PaymentFee,
        [JsonProperty("PaymentFeeRefund")]
        PaymentFeeRefund,
        [JsonProperty("Unknown")]
        Unknown,
    }

    public static class TransactionTypeExtension
    {
        public static string Value(this TransactionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TransactionType ToEnum(this string value)
        {
            foreach(var field in typeof(TransactionType).GetFields())
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

                    if (enumVal is TransactionType)
                    {
                        return (TransactionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TransactionType");
        }
    }

}