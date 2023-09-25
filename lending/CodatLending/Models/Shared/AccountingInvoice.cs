
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
    /// &amp;gt; **Invoices or bills?**&lt;br/&gt;
    /// 
    /// <remarks>
    /// &gt;<br/>
    /// &gt; We distinguish between invoices where the company *owes money* vs. *is owed money*. If the company issued an invoice, and is owed money (accounts receivable) we call this an Invoice.<br/>
    /// &gt;<br/>
    /// &gt; See <a href="https://docs.codat.io/accounting-api#/schemas/Bill">Bills</a> for the accounts payable equivalent of bills.<br/>
    /// <br/>
    /// View the coverage for invoices in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=invoices&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// An invoice is an itemized record of goods sold or services provided to a <a href="https://docs.codat.io/accounting-api#/schemas/Customer">customer</a>.<br/>
    /// <br/>
    /// In Codat, an invoice contains details of:<br/>
    /// <br/>
    /// - The timeline of the invoice—when it was raised, marked as paid, last edited, and so on.<br/>
    /// - How much the invoice is for, what portion of the invoice is tax or discounts, and what currency the amounts are represented in. <br/>
    /// - Who the invoice has been raised to; the _customer_.<br/>
    /// - The breakdown of what the invoice is for; the _line items_.<br/>
    /// - Any <a href="https://docs.codat.io/accounting-api#/schemas/Payment">payments</a> assigned to the invoice; the _payment allocations_.<br/>
    /// <br/>
    /// &gt; **Invoice PDF downloads**  <br/>
    /// &gt;<br/>
    /// &gt; You can &lt;a className=&quot;external&quot; href=&quot;https://docs.codat.io/accounting-api#/operations/get-invoice-pdf&quot; target=&quot;_blank&quot;&gt;download a PDF version&lt;/a&gt; of an invoice for supported integrations.<br/>
    /// &gt; <br/>
    /// &gt; The filename will be invoice-{number}.pdf.<br/>
    /// <br/>
    /// &gt; **Referencing an invoice in Sage 50 and ClearBooks**<br/>
    /// &gt;<br/>
    /// &gt; In Sage 50 and ClearBooks, you may prefer to use the **invoiceNumber** to identify an invoice rather than the invoice **id**. Each time a draft invoice is submitted or printed, the draft **id** becomes void and a submitted invoice with a new **id** exists in its place. In both platforms, the **invoiceNumber** should remain the same.
    /// </remarks>
    /// </summary>
    public class AccountingInvoice
    {

        /// <summary>
        /// Additional tax amount applied to invoice.
        /// </summary>
        [JsonProperty("additionalTaxAmount")]
        public decimal? AdditionalTaxAmount { get; set; }

        /// <summary>
        /// Percentage rate of any additional tax applied to the invoice.
        /// </summary>
        [JsonProperty("additionalTaxPercentage")]
        public decimal? AdditionalTaxPercentage { get; set; }

        /// <summary>
        /// Amount outstanding on the invoice.
        /// </summary>
        [JsonProperty("amountDue")]
        public decimal AmountDue { get; set; } = default!;

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
        /// Percentage rate (from 0 to 100) of discounts applied to the invoice. For example: A 5% discount will return a value of `5`, not `0.05`.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal? DiscountPercentage { get; set; }

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
        [JsonProperty("dueDate")]
        public string? DueDate { get; set; }

        /// <summary>
        /// Identifier for the invoice, unique to the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Friendly reference for the invoice. If available, this appears in the file name of invoice attachments.
        /// </summary>
        [JsonProperty("invoiceNumber")]
        public string? InvoiceNumber { get; set; }

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
        public string IssueDate { get; set; } = default!;

        /// <summary>
        /// An array of line items.
        /// </summary>
        [JsonProperty("lineItems")]
        public List<InvoiceLineItem>? LineItems { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Any additional information about the invoice. Where possible, Codat links to a data field in the accounting platform that is publicly available. This means that the contents of the note field are included when an invoice is emailed from the accounting platform to the customer.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

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
        [JsonProperty("paidOnDate")]
        public string? PaidOnDate { get; set; }

        /// <summary>
        /// An array of payment allocations.
        /// </summary>
        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation>? PaymentAllocations { get; set; }

        /// <summary>
        /// List of references to related Sales orders.
        /// </summary>
        [JsonProperty("salesOrderRefs")]
        public List<AccountingInvoiceSalesOrderReference>? SalesOrderRefs { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the invoice:&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// - `Draft` - Invoice hasn&apos;t been submitted to the supplier. It may be in a pending state or is scheduled for future submission, for example by email.<br/>
        /// - `Submitted` - Invoice is no longer a draft. It has been processed and, or, sent to the customer. In this state, it will impact the ledger. It also has no payments made against it (amountDue == totalAmount).<br/>
        /// - `PartiallyPaid` - The balance paid against the invoice is positive, but less than the total invoice amount (0 &lt; amountDue &lt; totalAmount).<br/>
        /// - `Paid` - Invoice is paid in full. This includes if the invoice has been credited or overpaid (amountDue == 0).<br/>
        /// - `Void` - An invoice can become Void when it&apos;s deleted, refunded, written off, or cancelled. A voided invoice may still be PartiallyPaid, and so all outstanding amounts on voided invoices are removed from the accounts receivable account.
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public InvoiceStatus Status { get; set; } = default!;

        /// <summary>
        /// Total amount of the invoice excluding any taxes.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal? SubTotal { get; set; }

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
        /// Amount of the invoice, inclusive of tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; } = default!;

        /// <summary>
        /// Numerical value of discounts applied to the invoice.
        /// </summary>
        [JsonProperty("totalDiscount")]
        public decimal? TotalDiscount { get; set; }

        /// <summary>
        /// Amount of tax on the invoice.
        /// </summary>
        [JsonProperty("totalTaxAmount")]
        public decimal TotalTaxAmount { get; set; } = default!;

        [JsonProperty("withholdingTax")]
        public List<Items>? WithholdingTax { get; set; }
    }
}