//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses
{
    using Codat.Sync.Expenses.Hooks;
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Models.Errors;
    using Codat.Sync.Expenses.Models.Requests;
    using Codat.Sync.Expenses.Utils.Retries;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Create transactions that represent your adjustments to your customers&apos; spend.
    /// </summary>
    public interface IAdjustments
    {

        /// <summary>
        /// Create adjustment transaction
        /// 
        /// <remarks>
        /// Use the *Create adjustment expense* endpoint to create an <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/AdjustmentTransactionRequest">adjustment</a> in the accounting software for a given company&apos;s connection. <br/>
        /// <br/>
        /// Adjustments represent write-offs and transaction alterations, such as foreign exchange adjustments, in the form of a journal entry. <br/>
        /// <br/>
        /// ### Supported Integrations<br/>
        /// <br/>
        /// | Integration           | Supported |<br/>
        /// |-----------------------|-----------|<br/>
        /// | QuickBooks Desktop    | Yes       |
        /// </remarks>
        /// </summary>
        Task<CreateAdjustmentTransactionResponse> CreateAsync(CreateAdjustmentTransactionRequest request, RetryConfig? retryConfig = null);
    }

    /// <summary>
    /// Create transactions that represent your adjustments to your customers&apos; spend.
    /// </summary>
    public class Adjustments: IAdjustments
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "6.0.0";
        private const string _sdkGenVersion = "2.415.6";
        private const string _openapiDocVersion = "prealpha";
        private const string _userAgent = "speakeasy-sdk/csharp 6.0.0 2.415.6 prealpha Codat.Sync.Expenses";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Sync.Expenses.Models.Components.Security>? _securitySource;

        public Adjustments(ISpeakeasyHttpClient client, Func<Codat.Sync.Expenses.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreateAdjustmentTransactionResponse> CreateAsync(CreateAdjustmentTransactionRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/adjustment-transactions", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("create-adjustment-transaction", null, _securitySource);

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
            var retries = new Codat.Sync.Expenses.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

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
                    var obj = ResponseBodyDeserializer.Deserialize<AdjustmentTransactionResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new CreateAdjustmentTransactionResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.AdjustmentTransactionResponse = obj;
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