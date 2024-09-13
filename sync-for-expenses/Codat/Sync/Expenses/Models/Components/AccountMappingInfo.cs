//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class AccountMappingInfo
    {

        /// <summary>
        /// Unique identifier of account.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Code used to identify each nominal account in the accounting software.
        /// </summary>
        [JsonProperty("nominalCode")]
        public string? NominalCode { get; set; } = null;

        /// <summary>
        /// Name of the account as it appears in the company&apos;s accounting software.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Currency of the account.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Type of the account.
        /// </summary>
        [JsonProperty("accountType")]
        public AccountMappingInfoAccountType? AccountType { get; set; }

        /// <summary>
        /// Full account type and category of the account
        /// </summary>
        [JsonProperty("fullyQualifiedCategory")]
        public string? FullyQualifiedCategory { get; set; }

        /// <summary>
        /// Confirms whether the account is a bank account or not.
        /// </summary>
        [JsonProperty("isBankAccount")]
        public bool? IsBankAccount { get; set; }

        /// <summary>
        /// Supported transaction types for the account.
        /// </summary>
        [JsonProperty("validTransactionTypes")]
        public List<ValidTransactionTypes>? ValidTransactionTypes { get; set; }
    }
}