
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
    /// > **Invoices or bills?**
    /// 
    /// <remarks>
    /// >
    /// > We distinguish between invoices where the company *owes money* vs. *is owed money*. If the company has received an invoice, and owes money to someone else (accounts payable) we call this a Bill.
    /// >
    /// > See [Invoices](https://docs.codat.io/accounting-api#/schemas/Invoice) for the accounts receivable equivalent of bills.
    /// 
    /// View the coverage for bills in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// In Codat, a bill contains details of:
    /// * When the bill was recorded in the accounting system.
    /// * How much the bill is for and the currency of the amount.
    /// * Who the bill was received from — the *supplier*.
    /// * What the bill is for — the *line items*.
    /// 
    /// Some accounting platforms give a separate name to purchases where the payment is made immediately, such as something bought with a credit card or online payment. One example of this would be QuickBooks Online's *expenses*.
    /// 
    /// You can find these types of transactions in our [Direct costs](https://docs.codat.io/accounting-api#/schemas/DirectCost) data model.
    /// </remarks>
    /// </summary>
    public class AccountingBill
    {
        /// <summary>
        /// Amount outstanding on the bill.
        /// </summary>
        [JsonProperty("amountDue")]
        public decimal? AmountDue { get; set; }
        
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
        public List<AccountingBillPurchaseOrderReference>? PurchaseOrderRefs { get; set; }
        
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
        public List<AccountingBillWithholdingTax>? WithholdingTax { get; set; }
        
    }
    
}