//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Shared
{
    using Codat.Platform.Models.Shared;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    public class PushOptionChoice
    {

        /// <summary>
        /// A description of the property.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The property&apos;s display name.
        /// </summary>
        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The property is required if `True`.
        /// </summary>
        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// The option type.
        /// </summary>
        [JsonProperty("type")]
        public PushOptionType? Type { get; set; }

        /// <summary>
        /// Allowed value for field.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}