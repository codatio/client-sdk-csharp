
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Operations
{
    using CodatBankFeeds.Models.Shared;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    
    public class CreateBankTransactionsCreateBankAccountTransactions
    {
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }
        
        [JsonProperty("transactions")]
        public List<Onecompanies1Percent7BcompanyIdPercent7D1connections1Percent7BconnectionIdPercent7D1push1bankAccounts1Percent7BaccountIdPercent7D1bankTransactionsPostRequestBodyContentApplication1jsonSchemaDefinitionsCreateBankAccountTransaction>? Transactions { get; set; }
        
    }
    
}