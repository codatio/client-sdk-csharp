
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

    public interface ISalesReportsSDK
    {

        /// <summary>
        /// Get orders report
        /// 
        /// <remarks>
        /// The *Get orders report* endpoint returns the number of orders, total value, and average order value for a specific company&apos;s commerce connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// Learn more about the formulas used to calculate the order metrics <a href="https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available">here</a>.<br/>
        /// <br/>
        /// Refer to the <a href="https://docs.codat.io/lending/commerce-metrics/reporting-structure">commerce reporting structure</a> page for more details on commerce reports in Lending.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Orders report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index         | Dimensions     |<br/>
        /// |---------------|----------------|<br/>
        /// |   `index` = 0 | Period         |<br/>
        /// |   `index` = 1 | Order metrics  |<br/>
        /// <br/>
        /// | Index         | Measures   |<br/>
        /// |---------------|------------|<br/>
        /// | `index` = 0   | Count      |<br/>
        /// | `index` = 1   | Value      |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceOrdersReportResponse> GetOrdersAsync(GetCommerceOrdersReportRequest? request = null);

        /// <summary>
        /// Get refunds report
        /// 
        /// <remarks>
        /// The *Get refunds report* endpoint returns the number and total value of refunds and the refund rate for a specific company&apos;s commerce connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// Learn more about the formulas used to calculate the refunds metrics <a href="https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available">here</a>.<br/>
        /// <br/>
        /// Refer to the <a href="https://docs.codat.io/lending/commerce-metrics/reporting-structure">commerce reporting structure</a> page for more details on commerce reports in Lending.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Refunds report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index          | Dimensions     |<br/>
        /// |----------------|----------------|<br/>
        /// | `index` = 0    | Period         |<br/>
        /// | `index` = 1    | Refund metrics |<br/>
        /// <br/>
        /// | Index          | Measures    |<br/>
        /// |----------------|------------|<br/>
        /// | `index` = 0    | Count      |<br/>
        /// | `index` = 1    | Value      |<br/>
        /// | `index` = 2    | Percentage |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceRefundsReportResponse> GetRefundsAsync(GetCommerceRefundsReportRequest? request = null);
    }

    public class SalesReportsSDK: ISalesReportsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.4.1";
        private const string _sdkGenVersion = "2.173.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.4.1 2.173.0 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public SalesReportsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<GetCommerceOrdersReportResponse> GetOrdersAsync(GetCommerceOrdersReportRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/orders", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommerceOrdersReportResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
        

        public async Task<GetCommerceRefundsReportResponse> GetRefundsAsync(GetCommerceRefundsReportRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/refunds", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommerceRefundsReportResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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