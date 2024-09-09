//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    public class ValidationItem
    {

        /// <summary>
        /// Unique identifier for a validation item.
        /// </summary>
        [JsonProperty("itemId")]
        public string? ItemId { get; set; } = null;

        /// <summary>
        /// A message outlining validation item&apos;s issue.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; } = null;

        /// <summary>
        /// Name of validator.
        /// </summary>
        [JsonProperty("validatorName")]
        public string? ValidatorName { get; set; } = null;
    }
}