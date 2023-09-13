
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
    
    
    public class TaxComponentAllocation
    {
        /// <summary>
        /// Tax amount on order line sale as available from source commerce platform.
        /// </summary>
        [JsonProperty("rate")]
        public float? Rate { get; set; }
        
        /// <summary>
        /// Taxes rates reference object depending on the rates being available on source commerce package.
        /// </summary>
        [JsonProperty("taxComponentRef")]
        public TaxComponentRef? TaxComponentRef { get; set; }
        
    }
    
}