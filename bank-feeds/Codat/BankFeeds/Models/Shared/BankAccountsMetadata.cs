//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    
    public class BankAccountsMetadata
    {

        /// <summary>
        /// Indicates whether the record has been deleted in the third-party system this record originated from.
        /// </summary>
        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; } = null;
    }
}