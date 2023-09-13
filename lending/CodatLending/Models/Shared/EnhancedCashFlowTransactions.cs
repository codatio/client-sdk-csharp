
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
    /// > **Categorization engine**
    /// 
    /// <remarks>
    /// >
    /// > The categorization engine uses machine learning and has been fully trained against Plaid and TrueLayer banking data sources. It is not fully trained against the Basiq banking data source.
    /// 
    /// The Enhanced Cash Flow Transactions endpoint provides a fully categorized list of banking transactions for a company. Accounts and transaction data are obtained from the company's banking data sources.
    /// </remarks>
    /// </summary>
    public class EnhancedCashFlowTransactions
    {
        [JsonProperty("dataSources")]
        public List<DataSource>? DataSources { get; set; }
        
        /// <summary>
        /// Report additional information, which is specific to Assess reports
        /// </summary>
        [JsonProperty("reportInfo")]
        public ReportInfo? ReportInfo { get; set; }
        
        [JsonProperty("reportItems")]
        public List<EnhancedCashFlowItem>? ReportItems { get; set; }
        
    }
    
}