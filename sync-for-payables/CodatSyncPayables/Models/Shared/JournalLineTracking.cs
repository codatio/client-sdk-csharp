
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
    using System.Collections.Generic;
    
    /// <summary>
    /// List of record refs associated with the tracking information for the line (eg to a Tracking Category, or customer etc.)
    /// </summary>
    public class JournalLineTracking
    {

        [JsonProperty("recordRefs")]
        public List<RecordRef>? RecordRefs { get; set; }
    }
}