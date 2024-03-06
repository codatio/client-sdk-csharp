
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
    
    /// <summary>
    /// Webhook request body for a client that has reached their rate limit.
    /// </summary>
    public class ClientRateLimitReachedWebhook
    {

        /// <summary>
        /// Unique identifier of the webhook event.
        /// </summary>
        [JsonProperty("AlertId")]
        public string? AlertId { get; set; }

        /// <summary>
        /// Unique identifier for your client in Codat.
        /// </summary>
        [JsonProperty("ClientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Name of your client in Codat.
        /// </summary>
        [JsonProperty("ClientName")]
        public string? ClientName { get; set; }

        [JsonProperty("Data")]
        public ClientRateLimitReachedWebhookData? Data { get; set; }

        /// <summary>
        /// A human-readable message about the webhook.
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
        [JsonProperty("RuleType")]
        public string? RuleType { get; set; }
    }
}