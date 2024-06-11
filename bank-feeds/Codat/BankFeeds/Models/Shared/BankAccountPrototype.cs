//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    
    public class BankAccountPrototype
    {

        /// <summary>
        /// Name of the bank account in the accounting platform.
        /// </summary>
        [JsonProperty("accountName")]
        public string? AccountName { get; set; } = null;

        /// <summary>
        /// Account number for the bank account.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Xero integrations<br/>
        /// Only a UK account number shows for bank accounts with GBP currency and a combined total of sort code and account number that equals 14 digits, For non-GBP accounts, the full bank account number is populated.<br/>
        /// <br/>
        /// FreeAgent integrations<br/>
        /// For Credit accounts, only the last four digits are required. For other types, the field is optional.
        /// </remarks>
        /// </summary>
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; } = null;

        /// <summary>
        /// The type of transactions and balances on the account.  <br/>
        /// 
        /// <remarks>
        /// For Credit accounts, positive balances are liabilities, and positive transactions **reduce** liabilities.  <br/>
        /// For Debit accounts, positive balances are assets, and positive transactions **increase** assets.
        /// </remarks>
        /// </summary>
        [JsonProperty("accountType")]
        public BankAccountType? AccountType { get; set; }

        /// <summary>
        /// Total available balance of the bank account as reported by the underlying data source. This may take into account overdrafts or pending transactions for example.
        /// </summary>
        [JsonProperty("availableBalance")]
        public decimal? AvailableBalance { get; set; } = null;

        /// <summary>
        /// Balance of the bank account.
        /// </summary>
        [JsonProperty("balance")]
        public decimal? Balance { get; set; } = null;

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
        /// International bank account number of the account. Often used when making or receiving international payments.
        /// </summary>
        [JsonProperty("iBan")]
        public string? IBan { get; set; } = null;

        /// <summary>
        /// The institution of the bank account.
        /// </summary>
        [JsonProperty("institution")]
        public string? Institution { get; set; } = null;

        /// <summary>
        /// Code used to identify each nominal account for a business.
        /// </summary>
        [JsonProperty("nominalCode")]
        public string? NominalCode { get; set; } = null;

        /// <summary>
        /// Pre-arranged overdraft limit of the account.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// The value is always positive. For example, an overdraftLimit of `1000` means that the balance of the account can go down to `-1000`.
        /// </remarks>
        /// </summary>
        [JsonProperty("overdraftLimit")]
        public decimal? OverdraftLimit { get; set; } = null;

        /// <summary>
        /// Sort code for the bank account.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Xero integrations<br/>
        /// The sort code is only displayed when the currency = GBP and the sort code and account number sum to 14 digits. For non-GBP accounts, this field is not populated.
        /// </remarks>
        /// </summary>
        [JsonProperty("sortCode")]
        public string? SortCode { get; set; } = null;

        /// <summary>
        /// Status of the bank account.
        /// </summary>
        [JsonProperty("status")]
        public BankAccountStatus? Status { get; set; }
    }
}