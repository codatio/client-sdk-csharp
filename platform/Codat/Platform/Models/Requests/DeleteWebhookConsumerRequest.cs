//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Requests
{
    using Codat.Platform.Utils;
    
    public class DeleteWebhookConsumerRequest
    {

        /// <summary>
        /// Unique identifier for the webhook consumer.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=webhookId")]
        public string WebhookId { get; set; } = default!;
    }
}