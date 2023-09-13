
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Reference to the item the line is linked to.
    /// </summary>
    public class BillCreditNoteLineItemItemReference
    {
        /// <summary>
        /// Unique identifier for the item in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
        
        /// <summary>
        /// Name of the item in the accounting platform.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
    }
    
}