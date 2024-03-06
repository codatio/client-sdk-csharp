
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
    using System.Collections.Generic;
    
    /// <summary>
    /// A webhook consumer is an HTTP endpoint that developers can configure to subscribe to Codat&apos;s supported event types.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// See our documentation for more details on <a href="https://docs.codat.io/using-the-api/webhooks/overview">Codat&apos;s webhook service</a>.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class WebhookConsumer
    {

        /// <summary>
        /// Flag that enables or disables the endpoint from receiving events. Disabled when set to `true`.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// An array of event types the webhook consumer subscribes to.
        /// </summary>
        [JsonProperty("eventTypes")]
        public List<string>? EventTypes { get; set; }

        /// <summary>
        /// Unique identifier for the webhook consumer.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL that will consume webhook events dispatched by Codat.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}