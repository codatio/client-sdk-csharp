
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Shared
{
    using Newtonsoft.Json;
    
    
    public class TargetAccountOption
    {
        /// <summary>
        /// The account number of the account.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }
        
        /// <summary>
        /// The balance of the account.
        /// </summary>
        [JsonProperty("balance")]
        public float? Balance { get; set; }
        
        /// <summary>
        /// Id of the target account.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Name of the target account.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// The sort code of the account.
        /// </summary>
        [JsonProperty("sortCode")]
        public string? SortCode { get; set; }
        
    }
    
}