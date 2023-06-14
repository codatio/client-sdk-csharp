
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Reports
{
    using Codat.Utils;
    using Codat.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class GetCommerceCustomerRetentionMetricsRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("connectionId")]
    public string ConnectionId { get; set; }
    
    [JsonProperty("includeDisplayNames")]
    public bool? IncludeDisplayNames { get; set; }
    
    [JsonProperty("numberOfPeriods")]
    public int NumberOfPeriods { get; set; }
    
    [JsonProperty("periodLength")]
    public int PeriodLength { get; set; }
    
    [JsonProperty("periodUnit")]
    public PeriodUnit PeriodUnit { get; set; }
    
    [JsonProperty("reportDate")]
    public string ReportDate { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetCommerceCustomerRetentionMetricsRequest value, string baseUrl)
    {
        if("get-commerce-customer-retention-metrics" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "companyId", "", value.CompanyId));
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "connectionId", "", value.ConnectionId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "includeDisplayNames", "", value.IncludeDisplayNames));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "numberOfPeriods", "", value.NumberOfPeriods));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "periodLength", "", value.PeriodLength));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "periodUnit", "", value.PeriodUnit));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "reportDate", "", value.ReportDate));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var companyId = PathParamSerializer.Serialize("simple", false, value.CompanyId);
            
            var connectionId = PathParamSerializer.Serialize("simple", false, value.ConnectionId);
            
            
            
            
            
            var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/customerRetention" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetCommerceCustomerRetentionMetricsRequest]");
    }
}
}