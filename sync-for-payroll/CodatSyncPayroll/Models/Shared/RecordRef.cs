
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Links the current record to the underlying record or data type that created it. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// For example, if a journal entry is generated based on an invoice, this property allows you to connect the journal entry to the underlying invoice in our data model. 
    /// </remarks>
    /// </summary>
    public class RecordRef
    {

        /// <summary>
        /// Allowed name of the &apos;dataType&apos;.
        /// </summary>
        [JsonProperty("dataType")]
        public string? DataType { get; set; }

        /// <summary>
        /// &apos;id&apos; of the underlying record or data type.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}