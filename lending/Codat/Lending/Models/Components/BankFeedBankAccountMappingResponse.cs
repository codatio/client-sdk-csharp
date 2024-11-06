//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    
    public class BankFeedBankAccountMappingResponse
    {

        /// <summary>
        /// Unique ID for the source account.
        /// </summary>
        [JsonProperty("sourceAccountId")]
        public string? SourceAccountId { get; set; }

        /// <summary>
        /// Unique ID for the target account.
        /// </summary>
        [JsonProperty("targetAccountId")]
        public string? TargetAccountId { get; set; } = null;

        /// <summary>
        /// Status of the POST request.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; } = null;

        /// <summary>
        /// Error returned during the post request
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; } = null;
    }
}