
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
    using System.Collections.Generic;
    
    public class Tracking
    {

        /// <summary>
        /// Links the current record to the underlying record or data type that created it. <br/>
        /// 
        /// <remarks>
        /// <br/>
        /// For example, if a journal entry is generated based on an invoice, this property allows you to connect the journal entry to the underlying invoice in our data model. 
        /// </remarks>
        /// </summary>
        [JsonProperty("invoiceTo")]
        public RecordRef? InvoiceTo { get; set; }

        [JsonProperty("recordRefs")]
        public List<RecordRef> RecordRefs { get; set; } = default!;
    }
}