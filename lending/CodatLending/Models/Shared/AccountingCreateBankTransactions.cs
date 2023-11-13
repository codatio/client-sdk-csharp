
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
    using System.Collections.Generic;
    
    public class AccountingCreateBankTransactions
    {

        /// <summary>
        /// Unique identifier for a bank account.
        /// </summary>
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }

        [JsonProperty("transactions")]
        public List<CreateBankAccountTransaction>? Transactions { get; set; }
    }
}