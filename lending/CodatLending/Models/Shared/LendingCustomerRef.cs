
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
    
    
    public class LendingCustomerRef
    {
        /// <summary>
        /// `customerName` from the Customer data type
        /// </summary>
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }
        
        /// <summary>
        /// `id` from the Customers data type
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
    }
    
}