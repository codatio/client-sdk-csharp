
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
    /// > **Language tip:** In Codat, account transactions represent all transactions posted to a bank account within an accounting platform. For bank transactions posted within a banking platform, refer to [Banking transactions](https://docs.codat.io/banking-api#/operations/list-all-banking-transactions).
    /// 
    /// <remarks>
    /// 
    /// > View the coverage for account transactions in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=accountTransactions" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// In Codat’s data model, account transactions represent bank activity within an accounting platform. All transactions that go through a bank account are recorded as account transactions.
    /// 
    /// Account transactions are created as a result of different business activities, for example:
    /// 
    /// * Payments: for example, receiving money for payment against an invoice.
    /// * Bill payments: for example, spending money for a payment against a bill.
    /// * Direct costs: for example, withdrawing money from a bank account, either for cash purposes or to make a payment.
    /// * Direct incomes: for example, selling an item directly to a contact and receiving payment at point of sale.
    /// * Transfers: for example, transferring money between two bank accounts.
    /// 
    /// Account transactions is the parent data type of [payments](https://docs.codat.io/accounting-api#/schemas/Payment), [bill payments](https://docs.codat.io/accounting-api#/schemas/BillPayment), [direct costs](https://docs.codat.io/accounting-api#/schemas/DirectCost), [direct incomes](https://docs.codat.io/accounting-api#/schemas/DirectIncome), and [transfers](https://docs.codat.io/accounting-api#/schemas/Transfer).
    /// </remarks>
    /// </summary>
    public class AccountingAccountTransaction
    {
        /// <summary>
        /// Links to the Account transactions data type.
        /// </summary>
        [JsonProperty("bankAccountRef")]
        public BankAccountRef? BankAccountRef { get; set; }
        
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
        public float? CurrencyRate { get; set; }
        
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
        [JsonProperty("date")]
        public string? Date { get; set; }
        
        /// <summary>
        /// Identifier of the direct cost (unique to the company).
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Array of account transaction lines.
        /// </summary>
        [JsonProperty("lines")]
        public List<AccountTransactionLine>? Lines { get; set; }
        
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Additional information about the account transaction, if available.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// The status of the account transaction.
        /// </summary>
        [JsonProperty("status")]
        public AccountingAccountTransactionStatus? Status { get; set; }
        
        /// <summary>
        /// Total amount of the account transactions, inclusive of tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public float? TotalAmount { get; set; }
        
        /// <summary>
        /// Identifier of the transaction (unique to the company).
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }
        
    }
    
}