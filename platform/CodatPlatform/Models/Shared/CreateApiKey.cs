
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Details of the API key.
    /// </summary>
    public class CreateApiKey
    {

        /// <summary>
        /// A meaningful name assigned to the API key.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}