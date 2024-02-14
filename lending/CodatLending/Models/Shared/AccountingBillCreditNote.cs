
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
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; **Bill credit notes or credit notes?**<br/>
    /// 
    /// <remarks>
    /// &gt; <br/>
    /// &gt; In Codat, bill credit notes represent accounts payable only. For accounts receivable, see <a href="https://docs.codat.io/lending-api#/schemas/CreditNote">Credit notes</a>.<br/>
    /// <br/>
    /// View the coverage for bill credit notes in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=billCreditNotes&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// A bill credit note is issued by a supplier for the purpose of recording credit. For example, if a supplier was unable to fulfil an order that was placed by a business, or delivered damaged goods, they would issue a bill credit note. A bill credit note reduces the amount a business owes to the supplier. It can be refunded to the business or used to pay off future bills.<br/>
    /// <br/>
    /// In the Codat API, a bill credit note is an accounts payable record issued by a <a href="https://docs.codat.io/lending-api#/schemas/Supplier">supplier</a>. <br/>
    /// <br/>
    /// A bill credit note includes details of:<br/>
    /// * The original and remaining credit.<br/>
    /// * Any allocations of the credit against other records, such as <a href="https://docs.codat.io/lending-api#/schemas/Bill">bills</a>.<br/>
    /// * The supplier that issued the bill credit note.
    /// </remarks>
    /// </summary>
    public class AccountingBillCreditNote
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
        [JsonProperty("allocatedOnDate")]
        public string? AllocatedOnDate { get; set; }

        /// <summary>
        /// Friendly reference for the bill credit note.
        /// </summary>
        [JsonProperty("billCreditNoteNumber")]
        public string? BillCreditNoteNumber { get; set; }

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
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.<br/>
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
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |<br/>
        /// <br/>
        /// <br/>
        /// ### Integration-specific details<br/>
        /// <br/>
        /// | Integration       | Scenario                                        | System behavior                                                                                                                                                      |<br/>
        /// |-------------------|-------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|<br/>
        /// | QuickBooks Online | Transaction currency differs from base currency | If currency rate value is left `null`, a rate of 1 will be used by QBO by default. To override this, include the required currency rate in the expense transaction.  |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Percentage rate of any discount applied to the bill credit note.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal DiscountPercentage { get; set; } = default!;

        /// <summary>
        /// Identifier for the bill credit note that is unique to a company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

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
        [JsonProperty("issueDate")]
        public string? IssueDate { get; set; }

        /// <summary>
        /// An array of line 
        /// </summary>
        [JsonProperty("lineItems")]
        public List<BillCreditNoteLineItem>? LineItems { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Any additional information about the bill credit note.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// An array of payment allocations.
        /// </summary>
        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation>? PaymentAllocations { get; set; }

        /// <summary>
        /// Amount of the bill credit note that is still outstanding.
        /// </summary>
        [JsonProperty("remainingCredit")]
        public decimal? RemainingCredit { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the bill credit note
        /// </summary>
        [JsonProperty("status")]
        public BillCreditNoteStatus Status { get; set; } = default!;

        /// <summary>
        /// Total amount of the bill credit note, including discounts but excluding tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal SubTotal { get; set; } = default!;

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. <br/>
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }

        /// <summary>
        /// Reference to the supplier the record relates to.
        /// </summary>
        [JsonProperty("supplierRef")]
        public SupplierRef? SupplierRef { get; set; }

        /// <summary>
        /// Total amount of credit that has been applied to the business&apos; account with the supplier, including discounts and tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; } = default!;

        /// <summary>
        /// Total value of any discounts applied.
        /// </summary>
        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount { get; set; } = default!;

        /// <summary>
        /// Amount of tax included in the bill credit note.
        /// </summary>
        [JsonProperty("totalTaxAmount")]
        public decimal TotalTaxAmount { get; set; } = default!;

        [JsonProperty("withholdingTax")]
        public List<WithholdingTaxItems>? WithholdingTax { get; set; }
    }
}