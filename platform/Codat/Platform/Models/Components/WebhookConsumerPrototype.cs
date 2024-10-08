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
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class WebhookConsumerPrototype
    {

        /// <summary>
        /// The URL that will consume webhook events dispatched by Codat.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Flag that enables or disables the endpoint from receiving events. Disabled when set to `true`.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; } = false;

        /// <summary>
        /// An array of event types the webhook consumer subscribes to.
        /// </summary>
        [JsonProperty("eventTypes")]
        public List<string>? EventTypes { get; set; }

        /// <summary>
        /// Unique identifier of the company to indicate company-specific events. The associated webhook consumer will receive events only for the specified ID.
        /// </summary>
        [JsonProperty("companyId")]
        public string? CompanyId { get; set; } = null;
    }
}