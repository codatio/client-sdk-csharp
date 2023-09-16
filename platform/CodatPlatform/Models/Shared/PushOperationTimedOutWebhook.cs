
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Webhook request body notifying that a push push operation has timed out.
    /// </summary>
    public class PushOperationTimedOutWebhook
    {

        /// <summary>
        /// Unique identifier of the webhook event.
        /// </summary>
        [JsonProperty("AlertId")]
        public string? AlertId { get; set; }

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("CompanyId")]
        public string? CompanyId { get; set; }

        [JsonProperty("Data")]
        public PushOperationTimedOutWebhookData? Data { get; set; }

        /// <summary>
        /// A human readable message about the webhook.
        /// </summary>
        [JsonProperty("Message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique identifier for the rule.
        /// </summary>
        [JsonProperty("RuleId")]
        public string? RuleId { get; set; }

        /// <summary>
        /// The type of rule.
        /// </summary>
        [JsonProperty("Type")]
        public string? Type { get; set; }
    }
}