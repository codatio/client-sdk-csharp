
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ReimbursableExpenseTransaction
    {

        [JsonProperty("bankAccountRef")]
        public BankAccountReference? BankAccountRef { get; set; }

        [JsonProperty("contactRef")]
        public ContactRefReimbursableExpense ContactRef { get; set; } = default!;

        /// <summary>
        /// Currency the transaction was recorded in.
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
        public decimal? CurrencyRate { get; set; } = null;

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
        [JsonProperty("dueDate")]
        public string DueDate { get; set; } = default!;

        /// <summary>
        /// Your unique identifier for the transaction.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

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
        /// Array of transaction lines.
        /// </summary>
        [JsonProperty("lines")]
        public List<ReimbursableExpenseTransactionLine>? Lines { get; set; }

        /// <summary>
        /// Any private, company notes about the transaction.
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// User-friendly reference for the reimbursable expense.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; } = null;
    }
}