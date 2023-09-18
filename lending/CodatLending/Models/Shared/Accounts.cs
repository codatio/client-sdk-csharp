
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
    
    public class Accounts
    {

        /// <summary>
        /// The name of the account according to the provider.
        /// </summary>
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }

        /// <summary>
        /// The bank or other financial institution providing the account.
        /// </summary>
        [JsonProperty("accountProvider")]
        public string? AccountProvider { get; set; }

        /// <summary>
        /// The type of banking account, e.g. credit or debit.
        /// </summary>
        [JsonProperty("accountType")]
        public string? AccountType { get; set; }

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
        /// The balance of the bank account.
        /// </summary>
        [JsonProperty("currentBalance")]
        public decimal? CurrentBalance { get; set; }

        /// <summary>
        /// Name of the banking data source, e.g. &amp;quot;Plaid&amp;quot;.
        /// </summary>
        [JsonProperty("platformName")]
        public string? PlatformName { get; set; }

        /// <summary>
        /// A source reference containing the `sourceType` object &amp;quot;Banking&amp;quot;.
        /// </summary>
        [JsonProperty("sourceRef")]
        public SourceRef? SourceRef { get; set; }
    }
}