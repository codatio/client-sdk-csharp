
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System;
    
    public enum TaxRateMappingInfoValidTransactionTypes
    {
        [JsonProperty("Payment")]
        Payment,
        [JsonProperty("Refund")]
        Refund,
        [JsonProperty("Reward")]
        Reward,
        [JsonProperty("Chargeback")]
        Chargeback,
        [JsonProperty("TransferIn")]
        TransferIn,
        [JsonProperty("TransferOut")]
        TransferOut,
        [JsonProperty("AdjustmentIn")]
        AdjustmentIn,
        [JsonProperty("AdjustmentOut")]
        AdjustmentOut,
    }

    public static class TaxRateMappingInfoValidTransactionTypesExtension
    {
        public static string Value(this TaxRateMappingInfoValidTransactionTypes value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TaxRateMappingInfoValidTransactionTypes ToEnum(this string value)
        {
            foreach(var field in typeof(TaxRateMappingInfoValidTransactionTypes).GetFields())
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

                    if (enumVal is TaxRateMappingInfoValidTransactionTypes)
                    {
                        return (TaxRateMappingInfoValidTransactionTypes)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TaxRateMappingInfoValidTransactionTypes");
        }
    }

}