
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
    
    public class InvoiceLineLevelSelection
    {

        /// <summary>
        /// Options for grouping on invoice lines.
        /// </summary>
        [JsonProperty("groupByOptions")]
        public List<string>? GroupByOptions { get; set; }

        /// <summary>
        /// Invoice line level selection.
        /// </summary>
        [JsonProperty("selectedGroupByOptions")]
        public List<string>? SelectedGroupByOptions { get; set; }
    }
}