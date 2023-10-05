
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
    
    /// <summary>
    /// A bank feed connection between a source account and a target account, including potential target accounts.
    /// </summary>
    public class BankFeedMapping
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
        [JsonProperty("feedStartDate")]
        public string? FeedStartDate { get; set; }

        /// <summary>
        /// Unique ID for the source account.
        /// </summary>
        [JsonProperty("sourceAccountId")]
        public string? SourceAccountId { get; set; }

        /// <summary>
        /// Name for the source account.
        /// </summary>
        [JsonProperty("sourceAccountName")]
        public string? SourceAccountName { get; set; }

        /// <summary>
        /// Account number for the source account.
        /// </summary>
        [JsonProperty("sourceAccountNumber")]
        public string? SourceAccountNumber { get; set; }

        /// <summary>
        /// Balance for the source account.
        /// </summary>
        [JsonProperty("sourceBalance")]
        public string? SourceBalance { get; set; }

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
        [JsonProperty("sourceCurrency")]
        public string? SourceCurrency { get; set; }

        /// <summary>
        /// The status.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Unique ID for the target account in the accounting platform.
        /// </summary>
        [JsonProperty("targetAccountId")]
        public string? TargetAccountId { get; set; }

        /// <summary>
        /// Name for the target account in the accounting platform.
        /// </summary>
        [JsonProperty("targetAccountName")]
        public string? TargetAccountName { get; set; }

        /// <summary>
        /// An array of potential target accounts.
        /// </summary>
        [JsonProperty("targetAccountOptions")]
        public List<TargetAccountOption>? TargetAccountOptions { get; set; }
    }
}