
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Links a journal entry to the underlying record that created it.
    /// </summary>
    public class JournalEntryRecordRef
    {

        /// <summary>
        /// Name of underlying data type.
        /// </summary>
        [JsonProperty("dataType")]
        public JournalEntryRecordRefDataType? DataType { get; set; }

        /// <summary>
        /// &apos;id&apos; of the underlying record or data type.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}