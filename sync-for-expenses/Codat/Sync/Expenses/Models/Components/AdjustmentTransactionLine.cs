//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class AdjustmentTransactionLine
    {

        /// <summary>
        /// Amount of the line. A positive line represents a debit; a negative line represents a credit.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; } = default!;

        [JsonProperty("accountRef")]
        public RecordRef AccountRef { get; set; } = default!;

        /// <summary>
        /// Any private, company notes about the transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("trackingRefs")]
        public List<TrackingRefAdjustmentTransaction>? TrackingRefs { get; set; } = null;

        /// <summary>
        /// Unique identifier for the customer billed for the transaction. The `invoiceTo` object is currently supported only for QuickBooks Online and QuickBooks Desktop.
        /// </summary>
        [JsonProperty("invoiceTo")]
        public InvoiceTo? InvoiceTo { get; set; } = null;
    }
}