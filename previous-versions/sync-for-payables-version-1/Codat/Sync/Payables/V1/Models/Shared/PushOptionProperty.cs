//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class PushOptionProperty
    {

        /// <summary>
        /// A description of the property.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The property&apos;s display name.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = default!;

        [JsonProperty("options")]
        public List<PushOptionChoice>? Options { get; set; } = null;

        [JsonProperty("properties")]
        public Dictionary<string, PushOptionProperty>? Properties { get; set; } = null;

        /// <summary>
        /// The property is required if `True`.
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; } = default!;

        /// <summary>
        /// The option type.
        /// </summary>
        [JsonProperty("type")]
        public PushOptionType Type { get; set; } = default!;

        [JsonProperty("validation")]
        public PushValidationInfo? Validation { get; set; }
    }
}