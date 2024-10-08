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
    
    public class DataIntegrityStatus
    {

        /// <summary>
        /// The data type which the data type in the URL has been matched against. For example, if you&apos;ve matched accountTransactions and banking-transactions, and you call this endpoint with accountTransactions in the URL, this property would be banking-transactions.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("statusInfo")]
        public DataIntegrityStatusInfo? StatusInfo { get; set; }

        [JsonProperty("connectionIds")]
        public DataIntegrityConnectionId? ConnectionIds { get; set; }

        /// <summary>
        /// Only returned for transactions. For accounts, there is nothing returned.
        /// </summary>
        [JsonProperty("amounts")]
        public DataIntegrityAmounts? Amounts { get; set; }

        /// <summary>
        /// Only returned for transactions. For accounts, there is nothing returned.
        /// </summary>
        [JsonProperty("dates")]
        public DataIntegrityDates? Dates { get; set; }
    }
}