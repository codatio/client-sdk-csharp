
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Describes the state of data in the Codat cache for a company and data type
    /// </summary>
    public class DataStatus
    {

        /// <summary>
        /// The current status of the dataset in Codat&apos;s cache.
        /// </summary>
        [JsonProperty("currentStatus")]
        public string CurrentStatus { get; set; } = default!;

        /// <summary>
        /// Available Data types
        /// </summary>
        [JsonProperty("dataType")]
        public DataTypes DataType { get; set; } = default!;

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
        [JsonProperty("lastSuccessfulSync")]
        public string LastSuccessfulSync { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the most recent successful sync of data type.
        /// </summary>
        [JsonProperty("latestSuccessfulSyncId")]
        public string? LatestSuccessfulSyncId { get; set; }

        /// <summary>
        /// Unique identifier for most recent sync of data type.
        /// </summary>
        [JsonProperty("latestSyncId")]
        public string? LatestSyncId { get; set; }
    }
}