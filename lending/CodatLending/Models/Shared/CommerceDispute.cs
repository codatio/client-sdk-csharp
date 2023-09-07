
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
    /// A customer may file a payment dispute with their bank or other card issuer when they're unsatisfied with their purchase or believe they have been charged incorrectly. For example:  
    /// 
    /// <remarks>
    /// - They didn't receive an order.  
    /// - The product they received was different to the commerce store's description.  
    /// - They've been the victim of online fraud.  
    /// 
    /// You can use data from the Disputes endpoints to calculate key metrics, such as the number of chargebacks.
    /// 
    /// Explore our [data coverage](https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&dataType=commerce-disputes) for this data type.
    /// </remarks>
    /// </summary>
    public class CommerceDispute
    {
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("createdDate")]
        public string? CreatedDate { get; set; }
        
        /// <summary>
        /// The currency data type in Codat is the [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code, e.g. _GBP_.
        /// 
        /// <remarks>
        /// 
        /// ## Unknown currencies
        /// 
        /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. 
        /// 
        /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
        /// </remarks>
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        /// <summary>
        /// Link to the source event(s) which triggered this transaction.
        /// </summary>
        [JsonProperty("disputedTransactions")]
        public List<TransactionSourceRef>? DisputedTransactions { get; set; }
        
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("dueDate")]
        public string? DueDate { get; set; }
        
        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Reason for the dispute
        /// </summary>
        [JsonProperty("reason")]
        public string? Reason { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// Current status of the dispute
        /// </summary>
        [JsonProperty("status")]
        public DisputeStatus? Status { get; set; }
        
        /// <summary>
        /// Total transaction amount that is under dispute.
        /// </summary>
        [JsonProperty("totalAmount")]
        public object? TotalAmount { get; set; }
        
    }
    
}