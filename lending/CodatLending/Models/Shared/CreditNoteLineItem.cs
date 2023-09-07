
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
    
    
    public class CreditNoteLineItem
    {
        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }
        
        /// <summary>
        /// Friendly name of each line item. For example, the goods or service for which credit has been issued.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// Value of any discounts applied.
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal? DiscountAmount { get; set; }
        
        /// <summary>
        /// Percentage rate of any discount applied to the line item.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal? DiscountPercentage { get; set; }
        
        [JsonProperty("isDirectIncome")]
        public bool? IsDirectIncome { get; set; }
        
        /// <summary>
        /// Reference to the item the line is linked to.
        /// </summary>
        [JsonProperty("itemRef")]
        public ItemRef? ItemRef { get; set; }
        
        /// <summary>
        /// Number of units of the goods or service for which credit has been issued.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        
        /// <summary>
        /// Amount of credit associated with the line item, including discounts but excluding tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal? SubTotal { get; set; }
        
        /// <summary>
        /// Amount of tax associated with the line item.
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
        /// Total amount of the line item, including discounts and tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }
        
        /// <summary>
        /// Categories, and a project and customer, against which the item is tracked.
        /// </summary>
        [JsonProperty("tracking")]
        public AccountsReceivableTracking? Tracking { get; set; }
        
        /// <summary>
        /// Reference to the tracking categories to which the line item is linked.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("trackingCategoryRefs")]
        public List<TrackingCategoryRef>? TrackingCategoryRefs { get; set; }
        
        /// <summary>
        /// Unit price of the goods or service.
        /// </summary>
        [JsonProperty("unitAmount")]
        public decimal UnitAmount { get; set; }
        
    }
    
}