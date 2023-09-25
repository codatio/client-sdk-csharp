
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
    /// Categories, and a project and customer, against which the item is tracked.
    /// </summary>
    public class AccountsReceivableTracking
    {

        [JsonProperty("categoryRefs")]
        public List<TrackingCategoryRef> CategoryRefs { get; set; } = default!;

        [JsonProperty("customerRef")]
        public AccountingCustomerRef? CustomerRef { get; set; }

        /// <summary>
        /// Defines if the bill or bill credit note is billed/rebilled to a project.
        /// </summary>
        [JsonProperty("isBilledTo")]
        public BilledToType1 IsBilledTo { get; set; } = default!;

        /// <summary>
        /// Defines if the bill or bill credit note is billed/rebilled to a project.
        /// </summary>
        [JsonProperty("isRebilledTo")]
        public BilledToType1 IsRebilledTo { get; set; } = default!;

        [JsonProperty("projectRef")]
        public ProjectRef? ProjectRef { get; set; }

        /// <summary>
        /// Links the current record to the underlying record or data type that created it. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// For example, if a journal entry is generated based on an invoice, this property allows you to connect the journal entry to the underlying invoice in our data model. 
        /// </remarks>
        /// </summary>
        [JsonProperty("recordRef")]
        public AccountsReceivableTrackingRecordReference? RecordRef { get; set; }
    }
}