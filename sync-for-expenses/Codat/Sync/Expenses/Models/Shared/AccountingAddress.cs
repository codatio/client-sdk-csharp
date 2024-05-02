
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    public class AccountingAddress
    {

        /// <summary>
        /// City of the customer address.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; } = null;

        /// <summary>
        /// Country of the customer address.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; } = null;

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
        /// Postal code or zip code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; } = null;

        /// <summary>
        /// Region of the customer address.
        /// </summary>
        [JsonProperty("region")]
        public string? Region { get; set; } = null;

        /// <summary>
        /// The type of the address
        /// </summary>
        [JsonProperty("type")]
        public AccountingAddressType Type { get; set; } = default!;
    }
}