
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    
    public class PushOperationChange
    {

        [JsonProperty("attachmentId")]
        public string? AttachmentId { get; set; }

        [JsonProperty("recordRef")]
        public PushOperationRef? RecordRef { get; set; }

        [JsonProperty("type")]
        public PushChangeType? Type { get; set; }
    }
}