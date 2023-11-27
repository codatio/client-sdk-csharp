
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ServiceCharge
    {

        /// <summary>
        /// Service charges for this order.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The number of times the charge is charged.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Amount of the service charge that is tax.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Percentage rate (from 0 to 100) of any tax applied to the service charge.
        /// </summary>
        [JsonProperty("taxPercentage")]
        public decimal? TaxPercentage { get; set; }

        /// <summary>
        /// Taxes breakdown as applied to service charges.
        /// </summary>
        [JsonProperty("taxes")]
        public List<TaxComponentAllocation>? Taxes { get; set; }

        /// <summary>
        /// Total amount of the service charge, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The type of the service charge.
        /// </summary>
        [JsonProperty("type")]
        public ServiceChargeType? Type { get; set; }
    }
}