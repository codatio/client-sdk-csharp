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
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Reference to the item the line is linked to.
    /// </summary>
    public class ItemRef
    {

        /// <summary>
        /// Unique identifier for the item in the accounting software.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the item in the accounting software.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;
    }
}