
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
    using System;
    
    
    public class DirectCostLineItem
    {
        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }
        
        /// <summary>
        /// Friendly name of the goods or services.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// Discount amount for the line before tax.
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal? DiscountAmount { get; set; }
        
        /// <summary>
        /// Discount percentage for the line before tax.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal? DiscountPercentage { get; set; }
        
        /// <summary>
        /// Reference to the item the line is linked to.
        /// </summary>
        [JsonProperty("itemRef")]
        public ItemRef? ItemRef { get; set; }
        
        /// <summary>
        /// Number of units of goods or services received.
        /// 
        /// <remarks>
        /// 
        /// Note: If the platform does not provide this information, the quantity will be mapped as 1.
        /// </remarks>
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        
        /// <summary>
        /// Amount of the line, inclusive of discounts but exclusive of tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal? SubTotal { get; set; }
        
        /// <summary>
        /// Amount of tax for the line.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }
        
        /// <summary>
        /// Data types that reference a tax rate, for example invoice and bill line items, use a taxRateRef that includes the ID and name of the linked tax rate.
        /// 
        /// <remarks>
        /// 
        /// Found on:
        /// 
        /// - Bill line items
        /// - Bill Credit Note line items
        /// - Credit Note line items
        /// - Direct incomes line items
        /// - Invoice line items
        /// - Items
        /// </remarks>
        /// </summary>
        [JsonProperty("taxRateRef")]
        public TaxRateRef? TaxRateRef { get; set; }
        
        /// <summary>
        /// Total amount of the line, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }
        
        [JsonProperty("tracking")]
        public Tracking? Tracking { get; set; }
        
        /// <summary>
        /// Collection of categories against which this direct cost is tracked.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("trackingCategoryRefs")]
        public List<TrackingCategoryRef>? TrackingCategoryRefs { get; set; }
        
        /// <summary>
        /// Price of each unit of goods or services.
        /// 
        /// <remarks>
        /// Note: If the platform does not provide this information, the unit amount will be mapped to the total amount.
        /// </remarks>
        /// </summary>
        [JsonProperty("unitAmount")]
        public decimal UnitAmount { get; set; }
        
    }
    
}