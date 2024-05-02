
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
    /// </summary>
    public class AccountRef
    {

        /// <summary>
        /// &apos;id&apos; from the Accounts data type.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// &apos;name&apos; from the Accounts data type.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}