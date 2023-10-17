
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
    
    public class CommerceReportDimension
    {

        /// <summary>
        /// The dimension&apos;s display name.
        /// </summary>
        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The dimension&apos;s index.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }

        [JsonProperty("items")]
        public List<CommerceReportDimensionItems>? Items { get; set; }

        /// <summary>
        /// The dimension&apos;s type.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}