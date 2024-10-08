//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Components
{
    using Codat.Sync.Payables.V1.Models.Components;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    public class Address
    {

        /// <summary>
        /// The type of the address
        /// </summary>
        [JsonProperty("type")]
        public AccountingAddressType Type { get; set; } = default!;

        /// <summary>
        /// Line 1 of the customer address.
        /// </summary>
        [JsonProperty("line1")]
        public string? Line1 { get; set; } = null;

        /// <summary>
        /// Line 2 of the customer address.
        /// </summary>
        [JsonProperty("line2")]
        public string? Line2 { get; set; } = null;

        /// <summary>
        /// City of the customer address.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; } = null;

        /// <summary>
        /// Region of the customer address.
        /// </summary>
        [JsonProperty("region")]
        public string? Region { get; set; } = null;

        /// <summary>
        /// Country of the customer address.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; } = null;

        /// <summary>
        /// Postal code or zip code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; } = null;
    }
}