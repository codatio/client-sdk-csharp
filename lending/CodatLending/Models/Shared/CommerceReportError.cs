
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
    
    public class CommerceReportError
    {

        [JsonProperty("details")]
        public Dictionary<string, List<string>>? Details { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}