
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class CreateBankTransactionsResponse
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
        /// In Codat&amp;apos;s data model, dates and times are represented using the &amp;lt;a class=&amp;quot;external&amp;quot; href=&amp;quot;https://en.wikipedia.org/wiki/ISO_8601&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;ISO 8601 standard&amp;lt;/a&amp;gt;. Date and time fields are formatted as strings; for example:&lt;br/&gt;
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

        [JsonProperty("data")]
        public CreateBankTransactions? Data { get; set; }

        /// <summary>
        /// Unique identifier for a company&amp;apos;s data connection.
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
        /// In Codat&amp;apos;s data model, dates and times are represented using the &amp;lt;a class=&amp;quot;external&amp;quot; href=&amp;quot;https://en.wikipedia.org/wiki/ISO_8601&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;ISO 8601 standard&amp;lt;/a&amp;gt;. Date and time fields are formatted as strings; for example:&lt;br/&gt;
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