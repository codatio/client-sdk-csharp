//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    
    public class PushFieldValidation
    {

        /// <summary>
        /// Details on the validation issue.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; } = default!;

        /// <summary>
        /// Field name that resulted in the validation issue.
        /// </summary>
        [JsonProperty("field")]
        public string? Field { get; set; }

        /// <summary>
        /// Unique reference identifier for the validation issue.
        /// </summary>
        [JsonProperty("ref")]
        public string? Ref { get; set; } = null;
    }
}