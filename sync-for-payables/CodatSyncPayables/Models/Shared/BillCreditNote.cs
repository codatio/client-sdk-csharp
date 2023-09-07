
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    
    /// <summary>
    /// > **Bill credit notes or credit notes?**
    /// 
    /// <remarks>
    /// > 
    /// > In Codat, bill credit notes represent accounts payable only. For accounts receivable, see [Credit notes](https://docs.codat.io/accounting-api#/schemas/CreditNote).
    /// 
    /// View the coverage for bill credit notes in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// A bill credit note is issued by a supplier for the purpose of recording credit. For example, if a supplier was unable to fulfil an order that was placed by a business, or delivered damaged goods, they would issue a bill credit note. A bill credit note reduces the amount a business owes to the supplier. It can be refunded to the business or used to pay off future bills.
    /// 
    /// In the Codat API, a bill credit note is an accounts payable record issued by a [supplier](https://docs.codat.io/accounting-api#/schemas/Supplier). 
    /// 
    /// A bill credit note includes details of:
    /// * The original and remaining credit.
    /// * Any allocations of the credit against other records, such as [bills](https://docs.codat.io/accounting-api#/schemas/Bill).
    /// * The supplier that issued the bill credit note.
    /// </remarks>
    /// </summary>
    public class BillCreditNote
    {
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
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
        /// The currency data type in Codat is the [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code, e.g. _GBP_.
        /// 
        /// <remarks>
        /// 
        /// ## Unknown currencies
        /// 
        /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. 
        /// 
        /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
        /// </remarks>
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }
        
        /// <summary>
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.
        /// 
        /// <remarks>
        /// 
        /// Currency rates in Codat are implemented as the multiple of foreign currency units to each base currency unit.  
        /// 
        /// It is not possible to perform the currency conversion with two or more non-base currencies participating in the transaction. For example, if a company's base currency is USD, and it has a bill issued in EUR, then the bill payment must happen in USD or EUR.
        /// 
        /// Where the currency rate is provided by the underlying accounting platform, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). 
        /// 
        /// For accounting platforms which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.
        /// 
        /// ## Examples with base currency of GBP
        /// 
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (GBP) |
        /// | :--------------- | :------------- | :------------ | :------------------------- |
        /// | **USD**          | $20            | 0.781         | £15.62                     |
        /// | **EUR**          | €20            | 0.885         | £17.70                     |
        /// | **RUB**          | ₽20            | 0.011         | £0.22                      |
        /// 
        /// ## Examples with base currency of USD
        /// 
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (USD) |
        /// | :--------------- | :------------- | :------------ | :------------------------- |
        /// | **GBP**          | £20            | 1.277         | $25.54                     |
        /// | **EUR**          | €20            | 1.134         | $22.68                     |
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }
        
        /// <summary>
        /// Percentage rate of any discount applied to the bill credit note.
        /// </summary>
        [JsonProperty("discountPercentage")]
        public decimal DiscountPercentage { get; set; }
        
        /// <summary>
        /// Identifier for the bill credit note that is unique to a company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
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
        public List<Items>? PaymentAllocations { get; set; }
        
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
        public BillCreditNoteStatus Status { get; set; }
        
        /// <summary>
        /// Total amount of the bill credit note, including discounts but excluding tax.
        /// </summary>
        [JsonProperty("subTotal")]
        public decimal SubTotal { get; set; }
        
        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. 
        /// 
        /// <remarks>
        /// 
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. [Learn more](https://docs.codat.io/using-the-api/supplemental-data/overview) about supplemental data.
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
        /// Total amount of credit that has been applied to the business' account with the supplier, including discounts and tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }
        
        /// <summary>
        /// Total value of any discounts applied.
        /// </summary>
        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount { get; set; }
        
        /// <summary>
        /// Amount of tax included in the bill credit note.
        /// </summary>
        [JsonProperty("totalTaxAmount")]
        public decimal TotalTaxAmount { get; set; }
        
        [JsonProperty("withholdingTax")]
        public List<WithholdingTaxitems>? WithholdingTax { get; set; }
        
    }
    
}