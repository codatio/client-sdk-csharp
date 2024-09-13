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
    
    /// <summary>
    /// Details of all financial transactions recorded in the commerce or point of sale system are added to the Transactions data type. For example, payments, service charges, and fees.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// You can use data from the Transactions endpoints to calculate key metrics, such as:  <br/>
    /// - Transaction volumes  <br/>
    /// - Average transaction volume  <br/>
    /// - Average transaction value  <br/>
    /// - Returns  <br/>
    /// - Payouts<br/>
    /// <br/>
    /// Explore our <a href="https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&amp;dataType=commerce-transactions">data coverage</a> for this data type.
    /// </remarks>
    /// </summary>
    public class CommerceTransaction
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
        [JsonProperty("createdDate")]
        public string? CreatedDate { get; set; }

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
        [JsonProperty("sourceCreatedDate")]
        public string? SourceCreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The total transaction amount
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

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

        /// <summary>
        /// The type of the platform transaction:  <br/>
        /// 
        /// <remarks>
        /// - `Unknown`  <br/>
        /// - `FailedPayout` — Failed transfer of funds from the seller&apos;s merchant account to their bank account.  <br/>
        /// - `Payment` — Credit and debit card payments.  <br/>
        /// - `PaymentFee` — Payment provider&apos;s fee on each card payment.  <br/>
        /// - `PaymentFeeRefund` — Payment provider&apos;s fee that has been refunded to the seller.  <br/>
        /// - `Payout` — Transfer of funds from the seller&apos;s merchant account to their bank account.  <br/>
        /// - `Refund` — Refunds to a customer&apos;s credit or debit card.  <br/>
        /// - `Transfer` — Secure transfer of funds to the seller&apos;s bank account.  
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public TransactionType? Type { get; set; }

        /// <summary>
        /// Non-standardised transaction type data from the commerce software
        /// </summary>
        [JsonProperty("subType")]
        public string? SubType { get; set; }

        /// <summary>
        /// Link to the source event which triggered this transaction
        /// </summary>
        [JsonProperty("transactionSourceRef")]
        public TransactionSourceRef? TransactionSourceRef { get; set; }

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. <br/>
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting software. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }
    }
}