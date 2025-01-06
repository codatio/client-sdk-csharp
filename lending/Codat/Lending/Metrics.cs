//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Hooks;
    using Codat.Lending.Models.Components;
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Models.Requests;
    using Codat.Lending.Utils;
    using Codat.Lending.Utils.Retries;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public interface IMetrics
    {

        /// <summary>
        /// Get commerce revenue metrics
        /// 
        /// <remarks>
        /// The *Get revenue report* endpoint returns the revenue and revenue growth for a specific company connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending/features/sales-overview#metrics">Learn more</a> about the formulas used to calculate the revenue metrics.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Revenue report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index         | Dimensions |<br/>
        /// |---------------|------------|<br/>
        /// |   `index` = 0 | Period     |<br/>
        /// |   `index` = 1 | Revenue    |<br/>
        /// <br/>
        /// | Index         | Measures                                                                                                                 |<br/>
        /// |---------------|--------------------------------------------------------------------------------------------------------------------------|<br/>
        /// | `index` = 0   | Value                                                                                                                    |<br/>
        /// | `index` = 1   | Percentage change, defined as the change between the current and previous periods&apos; values and expressed as a percentage. |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest request, RetryConfig? retryConfig = null);

        /// <summary>
        /// Get customer retention metrics
        /// 
        /// <remarks>
        /// The *Get customer retention metrics* endpoint returns customer retention insights for a specific company&apos;s commerce connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// #### Customer retention metrics<br/>
        /// <br/>
        /// - __Existing customers__: the number of unique customers that have placed an order(s) in the specified period and any previous period. <br/>
        /// - __New customers__: the number of unique customers that have placed an order(s) in the specified period and none in any previous period.<br/>
        /// - __Total customers__: the total number of existing and new customers within the specified period.<br/>
        /// - __Retention rate__: the ratio of existing customers within the specified period compared to the total customers at the end of the previous period represented as a percentage.<br/>
        /// - __Repeat rate__: the ratio of existing customers to total customers over the specified period represented as a percentage.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending/features/sales-overview#metrics">Learn more</a> about the formulas used to calculate customer retention metrics.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Customer retention report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index                       | Dimensions                 |<br/>
        /// |-----------------------------|----------------------------|<br/>
        /// | `index` = 0                 | Period                     |<br/>
        /// | `index` = 1                 | Customer retention metrics |<br/>
        /// <br/>
        /// | Index                | Measures    |<br/>
        /// |----------------------|------------|<br/>
        /// | `index` = 0          | Count      |<br/>
        /// | `index` = 1          | Percentage |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.
        /// </remarks>
        /// </summary>
        Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest request, RetryConfig? retryConfig = null);

        /// <summary>
        /// Get lifetime value metrics
        /// 
        /// <remarks>
        /// The *Get lifetime value metrics* endpoint returns the average revenue that a specific company will generate throughout its lifespan over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending/features/sales-overview#metrics">Learn more</a> about the formulas used to calculate the lifetime value metrics.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Lifetime value report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index         | Dimensions             |<br/>
        /// |---------------|------------------------|<br/>
        /// | `index` = 0   | Period                 |<br/>
        /// | `index` = 1   | Lifetime value metrics |<br/>
        /// <br/>
        /// | Index             | Measures |<br/>
        /// |-------------------|---------|<br/>
        /// |   `index` = 1     | Value   |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest request, RetryConfig? retryConfig = null);
    }

    public class Metrics: IMetrics
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "9.0.2";
        private const string _sdkGenVersion = "2.486.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 9.0.2 2.486.1 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Lending.Models.Components.Security>? _securitySource;

        public Metrics(ISpeakeasyHttpClient client, Func<Codat.Lending.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/revenue", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-commerce-revenue-metrics", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            if (retryConfig == null)
            {
                if (this.SDKConfiguration.RetryConfig != null)
                {
                    retryConfig = this.SDKConfiguration.RetryConfig;
                }
                else
                {
                    var backoff = new BackoffStrategy(
                        initialIntervalMs: 500L,
                        maxIntervalMs: 60000L,
                        maxElapsedTimeMs: 3600000L,
                        exponent: 1.5
                    );
                    retryConfig = new RetryConfig(
                        strategy: RetryConfig.RetryStrategy.BACKOFF,
                        backoff: backoff,
                        retryConnectionErrors: true
                    );
                }
            }

            List<string> statusCodes = new List<string>
            {
                "408",
                "429",
                "5XX",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await _client.CloneAsync(httpRequest);
                return await _client.SendAsync(_httpRequest);
            };
            var retries = new Codat.Lending.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCommerceRevenueMetricsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CommerceReport = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(new List<int>{400, 401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/customerRetention", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-commerce-customer-retention-metrics", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            if (retryConfig == null)
            {
                if (this.SDKConfiguration.RetryConfig != null)
                {
                    retryConfig = this.SDKConfiguration.RetryConfig;
                }
                else
                {
                    var backoff = new BackoffStrategy(
                        initialIntervalMs: 500L,
                        maxIntervalMs: 60000L,
                        maxElapsedTimeMs: 3600000L,
                        exponent: 1.5
                    );
                    retryConfig = new RetryConfig(
                        strategy: RetryConfig.RetryStrategy.BACKOFF,
                        backoff: backoff,
                        retryConnectionErrors: true
                    );
                }
            }

            List<string> statusCodes = new List<string>
            {
                "408",
                "429",
                "5XX",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await _client.CloneAsync(httpRequest);
                return await _client.SendAsync(_httpRequest);
            };
            var retries = new Codat.Lending.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCommerceCustomerRetentionMetricsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CommerceReport = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(new List<int>{400, 401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/lifetimeValue", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-commerce-lifetime-value-metrics", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            if (retryConfig == null)
            {
                if (this.SDKConfiguration.RetryConfig != null)
                {
                    retryConfig = this.SDKConfiguration.RetryConfig;
                }
                else
                {
                    var backoff = new BackoffStrategy(
                        initialIntervalMs: 500L,
                        maxIntervalMs: 60000L,
                        maxElapsedTimeMs: 3600000L,
                        exponent: 1.5
                    );
                    retryConfig = new RetryConfig(
                        strategy: RetryConfig.RetryStrategy.BACKOFF,
                        backoff: backoff,
                        retryConnectionErrors: true
                    );
                }
            }

            List<string> statusCodes = new List<string>
            {
                "408",
                "429",
                "5XX",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await _client.CloneAsync(httpRequest);
                return await _client.SendAsync(_httpRequest);
            };
            var retries = new Codat.Lending.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCommerceLifetimeValueMetricsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CommerceReport = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(new List<int>{400, 401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }
    }
}