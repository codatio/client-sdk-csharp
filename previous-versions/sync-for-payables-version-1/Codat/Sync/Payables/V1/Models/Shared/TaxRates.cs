//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class TaxRates
    {

        [JsonProperty("_links")]
        public Links Links { get; set; } = default!;

        /// <summary>
        /// Current page number.
        /// </summary>
        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; } = default!;

        /// <summary>
        /// Number of items to return in results array.
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = default!;

        [JsonProperty("results")]
        public List<TaxRate>? Results { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        [JsonProperty("totalResults")]
        public long TotalResults { get; set; } = default!;
    }
}