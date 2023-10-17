
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The full structure of a specific tracking category including any child or subcategories.
    /// </summary>
    public class TrackingCategoryTree
    {

        /// <summary>
        /// Boolean value indicating whether this category has SubCategories
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// The identifier for the item, unique per tracking category
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the tracking category
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The identifier for this item&apos;s immediate parent
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the tracking category.
        /// </summary>
        [JsonProperty("status")]
        public Status? Status { get; set; }

        /// <summary>
        /// A collection of subcategories that are nested beneath this category.
        /// </summary>
        [JsonProperty("subCategories")]
        public List<TrackingCategoryTree>? SubCategories { get; set; }
    }
}