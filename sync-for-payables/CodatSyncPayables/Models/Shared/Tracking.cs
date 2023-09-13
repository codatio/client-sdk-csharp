
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
    /// Categories, and a project and customer, against which the item is tracked.
    /// </summary>
    public class Tracking
    {
        [JsonProperty("categoryRefs")]
        public List<TrackingCategoryRef> CategoryRefs { get; set; } = default!;
        
        [JsonProperty("customerRef")]
        public TrackingCustomerRef? CustomerRef { get; set; }
        
        [JsonProperty("isBilledTo")]
        public BilledToType IsBilledTo { get; set; } = default!;
        
        [JsonProperty("isRebilledTo")]
        public BilledToType IsRebilledTo { get; set; } = default!;
        
        [JsonProperty("projectRef")]
        public TrackingProjectReference? ProjectRef { get; set; }
        
    }
    
}