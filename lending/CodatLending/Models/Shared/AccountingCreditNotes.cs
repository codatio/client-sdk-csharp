
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
    
    
    /// <summary>
    /// Success
    /// </summary>
    public class AccountingCreditNotes
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }
        
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
        [JsonProperty("results")]
        public List<AccountingCreditNote>? Results { get; set; }
        
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
        
    }
    
}