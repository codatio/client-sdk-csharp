
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
    /// > **Language tip:**  Direct incomes may also be referred to as **Receive transactions**, **Receive money transactions**, **Sales receipts**, or **Cash sales** in various accounting platforms.
    /// 
    /// <remarks>
    /// 
    /// > View the coverage for direct incomes in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directIncomes" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// Direct incomes are incomes received directly from the business' operations. For example, cash sales of items to a customer, referral commissions, and service fee refunds are considered direct incomes.
    /// 
    /// Direct incomes include: 
    /// 
    /// - Selling an item directly to a contact, and receiving payment at the point of the sale.
    /// - Refunding an item in cash to a contact.
    /// - Depositing money into a bank account.
    /// 
    /// Direct incomes is a child data type of [account transactions](https://docs.codat.io/accounting-api#/schemas/AccountTransaction).
    /// 
    /// </remarks>
    /// </summary>
    public class AccountingDirectIncome
    {
        /// <summary>
        /// The customer or supplier for the transfer, if available.
        /// </summary>
        [JsonProperty("contactRef")]
        public ContactRef? ContactRef { get; set; }
        
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
        public string Currency { get; set; }
        
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
        /// Identifier of the direct income, unique for the company.
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
        public string IssueDate { get; set; }
        
        /// <summary>
        /// An array of line items.
        /// </summary>
        [JsonProperty("lineItems")]
        public List<DirectIncomeLineItem> LineItems { get; set; }
        
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        [JsonProperty("note")]
        public string? Note { get; set; }
        
        [JsonProperty("paymentAllocations")]
        public List<AccountingPaymentAllocation> PaymentAllocations { get; set; }
        
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
        /// The total amount of tax on the direct incomes.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }
        
        /// <summary>
        /// The amount of the direct incomes, inclusive of tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }
        
    }
    
}