
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
    /// OK
    /// </summary>
    public class CommercePayments
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }
        
        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; }
        
        [JsonProperty("pageSize")]
        public long PageSize { get; set; }
        
        [JsonProperty("results")]
        public List<CommercePayment>? Results { get; set; }
        
        [JsonProperty("totalResults")]
        public long TotalResults { get; set; }
        
    }
    
}