//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    public class SyncFailedWebhookData
    {

        /// <summary>
        /// Unique identifier for the failed sync.
        /// </summary>
        [JsonProperty("syncId")]
        public string? SyncId { get; set; }

        /// <summary>
        /// The type of sync being performed.
        /// </summary>
        [JsonProperty("syncType")]
        public string? SyncType { get; set; }

        /// <summary>
        /// The stage of the job the sync failed.
        /// </summary>
        [JsonProperty("FailureStage")]
        public string? FailureStage { get; set; }
    }
}