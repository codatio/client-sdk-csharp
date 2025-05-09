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
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; **Language tip:** In Codat, account transactions represent all transactions posted to a bank account within an accounting software. For bank transactions posted within a banking platform, refer to <a href="https://docs.codat.io/lending-api#/operations/list-all-banking-transactions">Banking transactions</a>.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// In Codat’s data model, account transactions represent bank activity within an accounting software. All transactions that go through a bank account are recorded as account transactions.<br/>
    /// <br/>
    /// Account transactions are created as a result of different business activities, for example:<br/>
    /// <br/>
    /// * Payments: for example, receiving money for payment against an invoice.<br/>
    /// * Bill payments: for example, spending money for a payment against a bill.<br/>
    /// * Direct costs: for example, withdrawing money from a bank account, either for cash purposes or to make a payment.<br/>
    /// * Direct incomes: for example, selling an item directly to a contact and receiving payment at point of sale.<br/>
    /// * Transfers: for example, transferring money between two bank accounts.<br/>
    /// <br/>
    /// Account transactions is the parent data type of <a href="https://docs.codat.io/lending-api#/schemas/Payment">payments</a>, <a href="https://docs.codat.io/lending-api#/schemas/BillPayment">bill payments</a>, <a href="https://docs.codat.io/lending-api#/schemas/DirectCost">direct costs</a>, <a href="https://docs.codat.io/lending-api#/schemas/DirectIncome">direct incomes</a>, and <a href="https://docs.codat.io/lending-api#/schemas/Transfer">transfers</a>.
    /// </remarks>
    /// </summary>
    public class AccountingAccountTransaction
    {

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Identifier of the direct cost (unique to the company).
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of the transaction (unique to the company).
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; } = null;

        /// <summary>
        /// Additional information about the account transaction, if available.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; } = null;

        /// <summary>
        /// Links to the Account transactions data type.
        /// </summary>
        [JsonProperty("bankAccountRef")]
        public BankAccountRef? BankAccountRef { get; set; }

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
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// The status of the account transaction.
        /// </summary>
        [JsonProperty("status")]
        public AccountingAccountTransactionStatus? Status { get; set; }

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
        /// Where the currency rate is provided by the underlying accounting software, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). <br/>
        /// <br/>
        /// For accounting software which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.<br/>
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
        /// | QuickBooks Online | Transaction currency differs from base currency | If currency rate value is left `null`, a rate of 1 will be used by QBO by default. To override this, specify a currencyRate in the request body.  |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; } = null;

        /// <summary>
        /// Array of account transaction lines.
        /// </summary>
        [JsonProperty("lines")]
        public List<AccountTransactionLine>? Lines { get; set; } = null;

        /// <summary>
        /// Total amount of the account transactions, inclusive of tax.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
    }
}