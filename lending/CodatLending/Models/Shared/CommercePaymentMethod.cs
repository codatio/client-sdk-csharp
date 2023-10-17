
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
    /// A Payment Method represents the payment method(s) used to make payments.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Explore our <a href="https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&amp;dataType=commerce-paymentMethods">data coverage</a> for this data type.
    /// </remarks>
    /// </summary>
    public class CommercePaymentMethod
    {

        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the PaymentMethod
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Status of the Payment Method.
        /// </summary>
        [JsonProperty("status")]
        public CommercePaymentMethodStatus? Status { get; set; }
    }
}