
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
    /// Create an event notification to a URL or list of email addresses based on the given type or condition.
    /// </summary>
    public class Webhook
    {

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("companyId")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Unique identifier for the configured notification.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("notifiers")]
        public WebhookNotifier Notifiers { get; set; } = default!;

        /// <summary>
        /// The type of webhook.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = default!;
    }
}