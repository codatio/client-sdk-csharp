
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
    /// The customer or supplier for the transfer, if available.
    /// </summary>
    public class ContactRef
    {
        [JsonProperty("dataType")]
        public string? DataType { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
    }
    
}