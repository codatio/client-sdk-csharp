
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
    using System.Collections.Generic;
    
    
    public class AccountingBankAccounts
    {
        [JsonProperty("_links")]
        public Links Links { get; set; } = default!;
        
        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; } = default!;
        
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = default!;
        
        [JsonProperty("results")]
        public List<AccountingBankAccount>? Results { get; set; }
        
        [JsonProperty("totalResults")]
        public long TotalResults { get; set; } = default!;
        
    }
    
}