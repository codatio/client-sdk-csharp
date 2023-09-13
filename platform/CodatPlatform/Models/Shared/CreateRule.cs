
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
    /// Create an event notification to a URL or list of email addresses based on the given type or condition.
    /// </summary>
    public class CreateRule
    {
        [JsonProperty("companyId")]
        public string? CompanyId { get; set; }
        
        [JsonProperty("notifiers")]
        public CreateRuleNotifiers Notifiers { get; set; } = default!;
        
        [JsonProperty("type")]
        public string Type { get; set; } = default!;
        
    }
    
}