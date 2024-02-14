
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class SyncSummary
    {

        /// <summary>
        /// Unique identifier for the sync in Codat.
        /// </summary>
        [JsonProperty("commerceSyncId")]
        public string? CommerceSyncId { get; set; }

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("companyId")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Array of containing objects data connection information for the company.
        /// </summary>
        [JsonProperty("dataConnections")]
        public List<Connection>? DataConnections { get; set; }

        /// <summary>
        /// Boolean indicator for data being pushed during a sync operation.
        /// </summary>
        [JsonProperty("dataPushed")]
        public bool? DataPushed { get; set; }

        /// <summary>
        /// Friendly error message for the sync operation.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonProperty("syncDateRangeUtc")]
        public SyncDateRangeUtc? SyncDateRangeUtc { get; set; }

        /// <summary>
        /// Exception message for the sync operation.
        /// </summary>
        [JsonProperty("syncExceptionMessage")]
        public string? SyncExceptionMessage { get; set; }

        /// <summary>
        /// Status of the sync of the company data. This is linked to status code.
        /// </summary>
        [JsonProperty("syncStatus")]
        public string? SyncStatus { get; set; }

        /// <summary>
        /// Numerical status code sync of the company data.
        /// </summary>
        [JsonProperty("syncStatusCode")]
        public int? SyncStatusCode { get; set; }

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
        [JsonProperty("syncUtc")]
        public string? SyncUtc { get; set; }
    }
}