
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
    /// The bank or other financial institution providing the account.
    /// </summary>
    public class AccountInstitution
    {

        /// <summary>
        /// The institution&amp;apos;s ID, according to the provider.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The institution&amp;apos;s name, according to the underlying provider.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}