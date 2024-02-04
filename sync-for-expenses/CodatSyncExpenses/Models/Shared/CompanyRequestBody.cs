
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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class CompanyRequestBody
    {

        /// <summary>
        /// Additional information about the company. This can be used to store foreign IDs, references, etc.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the groups that the company is assigned to.
        /// </summary>
        [JsonProperty("groups")]
        public List<GroupItems>? Groups { get; set; }

        /// <summary>
        /// Name of company being connected.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }
}