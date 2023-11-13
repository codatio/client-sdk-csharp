
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
    /// &gt; **Language tip:**  Direct incomes may also be referred to as **Receive transactions**, **Receive money transactions**, **Sales receipts**, or **Cash sales** in various accounting platforms.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// &gt; View the coverage for direct incomes in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=directIncomes&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// Direct incomes are incomes received directly from the business&apos; operations. For example, cash sales of items to a customer, referral commissions, and service fee refunds are considered direct incomes.<br/>
    /// <br/>
    /// Direct incomes include: <br/>
    /// <br/>
    /// - Selling an item directly to a contact, and receiving payment at the point of the sale.<br/>
    /// - Refunding an item in cash to a contact.<br/>
    /// - Depositing money into a bank account.<br/>
    /// <br/>
    /// Direct incomes is a child data type of <a href="https://docs.codat.io/lending-api#/schemas/AccountTransaction">account transactions</a>.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class AccountingDirectIncome
    {

        /// <summary>
        /// A customer or supplier associated with the direct cost.
        /// </summary>
        [JsonProperty("contactRef")]
        public ContactRef? ContactRef { get; set; }

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
        public string Currency { get; set; } = default!;

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

        /// <summary>
        /// Identifier of the direct income, unique for the company.
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
        public string IssueDate { get; set; } = default!;

        /// <summary>
        /// An array of line items.
        /// </summary>
        [JsonProperty("lineItems")]
        public List<DirectIncomeLineItem> LineItems { get; set; } = default!;

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// An optional note on the direct income that can be used to assign the direct income with a reference ID in your application.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation> PaymentAllocations { get; set; } = default!;

        /// <summary>
        /// User-friendly reference for the direct income.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// The total amount of the direct incomes, excluding any taxes.
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
        /// The total amount of tax on the direct incomes.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; } = default!;

        /// <summary>
        /// The amount of the direct incomes, inclusive of tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; } = default!;
    }
}