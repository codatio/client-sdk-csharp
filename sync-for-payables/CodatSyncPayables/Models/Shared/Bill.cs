
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; **Invoices or bills?**<br/>
    /// 
    /// <remarks>
    /// &gt;<br/>
    /// &gt; We distinguish between invoices where the company *owes money* vs. *is owed money*. If the company has received an invoice, and owes money to someone else (accounts payable) we call this a Bill.<br/>
    /// &gt;<br/>
    /// &gt; See <a href="https://docs.codat.io/sync-for-payables-api#/schemas/Invoice">Invoices</a> for the accounts receivable equivalent of bills.<br/>
    /// <br/>
    /// View the coverage for bills in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=bills&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// In Codat, a bill contains details of:<br/>
    /// * When the bill was recorded in the accounting system.<br/>
    /// * How much the bill is for and the currency of the amount.<br/>
    /// * Who the bill was received from — the *supplier*.<br/>
    /// * What the bill is for — the *line items*.<br/>
    /// <br/>
    /// Some accounting platforms give a separate name to purchases where the payment is made immediately, such as something bought with a credit card or online payment. One example of this would be QuickBooks Online&apos;s *expenses*.<br/>
    /// <br/>
    /// You can find these types of transactions in our <a href="https://docs.codat.io/sync-for-payables-api#/schemas/DirectCost">Direct costs</a> data model.
    /// </remarks>
    /// </summary>
    public class Bill
    {

        /// <summary>
        /// Amount outstanding on the bill.
        /// </summary>
        [JsonProperty("amountDue")]
        public decimal? AmountDue { get; set; }

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
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }

        [JsonProperty("dueDate")]
        public string? DueDate { get; set; }

        /// <summary>
        /// Identifier for the bill, unique for the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; } = default!;

        /// <summary>
        /// Array of Bill line items.
        /// </summary>
        [JsonProperty("lineItems")]
        public List<BillLineItem>? LineItems { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Any private, company notes about the bill, such as payment information.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// An array of payment allocations.
        /// </summary>
        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation>? PaymentAllocations { get; set; }

        [JsonProperty("purchaseOrderRefs")]
        public List<PurchaseOrderReference>? PurchaseOrderRefs { get; set; }

        /// <summary>
        /// User-friendly reference for the bill.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the bill.
        /// </summary>
        [JsonProperty("status")]
        public BillStatus Status { get; set; } = default!;

        /// <summary>
        /// Total amount of the bill, excluding any taxes.
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
        /// Amount of tax on the bill.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; } = default!;

        /// <summary>
        /// Amount of the bill, including tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; } = default!;

        [JsonProperty("withholdingTax")]
        public List<WithholdingTax>? WithholdingTax { get; set; }
    }
}