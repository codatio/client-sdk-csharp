
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
    using System.Collections.Generic;
    
    public class CommerceDisputes
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
        public List<CommerceDispute>? Results { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        [JsonProperty("totalResults")]
        public long TotalResults { get; set; } = default!;
    }
}