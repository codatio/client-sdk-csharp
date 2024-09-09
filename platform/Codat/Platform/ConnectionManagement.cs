//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform
{
    using Codat.Platform.Hooks;
    using Codat.Platform.Models.Errors;
    using Codat.Platform.Models.Operations;
    using Codat.Platform.Models.Shared;
    using Codat.Platform.Utils.Retries;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Configure UI and retrieve access tokens for authentication used by **Connections SDK**.
    /// </summary>
    public interface IConnectionManagement
    {
        public ICorsSettings CorsSettings { get; }

        /// <summary>
        /// Get access token
        /// 
        /// <remarks>
        /// Use the *Get access token* endpoint to retrieve a new access token for use with the <a href="https://docs.codat.io/auth-flow/optimize/connection-management">Connections SDK</a>. The token is only valid for one hour and applies to a single company.<br/>
        /// <br/>
        /// The embeddable <a href="https://docs.codat.io/auth-flow/optimize/connection-management">Connections SDK</a> lets your customers control access to their data by allowing them to manage their existing connections.
        /// </remarks>
        /// </summary>
        Task<GetConnectionManagementAccessTokenResponse> GetAccessTokenAsync(GetConnectionManagementAccessTokenRequest request, RetryConfig? retryConfig = null);
    }

    /// <summary>
    /// Configure UI and retrieve access tokens for authentication used by **Connections SDK**.
    /// </summary>
    public class ConnectionManagement: IConnectionManagement
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.7.1";
        private const string _sdkGenVersion = "2.411.9";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.7.1 2.411.9 3.0.0 Codat.Platform";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Platform.Models.Shared.Security>? _securitySource;
        public ICorsSettings CorsSettings { get; private set; }

        public ConnectionManagement(ISpeakeasyHttpClient client, Func<Codat.Platform.Models.Shared.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            CorsSettings = new CorsSettings(_client, _securitySource, _serverUrl, SDKConfiguration);
        }

        public async Task<GetConnectionManagementAccessTokenResponse> GetAccessTokenAsync(GetConnectionManagementAccessTokenRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connectionManagement/accessToken", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-connection-management-access-token", null, _securitySource);

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
            var retries = new Codat.Platform.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
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
                    var obj = ResponseBodyDeserializer.Deserialize<ConnectionManagementAccessToken>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetConnectionManagementAccessTokenResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.ConnectionManagementAccessToken = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(new List<int>{401, 402, 403, 404, 429, 500, 503}.Contains(responseStatusCode))
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