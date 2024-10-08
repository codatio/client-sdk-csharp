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
    using System.Collections.Generic;
    
    public class DataIntegrityConnectionId
    {

        /// <summary>
        /// An array of strings. The connection IDs for the type specified in the url.
        /// </summary>
        [JsonProperty("source")]
        public List<string>? Source { get; set; }

        /// <summary>
        /// An array of strings. The connection IDs for the type being matched to.
        /// </summary>
        [JsonProperty("target")]
        public List<string>? Target { get; set; }
    }
}