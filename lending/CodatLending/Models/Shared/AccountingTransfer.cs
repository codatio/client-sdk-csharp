
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
    using System.Collections.Generic;
    
    /// <summary>
    /// &amp;gt; View the coverage for transfers in the &amp;lt;a className=&amp;quot;external&amp;quot; href=&amp;quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;amp;dataType=transfers&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;Data coverage explorer&amp;lt;/a&amp;gt;.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// A transfer records the movement of money between two bank accounts, or between a bank account and a nominal account. It is a child data type of <a href="https://docs.codat.io/accounting-api#/schemas/AccountTransaction">account transactions</a>.
    /// </remarks>
    /// </summary>
    public class AccountingTransfer
    {

        /// <summary>
        /// The customer or supplier for the transfer, if available.
        /// </summary>
        [JsonProperty("contactRef")]
        public AccountingTransferContactRef? ContactRef { get; set; }

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
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// List of selected transactions to associate with the transfer. Use this field to include transactions which are posted to the _undeposited funds_ (or other holding) account within the transfer.
        /// </summary>
        [JsonProperty("depositedRecordRefs")]
        public List<RecordRef>? DepositedRecordRefs { get; set; }

        /// <summary>
        /// Description of the transfer.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("from")]
        public TransferAccount? From { get; set; }

        /// <summary>
        /// Unique identifier for the transfer.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }

        [JsonProperty("to")]
        public TransferAccount? To { get; set; }

        /// <summary>
        /// Reference to the tracking categories this transfer is being tracked against.
        /// </summary>
        [JsonProperty("trackingCategoryRefs")]
        public List<TrackingCategoryRef>? TrackingCategoryRefs { get; set; }
    }
}