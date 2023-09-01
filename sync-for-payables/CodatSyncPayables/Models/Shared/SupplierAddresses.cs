
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
    
    
    public class SupplierAddresses
    {
        /// <summary>
        /// City of the customer address.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }
        
        /// <summary>
        /// Country of the customer address.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }
        
        /// <summary>
        /// Line 1 of the customer address.
        /// </summary>
        [JsonProperty("line1")]
        public string? Line1 { get; set; }
        
        /// <summary>
        /// Line 2 of the customer address.
        /// </summary>
        [JsonProperty("line2")]
        public string? Line2 { get; set; }
        
        /// <summary>
        /// Postal code or zip code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }
        
        /// <summary>
        /// Region of the customer address.
        /// </summary>
        [JsonProperty("region")]
        public string? Region { get; set; }
        
        /// <summary>
        /// The type of the address
        /// </summary>
        [JsonProperty("type")]
        public AccountingAddressType Type { get; set; }
        
    }
    
}