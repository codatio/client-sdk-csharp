
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class InvoiceStatus
    {

        /// <summary>
        /// Options for invoice statuses.
        /// </summary>
        [JsonProperty("invoiceStatusOptions")]
        public List<string>? InvoiceStatusOptions { get; set; }

        /// <summary>
        /// Selected option for invoice status for invoice to be synced.
        /// </summary>
        [JsonProperty("selectedInvoiceStatus")]
        public string? SelectedInvoiceStatus { get; set; }
    }
}