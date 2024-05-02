
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class Customers
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
        public List<Customer>? Results { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        [JsonProperty("totalResults")]
        public long TotalResults { get; set; } = default!;
    }
}