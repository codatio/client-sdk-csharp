
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Links journal entries to the relevant journal in accounting integrations that use multi-book accounting (multiple journals).
    /// </summary>
    public class JournalRef
    {
        /// <summary>
        /// GUID of the underlying journal.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Name of journal
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
    }
    
}