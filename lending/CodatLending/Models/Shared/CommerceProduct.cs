
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
    using System.Collections.Generic;
    
    
    /// <summary>
    /// A Product is an item in the company's inventory, and includes information about the price and quantity of all products, and variants thereof, available for sale.
    /// 
    /// <remarks>
    /// 
    /// Explore our [data coverage](https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&dataType=commerce-products) for this data type.
    /// 
    /// </remarks>
    /// </summary>
    public class CommerceProduct
    {
        /// <summary>
        /// Retail category that the product is assigned to
        /// </summary>
        [JsonProperty("categorization")]
        public string? Categorization { get; set; }
        
        /// <summary>
        /// Description of the product recorded in the commerce or point of sale platform.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Whether the product represents a gift card or voucher that
        /// 
        /// <remarks>
        /// can be redeemed in the commerce or POS platform
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("isGiftCard")]
        public bool? IsGiftCard { get; set; }
        
        /// <summary>
        /// Name of the product in the commerce or POS system
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        [JsonProperty("variants")]
        public List<ProductVariant>? Variants { get; set; }
        
    }
    
}