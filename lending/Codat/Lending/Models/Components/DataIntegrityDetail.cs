//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class DataIntegrityDetail
    {

        /// <summary>
        /// ID GUID of the transaction.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The data type of the record.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID GUID representing the connection of the accounting or banking platform.
        /// </summary>
        [JsonProperty("connectionId")]
        public string? ConnectionId { get; set; }

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
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// The transaction description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The transaction value.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The currency data type in Codat is the <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a> currency code, e.g. _GBP_.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ## Unknown currencies<br/>
        /// <br/>
        /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. <br/>
        /// <br/>
        /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
        /// </remarks>
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("matches")]
        public List<DataIntegrityMatch>? Matches { get; set; }
    }
}