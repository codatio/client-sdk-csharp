
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Operations
{
    using CodatSyncPayables.Models.Shared;
    using Newtonsoft.Json;
    
    
    public class UnlinkConnectionUpdateConnection
    {
        /// <summary>
        /// The current authorization status of the data connection.
        /// </summary>
        [JsonProperty("status")]
        public DataConnectionStatus? Status { get; set; }
        
    }
    
}