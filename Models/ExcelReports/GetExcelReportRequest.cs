///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.ExcelReports;
using Codat.Utils;
using Codat.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetExcelReportRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("reportType")]
    public ExcelReportTypeEnum ReportType { get; set; }
    
    internal HttpRequestMessage BuildHttpRequestMessage(string operationId)
    {
        if("get-excel-report" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "companyId", "", this.CompanyId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "reportType", "", this.ReportType));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var companyId = PathParamSerializer.Serialize("simple", false, this.CompanyId);
            
            var message = new HttpRequestMessage(HttpMethod.Get, $"/data/companies/{companyId}/assess/excel/download" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetExcelReportRequest]");
    }
}
