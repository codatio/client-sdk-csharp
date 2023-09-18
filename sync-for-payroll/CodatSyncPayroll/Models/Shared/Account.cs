
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// &amp;gt; **Language tip:** Accounts are also referred to as **chart of accounts**, **nominal accounts**, and **general ledger**.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// View the coverage for accounts in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=chartOfAccounts&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// Accounts are the categories a business uses to record accounting transactions. From the Accounts endpoints, you can retrieve a list of all accounts for a specified company. <br/>
    /// <br/>
    /// The categories for an account include:<br/>
    ///   * Asset<br/>
    ///   * Expense<br/>
    ///   * Income<br/>
    ///   * Liability<br/>
    ///   * Equity.<br/>
    /// <br/>
    /// The same account may have a different category based on the integration it is used in. For example, a current account (known as checking in the US) should be categorized as `Asset.Current` for Xero, and `Asset.Bank.Checking` for QuickBooks Online. <br/>
    /// <br/>
    /// At the same time, each integration may have its own requirements to the categories. For example, a Paypal account in Xero is of the `Asset.Bank` category and therefore requires additional properties to be provided. <br/>
    /// <br/>
    /// To determine the list of allowed categories for a specific integration, you can: <br/>
    /// - Follow our <a href="https://docs.codat.io/using-the-api/push">Create, update, delete data</a> guide and use the <a href="https://docs.codat.io/accounting-api#/operations/get-create-chartOfAccounts-model">Get create account model</a>.<br/>
    /// - Refer to the integration&apos;s own documentation. <br/>
    /// <br/>
    /// &gt; **Accounts with no category**<br/>
    /// &gt; <br/>
    /// &gt; If an account is pulled from the chart of accounts and its nominal code does not lie within the category layout for the company&apos;s accounts, then the **type** is `Unknown`. The **fullyQualifiedCategory** and **fullyQualifiedName** fields return `null`.<br/>
    /// &gt; <br/>
    /// &gt; This approach gives a true representation of the company&apos;s accounts whilst preventing distorting financials such as a company&apos;s profit and loss and balance sheet reports.
    /// </remarks>
    /// </summary>
    public class Account
    {

        /// <summary>
        /// The currency data type in Codat is the &lt;a href=&quot;https://en.wikipedia.org/wiki/ISO_4217&quot;&gt;ISO 4217&lt;/a&gt; currency code, e.g. _GBP_.&lt;br/&gt;
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
        /// Current balance in the account.
        /// </summary>
        [JsonProperty("currentBalance")]
        public decimal? CurrentBalance { get; set; }

        /// <summary>
        /// Description for the account.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Full category of the account. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// For example, `Liability.Current` or `Income.Revenue`. To determine a list of possible categories for each integration, see our examples, follow our <a href="https://docs.codat.io/using-the-api/push">Create, update, delete data</a> guide, or refer to the integration&apos;s own documentation.
        /// </remarks>
        /// </summary>
        [JsonProperty("fullyQualifiedCategory")]
        public string? FullyQualifiedCategory { get; set; }

        /// <summary>
        /// Full name of the account, for example:&lt;br/&gt;
        /// 
        /// <remarks>
        /// - `Cash On Hand`<br/>
        /// - `Rents Held In Trust`<br/>
        /// - `Fixed Asset`
        /// </remarks>
        /// </summary>
        [JsonProperty("fullyQualifiedName")]
        public string? FullyQualifiedName { get; set; }

        /// <summary>
        /// Identifier for the account, unique for the company.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Confirms whether the account is a bank account or not.
        /// </summary>
        [JsonProperty("isBankAccount")]
        public bool? IsBankAccount { get; set; }

        [JsonProperty("metadata")]
        public AccountMetadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Name of the account.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reference given to each nominal account for a business. It ensures money is allocated to the correct account. This code isn&amp;apos;t a unique identifier in the Codat system.
        /// </summary>
        [JsonProperty("nominalCode")]
        public string? NominalCode { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Status of the account
        /// </summary>
        [JsonProperty("status")]
        public AccountStatus? Status { get; set; }

        /// <summary>
        /// Type of account
        /// </summary>
        [JsonProperty("type")]
        public AccountType? Type { get; set; }

        /// <summary>
        /// The validDatatypeLinks can be used to determine whether an account can be correctly mapped to another object; for example, accounts with a `type` of `income` might only support being used on an Invoice and Direct Income. For more information, see &lt;a href=&quot;/accounting-api#/schemas/ValidDataTypeLinks&quot;&gt;Valid Data Type Links&lt;/a&gt;.
        /// </summary>
        [JsonProperty("validDatatypeLinks")]
        public List<AccountValidDataTypeLinks>? ValidDatatypeLinks { get; set; }
    }
}