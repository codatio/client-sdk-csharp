
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    
    public class SyncSettings
    {
        [JsonProperty("clientId")]
        public string? ClientId { get; set; }
        
        [JsonProperty("overridesDefaults")]
        public bool? OverridesDefaults { get; set; }
        
        [JsonProperty("settings")]
        public List<SyncSetting>? Settings { get; set; }
        
    }
    
}