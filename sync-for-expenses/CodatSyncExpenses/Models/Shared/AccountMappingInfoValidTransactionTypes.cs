
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    public enum AccountMappingInfoValidTransactionTypes
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

    public static class AccountMappingInfoValidTransactionTypesExtension
    {
        public static string Value(this AccountMappingInfoValidTransactionTypes value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountMappingInfoValidTransactionTypes ToEnum(this string value)
        {
            foreach(var field in typeof(AccountMappingInfoValidTransactionTypes).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is AccountMappingInfoValidTransactionTypes)
                    {
                        return (AccountMappingInfoValidTransactionTypes)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountMappingInfoValidTransactionTypes");
        }
    }
}