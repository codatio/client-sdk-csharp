
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
    
    public class OrderDiscountAllocation
    {

        /// <summary>
        /// Name of the discount in the commerce or point of sale platform.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Total amount of discount applied, excluding tax. This is typically positive (for discounts which decrease the amount of the order line), but can also be negative (for discounts which increase the amount of the order line).
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }
    }
}