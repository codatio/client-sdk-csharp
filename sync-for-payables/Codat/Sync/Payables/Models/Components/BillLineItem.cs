//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    
    public class BillLineItem
    {

        /// <summary>
        /// Friendly name of the goods or services received.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Unit price of the goods or service.
        /// </summary>
        [JsonProperty("unitAmount")]
        public decimal UnitAmount { get; set; } = default!;

        /// <summary>
        /// Number of units of goods or services received.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; } = default!;

        /// <summary>
        /// Amount of tax applied to the line item.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Reference to the account to which the line item is linked.
        /// </summary>
        [JsonProperty("accountRef")]
        public BillAccountRef AccountRef { get; set; } = default!;

        /// <summary>
        /// Total amount of the line, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; } = null;

        /// <summary>
        /// Reference to the tax rate to which the line item is linked.
        /// </summary>
        [JsonProperty("taxRateRef")]
        public BillTaxRateRef TaxRateRef { get; set; } = default!;
    }
}