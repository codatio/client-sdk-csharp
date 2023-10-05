
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
    
    public class DataIntegritySummary
    {

        [JsonProperty("byAmount")]
        public DataIntegrityByAmount? ByAmount { get; set; }

        [JsonProperty("byCount")]
        public DataIntegrityByCount? ByCount { get; set; }

        /// <summary>
        /// The data type which the data type in the URL has been matched against. For example, if you&apos;ve matched accountTransactions and banking-transactions, and you call this endpoint with accountTransactions in the URL, this property would be banking-transactions.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}