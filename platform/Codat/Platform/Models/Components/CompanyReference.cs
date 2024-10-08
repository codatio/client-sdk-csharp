//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Components
{
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    public class CompanyReference
    {

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the company
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional information about the company. This can be used to store foreign IDs, references, etc.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}