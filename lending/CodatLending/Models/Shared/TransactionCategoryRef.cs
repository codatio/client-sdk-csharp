
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
    
    
    /// <summary>
    /// An object of bank transaction category reference data.
    /// </summary>
    public class TransactionCategoryRef
    {
        /// <summary>
        /// The unique category reference id for the bank transaction.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
        
        /// <summary>
        /// The category name reference for the bank transaction.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
    }
    
}