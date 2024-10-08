//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    public class CompanyConfiguration
    {

        [JsonProperty("bankAccount")]
        public BankAccountDetails BankAccount { get; set; } = default!;

        [JsonProperty("supplier")]
        public SupplierDetails Supplier { get; set; } = default!;

        [JsonProperty("customer")]
        public CustomerDetails Customer { get; set; } = default!;
    }
}