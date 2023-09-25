
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
    /// &amp;gt; View the coverage for credit notes in the &amp;lt;a className=&amp;quot;external&amp;quot; href=&amp;quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;amp;dataType=creditNotes&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;Data coverage explorer&amp;lt;/a&amp;gt;.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// Think of a credit note as a voucher issued to a customer. It is a reduction that can be applied against one or multiple invoices. A credit note can either reduce the amount owed or cancel out an invoice entirely.<br/>
    /// <br/>
    /// In the Codat system a credit note is issued to a <a href="https://docs.codat.io/accounting-api#/schemas/Customer">customer&apos;s</a> accounts receivable. <br/>
    /// <br/>
    /// It contains details of:<br/>
    /// * The amount of credit remaining and its status.<br/>
    /// * Payment allocations against the payments type, in this case an invoice.<br/>
    /// * Which customers the credit notes have been issued to.
    /// </remarks>
    /// </summary>
    public class AccountingCreditNote
    {

        /// <summary>
        /// Additional tax amount applied to credit note.
        /// </summary>
        [JsonProperty("additionalTaxAmount")]
        public decimal? AdditionalTaxAmount { get; set; }

        /// <summary>
        /// Percentage rate of any additional tax applied to the credit note.
        /// </summary>
        [JsonProperty("additionalTaxPercentage")]
        public decimal? AdditionalTaxPercentage { get; set; }

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
        [JsonProperty("allocatedOnDate")]
        public string? AllocatedOnDate { get; set; }

        /// <summary>
        /// Friendly reference for the credit note.
        /// </summary>
        [JsonProperty("creditNoteNumber")]
        public string? CreditNoteNumber { get; set; }

        /// <summary>
        /// The currency data type in Codat is the &lt;a href=&quot;https://en.wikipedia.org/wiki/ISO_4217&quot;&gt;ISO 4217&lt;/a&gt; currency code, e.g. _GBP_.&lt;br/&gt;
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
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// Currency rates in Codat are implemented as the multiple of foreign currency units to each base currency unit.  <br/>
        /// <br/>
        /// It is not possible to perform the currency conversion with two or more non-base currencies participating in the transaction. For example, if a company&apos;s base currency is USD, and it has a bill issued in EUR, then the bill payment must happen in USD or EUR.<br/>
        /// <br/>
        /// Where the currency rate is provided by the underlying accounting platform, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). <br/>
        /// <br/>
        /// For accounting platforms which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.<br/>
        /// <br/>
        /// ## Examples with base currency of GBP<br/>
        /// <br/>
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (GBP) |<br/>
        /// | :--------------- | :------------- | :------------ | :------------------------- |<br/>
        /// | **USD**          | $20            | 0.781         | £15.62                     |<br/>
        /// | **EUR**          | €20            | 0.885         | £17.70                     |<br/>
        /// | **RUB**          | ₽20            | 0.011         | £0.22                      |<br/>
        /// <br/>
        /// ## Examples with base currency of USD<br/>
        /// <br/>
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (USD) |<br/>
        /// | :--------------- | :------------- | :------------ | :------------------------- |<br/>
        /// | **GBP**          | £20            | 1.277         | $25.54                     |<br/>
        /// | **EUR**          | €20            | 1.134         | $22.68                     |<br/>
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }

        [JsonProperty("customerRef")]
        public AccountingCustomerRef? CustomerRef { get; set; }

        /// <summary>
        /// Percentage rate (from 0 to 100) of discounts applied to the credit note.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal DiscountPercentage { get; set; } = default!;

        /// <summary>
        /// Identifier for the credit note, unique to the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

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
        [JsonProperty("issueDate")]
        public string? IssueDate { get; set; }

        [JsonProperty("lineItems")]
        public List<CreditNoteLineItem>? LineItems { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Any additional information about the credit note. Where possible, Codat links to a data field in the accounting platform that is publicly available. This means that the contents of the note field are included when a credit note is emailed from the accounting platform to the customer.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// An array of payment allocations.
        /// </summary>
        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation>? PaymentAllocations { get; set; }

        /// <summary>
        /// Unused balance of totalAmount originally raised.
        /// </summary>
        [JsonProperty("remainingCredit")]
        public decimal RemainingCredit { get; set; } = default!;

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the credit note.
        /// </summary>
        [JsonProperty("status")]
        public CreditNoteStatus Status { get; set; } = default!;

        /// <summary>
        /// Value of the credit note, including discounts and excluding tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal SubTotal { get; set; } = default!;

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

        /// <summary>
        /// Total amount of credit that has been applied to the customer&amp;apos;s accounts receivable
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; } = default!;

        /// <summary>
        /// Any discounts applied to the credit note amount.
        /// </summary>
        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount { get; set; } = default!;

        /// <summary>
        /// Any tax applied to the credit note amount.
        /// </summary>
        [JsonProperty("totalTaxAmount")]
        public decimal TotalTaxAmount { get; set; } = default!;

        [JsonProperty("withholdingTax")]
        public List<Items>? WithholdingTax { get; set; }
    }
}