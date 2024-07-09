//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Shared
{
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Details about the newly created API key.
    /// </summary>
    public class CreateApiKey
    {

        /// <summary>
        /// A meaningful name assigned to the API key.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;
    }
}