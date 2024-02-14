
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Models.Operations;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Download reports in Excel format.
    /// </summary>
    public interface IExcelReports
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
    public class ExcelReports: IExcelReports
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.3.0";
        private const string _sdkGenVersion = "2.257.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.3.0 2.257.2 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public ExcelReports(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<DownloadExcelReportResponse> DownloadAsync(DownloadExcelReportRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel/download", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

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
                if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
                {
                    response.Body = await httpResponse.Content.ReadAsByteArrayAsync();
                }

                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GenerateExcelReportResponse> GenerateAsync(GenerateExcelReportRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

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
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetExcelReportGenerationStatusResponse> GetStatusAsync(GetExcelReportGenerationStatusRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/excel", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

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
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}