
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
    
    public class BillLineItem
    {

        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }

        /// <summary>
        /// Friendly name of the goods or services received.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Numerical value of any discounts applied.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Do not use to apply discounts in Oracle NetSuite—see Oracle NetSuite integration reference.
        /// </remarks>
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Percentage rate of any discount applied to the bill.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal? DiscountPercentage { get; set; }

        /// <summary>
        /// The bill is a direct cost if `True`.
        /// </summary>
        [JsonProperty("isDirectCost")]
        public bool? IsDirectCost { get; set; }

        /// <summary>
        /// Reference to the item the line is linked to.
        /// </summary>
        [JsonProperty("itemRef")]
        public PropertieItemRef? ItemRef { get; set; }

        /// <summary>
        /// The bill line&apos;s number.
        /// </summary>
        [JsonProperty("lineNumber")]
        public string? LineNumber { get; set; }

        /// <summary>
        /// Reference to the purchase order line this line was generated from.
        /// </summary>
        [JsonProperty("purchaseOrderLineRef")]
        public RecordLineReference? PurchaseOrderLineRef { get; set; }

        /// <summary>
        /// Number of units of goods or services received.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; } = default!;

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
        /// Total amount of the line, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Categories, and a project and customer, against which the item is tracked.
        /// </summary>
        [JsonProperty("tracking")]
        public AccountsPayableTracking? Tracking { get; set; }

        /// <summary>
        /// Collection of categories against which this item is tracked.
        /// </summary>
        [JsonProperty("trackingCategoryRefs")]
        public List<TrackingCategoryRef>? TrackingCategoryRefs { get; set; }

        /// <summary>
        /// Price of each unit of goods or services.
        /// </summary>
        [JsonProperty("unitAmount")]
        public decimal UnitAmount { get; set; } = default!;
    }
}