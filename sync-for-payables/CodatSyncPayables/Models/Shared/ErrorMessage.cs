
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Your `query` parameter was not correctly formed
    /// </summary>
    public class ErrorMessage
    {
        [JsonProperty("canBeRetried")]
        public string? CanBeRetried { get; set; }
        
        [JsonProperty("correlationId")]
        public string? CorrelationId { get; set; }
        
        [JsonProperty("detailedErrorCode")]
        public int? DetailedErrorCode { get; set; }
        
        [JsonProperty("error")]
        public string? Error { get; set; }
        
        [JsonProperty("service")]
        public string? Service { get; set; }
        
        [JsonProperty("statusCode")]
        public int? StatusCode { get; set; }
        
    }
    
}