
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    
    public class AccountMetadata
    {

        /// <summary>
        /// Indicates whether the record has been deleted in the third-party system this record originated from.
        /// </summary>
        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }
    }
}