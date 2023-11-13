
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Weblink associated with the company.
    /// </summary>
    public class WebLink
    {

        /// <summary>
        /// The type of the weblink.
        /// </summary>
        [JsonProperty("type")]
        public Type? Type { get; set; }

        /// <summary>
        /// The full URL for the weblink.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}