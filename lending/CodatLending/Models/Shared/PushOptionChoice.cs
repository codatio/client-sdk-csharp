
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
    
    public class PushOptionChoice
    {

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("type")]
        public PushOptionType? Type { get; set; }

        /// <summary>
        /// Allowed value for field.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}