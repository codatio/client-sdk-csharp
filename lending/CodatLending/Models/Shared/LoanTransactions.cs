
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
    
    
    /// <summary>
    /// OK
    /// </summary>
    public class LoanTransactions
    {
        /// <summary>
        /// If there are no errors, an empty array is returned.
        /// </summary>
        [JsonProperty("errors")]
        public List<object>? Errors { get; set; }
        
        [JsonProperty("reportInfo")]
        public LoanTransactionsReportInfo? ReportInfo { get; set; }
        
        /// <summary>
        /// Contains object of reporting properties. The loan ref will reference a different object depending on the integration type.
        /// </summary>
        [JsonProperty("reportItems")]
        public List<ReportItems>? ReportItems { get; set; }
        
    }
    
}