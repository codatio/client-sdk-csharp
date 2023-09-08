
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
    
    
    public class TransactionCategory
    {
        /// <summary>
        /// Returns the confidence of the suggested category for the transaction. The value is between 0 and 100.
        /// </summary>
        [JsonProperty("confidence")]
        public decimal? Confidence { get; set; }
        
        /// <summary>
        /// The suggested category is an ordered array of category levels where each element (or level) is a subcategory of the previous element (or level).
        /// </summary>
        [JsonProperty("levels")]
        public List<string>? Levels { get; set; }
        
    }
    
}