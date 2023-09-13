
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    
    public class CreateJournalEntryResponse
    {
        /// <summary>
        /// Contains a single entry that communicates which record has changed and the manner in which it changed. 
        /// </summary>
        [JsonProperty("changes")]
        public List<PushOperationChange>? Changes { get; set; }
        
        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("companyId")]
        public string CompanyId { get; set; } = default!;
        
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
        [JsonProperty("completedOnUtc")]
        public string? CompletedOnUtc { get; set; }
        
        /// <summary>
        /// > **Language tip:** For the top-level record of a company's financial transactions, refer to the [Journals](https://docs.codat.io/accounting-api#/schemas/Journal) data type
        /// 
        /// <remarks>
        /// 
        /// > View the coverage for journal entries in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries" target="_blank">Data coverage explorer</a>.
        /// 
        /// ## Overview
        /// 
        /// A journal entry report shows the entries made in a company's general ledger, or [accounts](https://docs.codat.io/accounting-api#/schemas/Account), when transactions are approved. The journal line items for each journal entry should balance.
        /// 
        /// A journal entry line item is a single transaction line on the journal entry. For example: 
        /// 
        /// - When a journal entry is recording a receipt of cash, the credit to accounts receivable and the debit to cash are separate line items. 
        /// - When a company needs to recognise revenue from an annual contract on a monthly basis, on receipt of cash for month one, they make a debit to deferred income and a credit to revenue.
        /// 
        /// In Codat a journal entry contains details of:
        /// 
        /// - The date on which the entry was created and posted.
        /// - Itemised lines, including amounts and currency.
        /// - A reference to the associated accounts.
        /// - A reference to the underlying record. For example, the invoice, bill, or other data type that triggered the posting of the journal entry to the general ledger. 
        /// 
        /// > **Pushing journal entries**  
        /// > Codat only supports journal entries in the base currency of the company that are pushed into accounts denominated in the same base currency.
        /// </remarks>
        /// </summary>
        [JsonProperty("data")]
        public JournalEntry? Data { get; set; }
        
        /// <summary>
        /// Unique identifier for a company's data connection.
        /// </summary>
        [JsonProperty("dataConnectionKey")]
        public string DataConnectionKey { get; set; } = default!;
        
        /// <summary>
        /// Available Data types
        /// </summary>
        [JsonProperty("dataType")]
        public DataType? DataType { get; set; }
        
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        /// <summary>
        /// A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted.
        /// </summary>
        [JsonProperty("pushOperationKey")]
        public string PushOperationKey { get; set; } = default!;
        
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
        [JsonProperty("requestedOnUtc")]
        public string RequestedOnUtc { get; set; } = default!;
        
        /// <summary>
        /// The status of the push operation.
        /// </summary>
        [JsonProperty("status")]
        public PushOperationStatus Status { get; set; } = default!;
        
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; } = default!;
        
        [JsonProperty("timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }
        
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("timeoutInSeconds")]
        public int? TimeoutInSeconds { get; set; }
        
        /// <summary>
        /// A human-readable object describing validation decisions Codat has made when pushing data into the platform. If a push has failed because of validation errors, they will be detailed here.
        /// </summary>
        [JsonProperty("validation")]
        public Validation? Validation { get; set; }
        
    }
    
}