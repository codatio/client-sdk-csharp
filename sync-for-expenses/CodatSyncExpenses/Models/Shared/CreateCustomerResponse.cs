
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class CreateCustomerResponse
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
        /// &gt; View the coverage for customers in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=customers&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ## Overview<br/>
        /// <br/>
        /// A customer is a person or organisation that buys goods or services. From the Customers endpoints, you can retrieve a <a href="https://api.codat.io/swagger/index.html#/Customers/get_companies__companyId__data_customers">list of all the customers of a company</a>.<br/>
        /// <br/>
        /// Customers&apos; data links to accounts receivable <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Invoice">invoices</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("data")]
        public Customer? Data { get; set; }

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