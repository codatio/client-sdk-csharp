//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Requests
{
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Include a `syncSetting` object for each data type.<br/>
    /// 
    /// <remarks>
    /// `syncFromWindow`, `syncFromUTC` &amp; `monthsToSync` only need to be included if you wish to set a value for them.
    /// </remarks>
    /// </summary>
    public class UpdateProfileSyncSettingsRequestBody
    {

        /// <summary>
        /// Unique identifier for your client in Codat.
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; } = default!;

        [JsonProperty("settings")]
        public List<SyncSetting> Settings { get; set; } = default!;

        /// <summary>
        /// Set to `True` if you want to override default <a href="https://docs.codat.io/knowledge-base/advanced-sync-settings">sync settings</a>.
        /// </summary>
        [JsonProperty("overridesDefaults")]
        public bool? OverridesDefaults { get; set; } = true;
    }
}