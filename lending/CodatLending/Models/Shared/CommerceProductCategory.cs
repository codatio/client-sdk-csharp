
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
    
    /// <summary>
    /// Product categories are used to classify a group of products together, either by type (e.g. &quot;Furniture&quot;), or sometimes by tax profile.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Explore our <a href="https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&amp;dataType=commerce-productCategories">data coverage</a> for this data type.
    /// </remarks>
    /// </summary>
    public class CommerceProductCategory
    {

        /// <summary>
        /// A collection of parent product categories implicitly ordered with the immediate parent last in the list.
        /// </summary>
        [JsonProperty("ancestorRefs")]
        public List<CommerceRecordRef>? AncestorRefs { get; set; }

        /// <summary>
        /// A boolean indicating whether there are other product categories beneath this one in the hierarchy.
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// The unique identifier of the product category
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the product category
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
    }
}