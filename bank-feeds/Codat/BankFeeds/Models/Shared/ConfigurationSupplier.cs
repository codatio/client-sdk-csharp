//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ConfigurationSupplier
    {

        /// <summary>
        /// Unique identifier for the supplier.
        /// </summary>
        [JsonProperty("selectedSupplierId")]
        public string? SelectedSupplierId { get; set; }

        [JsonProperty("supplierOptions")]
        public List<ConfigurationContactRef>? SupplierOptions { get; set; }
    }
}