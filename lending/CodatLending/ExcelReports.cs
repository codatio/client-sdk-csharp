
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending
{
    using CodatLending.Models.Operations;
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Download reports in Excel format.
    /// </summary>
    public interface IExcelReportsSDK
    {

        /// <summary>
        /// Download Excel report
        /// 
        /// <remarks>
        /// The *Download Excel report* endpoint downloads the latest successfully generated Excel report of a specified report type for a given company. <br/>
        /// <br/>
        /// The downloadable Excel file is returned in the response. You can save it to your local machine.<br/>
        /// <br/>
        /// You can <a href="https://docs.codat.io/lending/excel/overview">learn more</a> about valid Excel report types.
        /// </remarks>
        /// </summary>
        Task<DownloadExcelReportResponse> DownloadAsync(DownloadExcelReportRequest? request = null);

        /// <summary>
        /// Generate Excel report
        /// 
        /// <remarks>
        /// The *Generate Excel report* endpoint requests the production of a downloadable Excel file for a report type specified in the `reportType` query parameter.<br/>
        /// <br/>
        /// In response, the endpoint returns the <a href="https://docs.codat.io/lending-api#/schemas/ExcelStatus">status</a> detailing the current state of the report generation request.<br/>
        /// <br/>
        /// ### Report types<br/>
        /// <br/>
        /// | reportType                                                                           | Description                                                                                                                                   |<br/>
        /// |--------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|<br/>
        /// | <a href="https://docs.codat.io/lending/excel/audit-report">audit</a>                            | Identifies inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   || <a href="https://docs.codat.io/lending/excel/audit-report">audit</a>                            | Identify inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   |<br/>
        /// | <a href="https://docs.codat.io/lending/excel/enhanced-invoices-report">enhancedCashFlow</a>     | Provides a fully categorized list of bank transactions for a company, allowing lenders to accurately forecast a company&apos;s cash flow.  |<br/>
        /// | <a href="https://docs.codat.io/lending/excel/enhanced-financials-report">enhancedFinancials</a> | Supports decision-making using fully categorized financial statements to allow lenders to automate their underwriting processes.                |<br/>
        /// | <a href="https://docs.codat.io/lending/excel/enhanced-invoices-report">enhancedInvoices</a>     | Helps verify that payments have been made against historic invoices. Great for invoice finance lenders.                                       |<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending/excel/overview">Learn more</a> about valid Excel report types.<br/>
        /// <br/>
        /// <br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GenerateExcelReportResponse> GenerateAsync(GenerateExcelReportRequest? request = null);

        /// <summary>
        /// Get Excel report status
        /// 
        /// <remarks>
        /// The *Get Excel report status* returns the status of the report mostly recently requested for Excel generation. It does not return the status of any historical report requests. <br/>
        /// <br/>
        /// Poll this endpoint to check the progress of the report once you have requested its generation. This will not affect the generation of the report. <br/>
        /// <br/>
        /// When the report generation completes successfully, the `inProgress` property will be marked as `false` and the `success` field will be marked as `true`.
        /// </remarks>
        /// </summary>
        Task<GetExcelReportGenerationStatusResponse> GetStatusAsync(GetExcelReportGenerationStatusRequest? request = null);
    }

    /// <summary>
    /// Download reports in Excel format.
    /// </summary>
    public class ExcelReportsSDK: IExcelReportsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.2.1";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public ExcelReportsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<DownloadExcelReportResponse> DownloadAsync(DownloadExcelReportRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel/download", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DownloadExcelReportResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/octet-stream", response.ContentType))
                {
                    response.Body = await httpResponse.Content.ReadAsByteArrayAsync();
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GenerateExcelReportResponse> GenerateAsync(GenerateExcelReportRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GenerateExcelReportResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetExcelReportGenerationStatusResponse> GetStatusAsync(GetExcelReportGenerationStatusRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetExcelReportGenerationStatusResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}