
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
    /// An object containing bank account identification information.
    /// </summary>
    public class AccountIdentifiers
    {

        /// <summary>
        /// The local (usually national) routing number for the account.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// This is known by different names in different countries:<br/>
        /// * BSB code (Australia)<br/>
        /// * routing number (Canada, USA)<br/>
        /// * sort code (UK)
        /// </remarks>
        /// </summary>
        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        /// <summary>
        /// The ISO 9362 code (commonly called SWIFT code, SWIFT-BIC or BIC) for the account.
        /// </summary>
        [JsonProperty("bic")]
        public string? Bic { get; set; }

        /// <summary>
        /// The international bank account number (IBAN) for the account, if known.
        /// </summary>
        [JsonProperty("iban")]
        public string? Iban { get; set; }

        /// <summary>
        /// A portion of the actual account `number` to help account identification where number is tokenised (Plaid only)
        /// </summary>
        [JsonProperty("maskedAccountNumber")]
        public string? MaskedAccountNumber { get; set; }

        /// <summary>
        /// The account number for the account. When combined with the`bankCode`, this is usually enough to uniquely identify an account within a jurisdiction.
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// Detailed account category
        /// </summary>
        [JsonProperty("subtype")]
        public string? Subtype { get; set; }

        /// <summary>
        /// Type of account
        /// </summary>
        [JsonProperty("type")]
        public AccountIdentifierType Type { get; set; } = default!;
    }
}