
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
    using System.Collections.Generic;
    
    
    public class AccountMappingInfo
    {
        /// <summary>
        /// Type of the account.
        /// </summary>
        [JsonProperty("accountType")]
        public AccountMappingInfoAccountType? AccountType { get; set; }
        
        /// <summary>
        /// Currency of the account.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }
        
        /// <summary>
        /// Unique identifier of account.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Name of the account as it appears in the companies accounting software.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// Supported transaction types for the account.
        /// </summary>
        [JsonProperty("validTransactionTypes")]
        public List<AccountMappingInfoValidTransactionTypes>? ValidTransactionTypes { get; set; }
        
    }
    
}