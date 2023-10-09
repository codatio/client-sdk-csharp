
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class CreateJournalResponse
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
        /// In Codat&apos;s data model, dates and times are represented using the &lt;a class=&quot;external&quot; href=&quot;https://en.wikipedia.org/wiki/ISO_8601&quot; target=&quot;_blank&quot;&gt;ISO 8601 standard&lt;/a&gt;. Date and time fields are formatted as strings; for example:<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ```<br/>
        /// 2020-10-08T22:40:50Z<br/>
        /// 2021-01-01T00:00:00<br/>
        /// ```<br/>
        /// <br/>
        /// <br/>
        /// <br/>
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:<br/>
        /// <br/>
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`<br/>
        /// - Unqualified local time: `2021-11-15T01:00:00`<br/>
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`<br/>
        /// <br/>
        /// &gt; Time zones<br/>
        /// &gt; <br/>
        /// &gt; Not all dates from Codat will contain information about time zones.  <br/>
        /// &gt; Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("completedOnUtc")]
        public string? CompletedOnUtc { get; set; }

        /// <summary>
        /// &gt; **Language tip:** For line items, or individual transactions, of a company&apos;s financial documents, refer to the <a href="https://docs.codat.io/sync-for-payroll-api#/schemas/JournalEntry">Journal entries</a> data type<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// &gt; View the coverage for journals in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=journals&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
        /// <br/>
        /// ## Overview<br/>
        /// <br/>
        /// In accounting software, journals are used to record all the financial transactions of a company. Each transaction in a journal is represented by a separate <a href="https://docs.codat.io/sync-for-payroll-api#/schemas/JournalEntry">journal entry</a>. These entries are used to create the general ledger, which is then used to create the financial statements of a business.<br/>
        /// <br/>
        /// When a company records all their transactions in a single journal, it can become large and difficult to maintain and track. This is why large companies often use multiple journals (also known as subjournals) to categorize and manage journal entries.<br/>
        /// <br/>
        /// Such journals can be divided into two categories:<br/>
        /// <br/>
        /// - Special journals: journals used to record specific types of transactions; for example, a purchases journal, a sales journal, or a cash management journal.<br/>
        /// - General journals: journals used to record transactions that fall outside the scope of the special journals.<br/>
        /// <br/>
        /// Multiple journals or subjournals are used in the following Codat integrations:<br/>
        /// <br/>
        /// - <a href="https://docs.codat.io/integrations/accounting/sage-intacct/accounting-sage-intacct">Sage Intacct</a>  (mandatory)<br/>
        /// - <a href="https://docs.codat.io/integrations/accounting/exact-online/accounting-exact-online">Exact Online</a>  (mandatory)<br/>
        /// - <a href="https://docs.codat.io/integrations/accounting/netsuite/accounting-netsuite">Oracle NetSuite</a> (optional)<br/>
        /// <br/>
        /// &gt; When pushing journal entries to an accounting platform that doesn’t support multiple journals (multi-book accounting), the entries will be linked to the platform-generic journal. The Journals data type will only include one object.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("data")]
        public Journal? Data { get; set; }

        /// <summary>
        /// Unique identifier for a company&apos;s data connection.
        /// </summary>
        [JsonProperty("dataConnectionKey")]
        public string DataConnectionKey { get; set; } = default!;

        /// <summary>
        /// Available Data types
        /// </summary>
        [JsonProperty("dataType")]
        public DataType? DataType { get; set; }

        /// <summary>
        /// A message about the error.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted.
        /// </summary>
        [JsonProperty("pushOperationKey")]
        public string PushOperationKey { get; set; } = default!;

        /// <summary>
        /// In Codat&apos;s data model, dates and times are represented using the &lt;a class=&quot;external&quot; href=&quot;https://en.wikipedia.org/wiki/ISO_8601&quot; target=&quot;_blank&quot;&gt;ISO 8601 standard&lt;/a&gt;. Date and time fields are formatted as strings; for example:<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ```<br/>
        /// 2020-10-08T22:40:50Z<br/>
        /// 2021-01-01T00:00:00<br/>
        /// ```<br/>
        /// <br/>
        /// <br/>
        /// <br/>
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:<br/>
        /// <br/>
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`<br/>
        /// - Unqualified local time: `2021-11-15T01:00:00`<br/>
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`<br/>
        /// <br/>
        /// &gt; Time zones<br/>
        /// &gt; <br/>
        /// &gt; Not all dates from Codat will contain information about time zones.  <br/>
        /// &gt; Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("requestedOnUtc")]
        public string RequestedOnUtc { get; set; } = default!;

        /// <summary>
        /// The current status of the push operation.
        /// </summary>
        [JsonProperty("status")]
        public PushOperationStatus Status { get; set; } = default!;

        /// <summary>
        /// Push status code.
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; } = default!;

        /// <summary>
        /// Number of minutes the push operation must complete within before it times out.
        /// </summary>
        [JsonProperty("timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Number of seconds the push operation must complete within before it times out.
        /// </summary>
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