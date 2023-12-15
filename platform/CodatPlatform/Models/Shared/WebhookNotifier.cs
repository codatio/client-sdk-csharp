
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
    
    public class WebhookNotifier
    {

        [JsonProperty("emails")]
        public List<string>? Emails { get; set; }

        /// <summary>
        /// The URI the webhook service will POST events.
        /// </summary>
        [JsonProperty("webhook")]
        public string? Webhook { get; set; }
    }
}