
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    
    
    public class CompanyConfiguration
    {
        [JsonProperty("bankAccount")]
        public BankAccount BankAccount { get; set; } = default!;
        
        [JsonProperty("customer")]
        public Customer Customer { get; set; } = default!;
        
        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; } = default!;
        
    }
    
}