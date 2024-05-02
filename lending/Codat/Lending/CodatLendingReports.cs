
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
    using Codat.Lending.Hooks;
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Models.Operations;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatLendingReports
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
        Task<GetCommerceOrdersReportResponse> GetOrdersAsync(GetCommerceOrdersReportRequest request);

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
        Task<GetCommerceRefundsReportResponse> GetRefundsAsync(GetCommerceRefundsReportRequest request);
    }

    public class CodatLendingReports: ICodatLendingReports
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.4.0";
        private const string _sdkGenVersion = "2.319.7";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.4.0 2.319.7 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public CodatLendingReports(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetCommerceOrdersReportResponse> GetOrdersAsync(GetCommerceOrdersReportRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/orders", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-commerce-orders-report", null, _securitySource);

            httpRequest = await this.SDKConfiguration.hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCommerceOrdersReportResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CommerceReport = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(new List<int>{400, 401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetCommerceRefundsReportResponse> GetRefundsAsync(GetCommerceRefundsReportRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/refunds", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-commerce-refunds-report", null, _securitySource);

            httpRequest = await this.SDKConfiguration.hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCommerceRefundsReportResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CommerceReport = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(new List<int>{400, 401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}