
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Your API request was not properly authorized.
    /// </summary>
    public class ErrorMessage
    {
        [JsonProperty("canBeRetried")]
        public string? CanBeRetried { get; set; }
        
        [JsonProperty("correlationId")]
        public string? CorrelationId { get; set; }
        
        [JsonProperty("detailedErrorCode")]
        public long? DetailedErrorCode { get; set; }
        
        [JsonProperty("error")]
        public string? Error { get; set; }
        
        [JsonProperty("service")]
        public string? Service { get; set; }
        
        [JsonProperty("statusCode")]
        public long? StatusCode { get; set; }
        
    }
    
}