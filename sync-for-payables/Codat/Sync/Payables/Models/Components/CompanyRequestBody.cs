//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    
    public class CompanyRequestBody
    {

        /// <summary>
        /// Name of company being connected.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional information about the company. This can be used to store foreign IDs, references, etc.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A collection of user-defined key-value pairs that store custom metadata against the company.
        /// </summary>
        [JsonProperty("tags")]
        public Tags? Tags { get; set; }
    }
}