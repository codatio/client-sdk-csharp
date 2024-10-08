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
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; **Categorization engine**<br/>
    /// 
    /// <remarks>
    /// &gt;<br/>
    /// &gt; The categorization engine uses machine learning and has been fully trained against Plaid and TrueLayer banking data sources. It is not fully trained against the Basiq banking data source.<br/>
    /// <br/>
    /// The Enhanced Cash Flow Transactions endpoint provides a fully categorized list of banking transactions for a company. Accounts and transaction data are obtained from the company&apos;s banking data sources.
    /// </remarks>
    /// </summary>
    public class EnhancedCashFlowTransactions
    {

        /// <summary>
        /// Report additional information, which is specific to Lending API reports.
        /// </summary>
        [JsonProperty("reportInfo")]
        public ReportInfo? ReportInfo { get; set; }

        [JsonProperty("dataSources")]
        public List<DataSource>? DataSources { get; set; }

        [JsonProperty("reportItems")]
        public List<EnhancedCashFlowItem>? ReportItems { get; set; }
    }
}