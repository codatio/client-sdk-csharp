
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Shared
{
    using Codat.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class EnhancedCashFlowTransactions
{
    [JsonProperty("dataSources")]
    public List<DataSource>? DataSources { get; set; }
    
    [JsonProperty("reportInfo")]
    public ReportInfo? ReportInfo { get; set; }
    
    [JsonProperty("reportItems")]
    public List<EnhancedCashFlowItem>? ReportItems { get; set; }
    
}
}