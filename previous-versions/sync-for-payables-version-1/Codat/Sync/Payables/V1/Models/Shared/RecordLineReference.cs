//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Reference to the purchase order line this line was generated from.
    /// </summary>
    public class RecordLineReference
    {

        /// <summary>
        /// Allowed name of the &apos;dataType&apos;.
        /// </summary>
        [JsonProperty("dataType")]
        public BillLineItemDataType? DataType { get; set; }

        /// <summary>
        /// &apos;id&apos; of the underlying record.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Line number of the underlying record.
        /// </summary>
        [JsonProperty("lineNumber")]
        public string? LineNumber { get; set; }
    }
}