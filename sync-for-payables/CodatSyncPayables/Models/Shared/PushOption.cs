
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
    /// OK
    /// </summary>
    public class PushOption
    {
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty("options")]
        public List<PushOptionChoice>? Options { get; set; }
        
        [JsonProperty("properties")]
        public Dictionary<string, PushOptionProperty>? Properties { get; set; }
        
        [JsonProperty("required")]
        public bool Required { get; set; }
        
        [JsonProperty("type")]
        public PushOptionType Type { get; set; }
        
        [JsonProperty("validation")]
        public PushValidationInfo? Validation { get; set; }
        
    }
    
}