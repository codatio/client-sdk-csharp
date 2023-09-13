
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
    
    
    /// <summary>
    /// > **Accessing Bank Accounts through Banking API**
    /// 
    /// <remarks>
    /// > 
    /// > This datatype was originally used for accessing bank account data both in accounting integrations and open banking aggregators. 
    /// > 
    /// > To view bank account data through the Banking API, please refer to the new datatype [here](https://docs.codat.io/banking-api#/schemas/Account)
    /// 
    /// > View the coverage for bank accounts in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// A list of bank accounts associated with a company and a specific data connection.
    /// 
    /// Bank accounts data includes:
    /// * The name and ID of the account in the accounting platform.
    /// * The currency and balance of the account.
    /// * The sort code and account number.
    /// </remarks>
    /// </summary>
    public class AccountingBankAccount
    {
        /// <summary>
        /// Name of the bank account in the accounting platform.
        /// </summary>
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
        
        /// <summary>
        /// Account number for the bank account.
        /// 
        /// <remarks>
        /// 
        /// Xero integrations
        /// Only a UK account number shows for bank accounts with GBP currency and a combined total of sort code and account number that equals 14 digits, For non-GBP accounts, the full bank account number is populated.
        /// 
        /// FreeAgent integrations
        /// For Credit accounts, only the last four digits are required. For other types, the field is optional.
        /// </remarks>
        /// </summary>
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }
        
        /// <summary>
        /// The type of transactions and balances on the account.  
        /// 
        /// <remarks>
        /// For Credit accounts, positive balances are liabilities, and positive transactions **reduce** liabilities.  
        /// For Debit accounts, positive balances are assets, and positive transactions **increase** assets.
        /// </remarks>
        /// </summary>
        [JsonProperty("accountType")]
        public AccountingBankAccountType? AccountType { get; set; }
        
        /// <summary>
        /// Total available balance of the bank account as reported by the underlying data source. This may take into account overdrafts or pending transactions for example.
        /// </summary>
        [JsonProperty("availableBalance")]
        public float? AvailableBalance { get; set; }
        
        /// <summary>
        /// Balance of the bank account.
        /// </summary>
        [JsonProperty("balance")]
        public float? Balance { get; set; }
        
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
        /// International bank account number of the account. Often used when making or receiving international payments.
        /// </summary>
        [JsonProperty("iBan")]
        public string? IBan { get; set; }
        
        /// <summary>
        /// Identifier for the account, unique for the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// The institution of the bank account.
        /// </summary>
        [JsonProperty("institution")]
        public string? Institution { get; set; }
        
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Code used to identify each nominal account for a business.
        /// </summary>
        [JsonProperty("nominalCode")]
        public string? NominalCode { get; set; }
        
        /// <summary>
        /// Pre-arranged overdraft limit of the account.
        /// 
        /// <remarks>
        /// 
        /// The value is always positive. For example, an overdraftLimit of `1000` means that the balance of the account can go down to `-1000`.
        /// </remarks>
        /// </summary>
        [JsonProperty("overdraftLimit")]
        public float? OverdraftLimit { get; set; }
        
        /// <summary>
        /// Sort code for the bank account.
        /// 
        /// <remarks>
        /// 
        /// Xero integrations
        /// The sort code is only displayed when the currency = GBP and the sort code and account number sum to 14 digits. For non-GBP accounts, this field is not populated.
        /// </remarks>
        /// </summary>
        [JsonProperty("sortCode")]
        public string? SortCode { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
    }
    
}