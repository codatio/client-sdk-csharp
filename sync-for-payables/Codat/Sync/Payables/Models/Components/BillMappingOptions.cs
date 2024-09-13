//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The bill mapping options for a company&apos;s accounting software.
    /// </summary>
    public class BillMappingOptions
    {

        [JsonProperty("accounts")]
        public List<AccountMappingOption>? Accounts { get; set; }

        [JsonProperty("taxRate")]
        public List<TaxRateMappingOption>? TaxRate { get; set; }

        [JsonProperty("pagination")]
        public Pagination? Pagination { get; set; }
    }
}