//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Components
{
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class SyncSettings
    {

        /// <summary>
        /// Unique identifier for your client in Codat.
        /// </summary>
        [JsonProperty("clientId")]
        public string? ClientId { get; set; }

        [JsonProperty("settings")]
        public List<SyncSetting>? Settings { get; set; }

        /// <summary>
        /// Set to `True` if you want to override the default <a href="https://docs.codat.io/knowledge-base/advanced-sync-settings">sync settings</a>.
        /// </summary>
        [JsonProperty("overridesDefaults")]
        public bool? OverridesDefaults { get; set; }
    }
}