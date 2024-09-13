//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    
    /// <summary>
    /// Routing information for the bank. This does not include account number.
    /// </summary>
    public class RoutingInfo
    {

        /// <summary>
        /// The numeric identifier of the routing number
        /// </summary>
        [JsonProperty("bankCode")]
        public string? BankCode { get; set; } = null;

        /// <summary>
        /// The type of routing number.
        /// </summary>
        [JsonProperty("type")]
        public Models.Shared.Type? Type { get; set; } = Codat.BankFeeds.Models.Shared.Type.Bankcode;
    }
}