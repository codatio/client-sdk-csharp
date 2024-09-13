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
    
    public class LoanRef
    {

        /// <summary>
        /// The id of the object being referred to.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The dataConnectionId the object being referred to is associated with.
        /// </summary>
        [JsonProperty("dataConnectionId")]
        public string? DataConnectionId { get; set; }

        /// <summary>
        /// The object type data is referring to, e.g. Account.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}