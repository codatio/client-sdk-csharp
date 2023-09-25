
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
    
    /// <summary>
    /// Information about a queued, in progress or completed pull operation.&lt;br/&gt;
    /// 
    /// <remarks>
    /// *Formally called `dataset`*
    /// </remarks>
    /// </summary>
    public class PullOperation
    {

        /// <summary>
        /// Unique identifier of the company associated to this pull operation.
        /// </summary>
        [JsonProperty("companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the connection associated to this pull operation.
        /// </summary>
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// Available Data types
        /// </summary>
        [JsonProperty("dataType")]
        public DataType DataType { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the pull operation.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// `True` if the pull operation completed successfully.
        /// </summary>
        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; } = default!;

        /// <summary>
        /// `True` if the pull operation entered an error state.
        /// </summary>
        [JsonProperty("isErrored")]
        public bool IsErrored { get; set; } = default!;

        /// <summary>
        /// An integer signifying the progress of the pull operation.
        /// </summary>
        [JsonProperty("progress")]
        public long Progress { get; set; } = default!;

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
        [JsonProperty("requested")]
        public string Requested { get; set; } = default!;

        /// <summary>
        /// The current status of the pull operation.
        /// </summary>
        [JsonProperty("status")]
        public PullOperationStatus Status { get; set; } = default!;
    }
}