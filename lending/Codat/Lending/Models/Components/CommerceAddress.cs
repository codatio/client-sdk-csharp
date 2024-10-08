//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    
    public class CommerceAddress
    {

        /// <summary>
        /// The type of the address
        /// </summary>
        [JsonProperty("type")]
        public CommerceAddressType? Type { get; set; }

        /// <summary>
        /// The first line of the address
        /// </summary>
        [JsonProperty("line1")]
        public string? Line1 { get; set; }

        /// <summary>
        /// The second line of the address
        /// </summary>
        [JsonProperty("line2")]
        public string? Line2 { get; set; }

        /// <summary>
        /// The third line of the address, or city
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// The fourth line of the address, or region
        /// </summary>
        [JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The country for the address
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The postal (or zip) code for the address
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }
    }
}