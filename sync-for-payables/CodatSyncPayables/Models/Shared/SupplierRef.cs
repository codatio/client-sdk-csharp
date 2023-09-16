
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
    
    /// <summary>
    /// Reference to the supplier the record relates to.
    /// </summary>
    public class SupplierRef
    {

        /// <summary>
        /// The supplier&amp;apos;s unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The supplier&amp;apos;s name
        /// </summary>
        [JsonProperty("supplierName")]
        public string? SupplierName { get; set; }
    }
}