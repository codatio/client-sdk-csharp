//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Components
{
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    public class DataTypes
    {

        /// <summary>
        /// Unique identifier for a company&apos;s data connection.
        /// </summary>
        [JsonProperty("connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Available data types
        /// </summary>
        [JsonProperty("dataType")]
        public PropertieDataType? DataType { get; set; }

        /// <summary>
        /// `True` if records have been created, updated or deleted in Codat&apos;s cache.
        /// </summary>
        [JsonProperty("recordsModified")]
        public bool? RecordsModified { get; set; }

        /// <summary>
        /// The current status of the dataset.
        /// </summary>
        [JsonProperty("status")]
        public Status? Status { get; set; }
    }
}