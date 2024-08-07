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
    
    public class PushOperationChange
    {

        /// <summary>
        /// Unique identifier for the attachment created otherwise null.
        /// </summary>
        [JsonProperty("attachmentId")]
        public string? AttachmentId { get; set; } = null;

        [JsonProperty("recordRef")]
        public PushOperationRef? RecordRef { get; set; }

        /// <summary>
        /// Type of change being applied to record in third party platform.
        /// </summary>
        [JsonProperty("type")]
        public PushChangeType? Type { get; set; }
    }
}