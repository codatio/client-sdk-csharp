
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
    using Newtonsoft.Json;
    
    public class DatasetStatusChangedErrorWebhookData
    {

        /// <summary>
        /// Available data types
        /// </summary>
        [JsonProperty("dataType")]
        public Models.Shared.DataType? DataType { get; set; }

        /// <summary>
        /// Unique identifier for the dataset that completed its sync.
        /// </summary>
        [JsonProperty("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// The current status of the dataset&apos;s sync.
        /// </summary>
        [JsonProperty("datasetStatus")]
        public string? DatasetStatus { get; set; }
    }
}