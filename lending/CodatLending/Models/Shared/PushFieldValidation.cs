
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
    
    public class PushFieldValidation
    {

        [JsonProperty("details")]
        public string Details { get; set; } = default!;

        [JsonProperty("field")]
        public string? Field { get; set; }

        [JsonProperty("ref")]
        public string? Ref { get; set; }
    }
}