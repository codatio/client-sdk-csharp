
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    
    public class ReportComponentMeasure
    {

        /// <summary>
        /// The measure&apos;s index.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }

        /// <summary>
        /// The measure&apos;s display name.
        /// </summary>
        [JsonProperty("measureDisplayName")]
        public string? MeasureDisplayName { get; set; }

        /// <summary>
        /// The measure&apos;s value.
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value { get; set; }
    }
}