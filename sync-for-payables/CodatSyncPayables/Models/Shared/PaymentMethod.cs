
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// > View the coverage for payment methods in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=paymentMethods" target="_blank">Data coverage explorer</a>.
    /// 
    /// <remarks>
    /// 
    /// ## Overview
    /// 
    /// A Payment Method represents the payment method(s) used to pay a Bill. Payment Methods are referenced on [Bill Payments](https://docs.codat.io/accounting-api#/schemas/BillPayment) and [Payments](https://docs.codat.io/accounting-api#/schemas/Payment).
    /// </remarks>
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Unique identifier for the payment method.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Name of the payment method.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// Status of the Payment Method.
        /// </summary>
        [JsonProperty("status")]
        public PaymentMethodStatus? Status { get; set; }
        
        /// <summary>
        /// Method of payment.
        /// </summary>
        [JsonProperty("type")]
        public PaymentMethodType? Type { get; set; }
        
    }
    
}