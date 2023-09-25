
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class PushOptionProperty
    {

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = default!;

        [JsonProperty("options")]
        public List<PushOptionChoice>? Options { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, PushOptionProperty>? Properties { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; } = default!;

        [JsonProperty("type")]
        public PushOptionType Type { get; set; } = default!;

        [JsonProperty("validation")]
        public PushValidationInfo? Validation { get; set; }
    }
}