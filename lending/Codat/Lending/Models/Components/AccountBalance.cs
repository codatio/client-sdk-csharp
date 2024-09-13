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
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    
    public class AccountBalance
    {

        /// <summary>
        /// The account&apos;s current balance
        /// </summary>
        [JsonProperty("available")]
        public decimal? Available { get; set; }

        /// <summary>
        /// Funds that are not yet available in the balance
        /// </summary>
        [JsonProperty("pending")]
        public decimal? Pending { get; set; }

        /// <summary>
        /// Funds reserved as holdings
        /// </summary>
        [JsonProperty("reserved")]
        public object? Reserved { get; set; }

        /// <summary>
        /// The currency of the account
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }
    }
}