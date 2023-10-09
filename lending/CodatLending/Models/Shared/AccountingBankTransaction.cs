
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
    /// &gt; **Accessing Bank Accounts through Banking API**<br/>
    /// 
    /// <remarks>
    /// &gt; <br/>
    /// &gt; This datatype was originally used for accessing bank account data both in accounting integrations and open banking aggregators. <br/>
    /// &gt;<br/>
    /// &gt; To view bank account data through the Banking API, please refer to the new datatype <a href="https://docs.codat.io/lending-api#/operations/list-all-banking-transactions">here</a><br/>
    /// <br/>
    /// &gt; View the coverage for bank transactions in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=bankTransactions&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// Transactional banking data for a specific company and account.<br/>
    /// <br/>
    /// Bank transactions include the:<br/>
    /// * Amount of the transaction.<br/>
    /// * Current account balance.<br/>
    /// * Transaction type, for example, credit, debit, or transfer.
    /// </remarks>
    /// </summary>
    public class AccountingBankTransaction
    {

        /// <summary>
        /// Unique identifier to the `accountId` the bank transactions originates from.
        /// </summary>
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The amount transacted in the bank transaction.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The remaining balance in the account with ID `accountId`.
        /// </summary>
        [JsonProperty("balance")]
        public decimal? Balance { get; set; }

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
        [JsonProperty("clearedOnDate")]
        public string? ClearedOnDate { get; set; }

        /// <summary>
        /// Description of the bank transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Identifier for the bank transaction, unique to the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// `True` if the bank transaction has been <a href="https://www.xero.com/uk/guides/what-is-bank-reconciliation/">reconciled</a> in the accounting platform.
        /// </summary>
        [JsonProperty("reconciled")]
        public bool? Reconciled { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Type of transaction for the bank statement line.
        /// </summary>
        [JsonProperty("transactionType")]
        public BankTransactionType? TransactionType { get; set; }
    }
}