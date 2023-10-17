
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using Newtonsoft.Json;
    
    public class ErrorMessage
    {

        /// <summary>
        /// `True` if the error occurred transiently and can be retried.
        /// </summary>
        [JsonProperty("canBeRetried")]
        public string? CanBeRetried { get; set; }

        /// <summary>
        /// Unique identifier used to propagate to all downstream services and determine the source of the error.
        /// </summary>
        [JsonProperty("correlationId")]
        public string? CorrelationId { get; set; }

        /// <summary>
        /// Machine readable error code used to automate processes based on the code returned.
        /// </summary>
        [JsonProperty("detailedErrorCode")]
        public long? DetailedErrorCode { get; set; }

        /// <summary>
        /// A brief description of the error.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Codat&apos;s service the returned the error.
        /// </summary>
        [JsonProperty("service")]
        public string? Service { get; set; }

        /// <summary>
        /// The HTTP status code returned by the error.
        /// </summary>
        [JsonProperty("statusCode")]
        public long? StatusCode { get; set; }
    }
}