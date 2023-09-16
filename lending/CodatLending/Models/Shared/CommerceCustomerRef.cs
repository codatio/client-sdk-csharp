
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
    /// Reference to the customer that placed the order.
    /// </summary>
    public class CommerceCustomerRef
    {

        /// <summary>
        /// The unique identitifer of the customer being referenced
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the customer being referenced.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}