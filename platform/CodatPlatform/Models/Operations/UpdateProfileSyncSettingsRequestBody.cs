
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Operations
{
    using CodatPlatform.Models.Shared;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    
    /// <summary>
    /// Include a `syncSetting` object for each data type.
    /// 
    /// <remarks>
    /// `syncFromWindow`, `syncFromUTC` & `monthsToSync` only need to be included if you wish to set a value for them.
    /// </remarks>
    /// </summary>
    public class UpdateProfileSyncSettingsRequestBody
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        
        [JsonProperty("overridesDefaults")]
        public bool OverridesDefaults { get; set; }
        
        [JsonProperty("settings")]
        public List<SyncSetting> Settings { get; set; }
        
    }
    
}