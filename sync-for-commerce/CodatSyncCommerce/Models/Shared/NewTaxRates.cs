
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class NewTaxRates
    {

        /// <summary>
        /// Array of accounting tax rate options.
        /// </summary>
        [JsonProperty("accountingTaxRateOptions")]
        public List<Option>? AccountingTaxRateOptions { get; set; }

        /// <summary>
        /// Array of tax component options.
        /// </summary>
        [JsonProperty("commerceTaxRateOptions")]
        public List<Option>? CommerceTaxRateOptions { get; set; }

        /// <summary>
        /// Default zero tax rate selected for sync.
        /// </summary>
        [JsonProperty("defaultZeroTaxRateOptions")]
        public List<Option>? DefaultZeroTaxRateOptions { get; set; }

        /// <summary>
        /// Default tax rate selected for sync.
        /// </summary>
        [JsonProperty("selectedDefaultZeroTaxRateId")]
        public string? SelectedDefaultZeroTaxRateId { get; set; }

        /// <summary>
        /// Array of tax component to rate mapppings.
        /// </summary>
        [JsonProperty("taxRateMappings")]
        public List<TaxRateMapping>? TaxRateMappings { get; set; }
    }
}