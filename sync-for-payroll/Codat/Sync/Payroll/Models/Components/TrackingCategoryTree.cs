//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Models.Components
{
    using Codat.Sync.Payroll.Models.Components;
    using Codat.Sync.Payroll.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The full structure of a specific tracking category including any child or subcategories.
    /// </summary>
    public class TrackingCategoryTree
    {

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// The identifier for the item, unique per tracking category
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name of the tracking category
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Current state of the tracking category.
        /// </summary>
        [JsonProperty("status")]
        public DefinitionStatus? Status { get; set; }

        /// <summary>
        /// The identifier for this item&apos;s immediate parent
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; } = null;

        /// <summary>
        /// Boolean value indicating whether this category has SubCategories
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// A collection of subcategories that are nested beneath this category.
        /// </summary>
        [JsonProperty("subCategories")]
        public List<TrackingCategoryTree>? SubCategories { get; set; } = null;

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
    }
}