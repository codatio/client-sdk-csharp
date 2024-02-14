
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class TaxRateMapping
    {

        /// <summary>
        /// Selected tax rate id from the list of tax rates on the accounting software.
        /// </summary>
        [JsonProperty("selectedAccountingTaxRateId")]
        public string? SelectedAccountingTaxRateId { get; set; }

        /// <summary>
        /// Selected tax component id from the list of tax components on the commerce software.
        /// </summary>
        [JsonProperty("selectedCommerceTaxRateIds")]
        public List<string>? SelectedCommerceTaxRateIds { get; set; }
    }
}