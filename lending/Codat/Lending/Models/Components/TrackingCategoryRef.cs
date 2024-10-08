//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// References a category against which the item is tracked.
    /// </summary>[Obsolete("This will be removed in a future release, please migrate away from it as soon as possible.")]
    public class TrackingCategoryRef
    {

        /// <summary>
        /// Unique identifier to the tracking category.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of tracking category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;
    }
}