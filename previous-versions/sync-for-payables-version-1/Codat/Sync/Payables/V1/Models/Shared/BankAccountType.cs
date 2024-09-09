//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of transactions and balances on the account.  <br/>
    /// 
    /// <remarks>
    /// For Credit accounts, positive balances are liabilities, and positive transactions **reduce** liabilities.  <br/>
    /// For Debit accounts, positive balances are assets, and positive transactions **increase** assets.
    /// </remarks>
    /// </summary>
    public enum BankAccountType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Credit")]
        Credit,
        [JsonProperty("Debit")]
        Debit,
    }

    public static class BankAccountTypeExtension
    {
        public static string Value(this BankAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BankAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(BankAccountType).GetFields())
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

                    if (enumVal is BankAccountType)
                    {
                        return (BankAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BankAccountType");
        }
    }

}