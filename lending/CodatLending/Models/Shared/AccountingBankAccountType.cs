
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
    /// The type of transactions and balances on the account.  <br/>
    /// 
    /// <remarks>
    /// For Credit accounts, positive balances are liabilities, and positive transactions **reduce** liabilities.  <br/>
    /// For Debit accounts, positive balances are assets, and positive transactions **increase** assets.
    /// </remarks>
    /// </summary>
    public enum AccountingBankAccountType
    {
        [JsonProperty("Unknown")]
        Unknown,
        [JsonProperty("Credit")]
        Credit,
        [JsonProperty("Debit")]
        Debit,
    }

    public static class AccountingBankAccountTypeExtension
    {
        public static string Value(this AccountingBankAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountingBankAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(AccountingBankAccountType).GetFields())
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

                    if (enumVal is AccountingBankAccountType)
                    {
                        return (AccountingBankAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountingBankAccountType");
        }
    }
}