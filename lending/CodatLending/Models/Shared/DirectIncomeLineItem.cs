
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
    
    public class DirectIncomeLineItem
    {

        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }

        /// <summary>
        /// A user-friendly name of the goods or services.
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
        /// The number of units of goods or services received.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Note: If the platform does not provide this information, the quantity will be mapped as 1.
        /// </remarks>
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; } = default!;

        /// <summary>
        /// The amount of the line, inclusive of discounts, but exclusive of tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// The amount of tax for the line.<br/>
        /// 
        /// <remarks>
        /// Note: If the platform does not provide this information, the quantity will be mapped as 0.00.
        /// </remarks>
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Data types that reference a tax rate, for example invoice and bill line items, use a taxRateRef that includes the ID and name of the linked tax rate.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Found on:<br/>
        /// <br/>
        /// - Bill line items<br/>
        /// - Bill Credit Note line items<br/>
        /// - Credit Note line items<br/>
        /// - Direct incomes line items<br/>
        /// - Invoice line items<br/>
        /// - Items
        /// </remarks>
        /// </summary>
        [JsonProperty("taxRateRef")]
        public TaxRateRef? TaxRateRef { get; set; }

        /// <summary>
        /// The total amount of the line, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// An array of categories against which this direct cost is tracked.
        /// </summary>
        [JsonProperty("trackingCategoryRefs")]
        public List<TrackingCategoryRef>? TrackingCategoryRefs { get; set; }

        /// <summary>
        /// The price of each unit of goods or services.<br/>
        /// 
        /// <remarks>
        /// Note: If the platform does not provide this information, the unit amount will be mapped to the total amount.
        /// </remarks>
        /// </summary>
        [JsonProperty("unitAmount")]
        public decimal UnitAmount { get; set; } = default!;
    }
}