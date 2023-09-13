
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
    
    
    /// <summary>
    /// Taxes rates reference object depending on the rates being available on source commerce package.
    /// </summary>
    public class TaxComponentRef
    {
        /// <summary>
        /// The unique identitifer of the tax component being referenced.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Name of the tax component being referenced.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
    }
    
}