
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
    
    
    public class Configuration
    {
        [JsonProperty("fees")]
        public Fees? Fees { get; set; }
        
        [JsonProperty("newPayments")]
        public NewPayments? NewPayments { get; set; }
        
        [JsonProperty("payments")]
        public Payments? Payments { get; set; }
        
        [JsonProperty("sales")]
        public Sales? Sales { get; set; }
        
    }
    
}