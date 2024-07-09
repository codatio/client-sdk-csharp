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
    
    public class PushOperationStatusChangedWebhookData
    {

        /// <summary>
        /// Available data types
        /// </summary>
        [JsonProperty("dataType")]
        public Models.Shared.DataType? DataType { get; set; }

        /// <summary>
        /// A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted.
        /// </summary>
        [JsonProperty("pushOperationKey")]
        public string? PushOperationKey { get; set; }

        /// <summary>
        /// The current status of the push operation.
        /// </summary>
        [JsonProperty("status")]
        public PushOperationStatus? Status { get; set; }
    }
}