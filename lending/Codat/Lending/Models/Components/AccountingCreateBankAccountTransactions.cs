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
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    [Obsolete("This will be removed in a future release, please migrate away from it as soon as possible.")]
    public class AccountingCreateBankAccountTransactions
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