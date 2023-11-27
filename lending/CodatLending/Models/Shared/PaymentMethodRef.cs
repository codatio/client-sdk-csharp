
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// The payment method the record is linked to in the accounting or commerce platform.
    /// </summary>
    public class PaymentMethodRef
    {

        /// <summary>
        /// The unique identifier of the location being referenced.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the location being referenced.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}