
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
    
    
    public class TransactionSourceRef
    {
        /// <summary>
        /// The unique identitifer of the record being referenced
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("type")]
        public TransactionSourceType Type { get; set; }
        
    }
    
}