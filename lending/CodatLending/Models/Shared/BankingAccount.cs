
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
    /// This data type provides a list of all the SMB&amp;apos;s bank accounts, with rich data like balances, account numbers, and institutions holding the accounts.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// Explore our <a href="https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&amp;dataType=banking-accounts">data coverage</a>.<br/>
    /// <br/>
    /// Responses are paged, so you should provide `page` and `pageSize` query parameters in your request.
    /// </remarks>
    /// </summary>
    public class BankingAccount
    {

        /// <summary>
        /// Depending on the data provided by the underlying bank, not all balances are always available.
        /// </summary>
        [JsonProperty("balance")]
        public AccountBalanceAmounts Balance { get; set; } = default!;

        /// <summary>
        /// The currency code for the account.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// The name of the person or company who holds the account.
        /// </summary>
        [JsonProperty("holder")]
        public string? Holder { get; set; }

        /// <summary>
        /// The ID of the account from the provider.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An object containing bank account identification information.
        /// </summary>
        [JsonProperty("identifiers")]
        public AccountIdentifiers Identifiers { get; set; } = default!;

        /// <summary>
        /// The friendly name of the account, chosen by the holder. This may not have been set by the account holder and therefore is not always available.
        /// </summary>
        [JsonProperty("informalName")]
        public string? InformalName { get; set; }

        /// <summary>
        /// The bank or other financial institution providing the account.
        /// </summary>
        [JsonProperty("institution")]
        public AccountInstitution Institution { get; set; } = default!;

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the account according to the provider.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// The type of transactions and balances on the account.  &lt;br/&gt;
        /// 
        /// <remarks>
        /// For Credit accounts, positive balances are liabilities, and positive transactions **reduce** liabilities.  <br/>
        /// For Debit accounts, positive balances are assets, and positive transactions **increase** assets.
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public AccountingBankAccountType Type { get; set; } = default!;
    }
}