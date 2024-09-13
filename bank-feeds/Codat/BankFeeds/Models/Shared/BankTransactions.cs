//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    
    public class BankTransactions
    {

        /// <summary>
        /// Identifier for the bank account transaction, unique for the company in the accounting software.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

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
        public string Date { get; set; } = default!;

        /// <summary>
        /// Description of the bank transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The giving or receiving party such as a person or organization.
        /// </summary>
        [JsonProperty("counterparty")]
        public string? Counterparty { get; set; } = null;

        /// <summary>
        /// An optional reference to the bank transaction.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; } = null;

        /// <summary>
        /// `True` if the bank transaction has been <a href="https://www.xero.com/uk/guides/what-is-bank-reconciliation/">reconciled</a> in the accounting software.
        /// </summary>
        [JsonProperty("reconciled")]
        public bool? Reconciled { get; set; } = null;

        /// <summary>
        /// The amount transacted in the bank transaction.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; } = default!;

        /// <summary>
        /// The remaining balance in the account with ID `accountId`. This field is optional for QuickBooks Online but is required for Xero, Sage, NetSuite, Exact, and FreeAgent.
        /// </summary>
        [JsonProperty("balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Type of transaction for the bank statement line.
        /// </summary>
        [JsonProperty("transactionType")]
        public BankTransactionType? TransactionType { get; set; } = null;
    }
}