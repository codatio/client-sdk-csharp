
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Models.Shared
{
    using Newtonsoft.Json;
    
    public class JournalPrototype
    {

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
        [JsonProperty("createdOn")]
        public string? CreatedOn { get; set; }

        /// <summary>
        /// If the journal has child journals, this value is true. If it doesn’t, it is false.
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// Native journal number or code.
        /// </summary>
        [JsonProperty("journalCode")]
        public string? JournalCode { get; set; }

        /// <summary>
        /// Journal name.<br/>
        /// 
        /// <remarks>
        /// The maximum length for a journal name is 256 characters. All characters above that number will be truncated.
        /// </remarks>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Parent journal ID.<br/>
        /// 
        /// <remarks>
        /// If the journal is a parent journal, this value is not present.
        /// </remarks>
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Current journal status.
        /// </summary>
        [JsonProperty("status")]
        public JournalStatus? Status { get; set; }

        /// <summary>
        /// The type of the journal.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}