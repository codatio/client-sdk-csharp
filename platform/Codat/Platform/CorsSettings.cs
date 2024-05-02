
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICorsSettings
    {

        /// <summary>
        /// Get CORS settings
        /// 
        /// <remarks>
        /// The *Get CORS settings* endpoint returns the allowed origins (i.e. your domains) you want to allow cross-origin resource sharing (<a href="https://en.wikipedia.org/wiki/Cross-origin_resource_sharing">CORS</a>) with Codat. <br/>
        /// <br/>
        /// Enabling CORS with Codat is required by our embedded <a href="https://docs.codat.io/auth-flow/optimize/connection-management">connection management UI</a> to access Codat&apos;s API endpoints.<br/>
        /// <br/>
        /// The embedded <a href="https://docs.codat.io/auth-flow/optimize/connection-management">connection management UI</a> lets your customers control access to their data by allowing them to manage their existing connections.
        /// </remarks>
        /// </summary>
        Task<GetConnectionManagementCorsSettingsResponse> GetAsync();

        /// <summary>
        /// Set CORS settings
        /// 
        /// <remarks>
        /// The *Set CORS settings* endpoint allows you to register allowed origins (i.e. your domains) for use in cross-origin resource sharing (<a href="https://en.wikipedia.org/wiki/Cross-origin_resource_sharing">CORS</a>).<br/>
        ///  <br/>
        /// Enabling CORS with Codat is required by our embedded <a href="https://docs.codat.io/auth-flow/optimize/connection-management">connection management UI</a> to access Codat&apos;s API endpoints. <br/>
        /// <br/>
        /// The embedded <a href="https://docs.codat.io/auth-flow/optimize/connection-management">connection management UI</a> lets your customers control access to their data by allowing them to manage their existing connections.
        /// </remarks>
        /// </summary>
        Task<SetConnectionManagementCorsSettingsResponse> SetAsync(ConnectionManagementAllowedOrigins? request = null);
    }

    public class CorsSettings: ICorsSettings
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.6.1";
        private const string _sdkGenVersion = "2.319.7";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.6.1 2.319.7 3.0.0 Codat.Platform";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public CorsSettings(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetConnectionManagementCorsSettingsResponse> GetAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/connectionManagement/corsSettings";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-connection-management-cors-settings", null, _securitySource);

            httpRequest = await this.SDKConfiguration.hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
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
                    var obj = ResponseBodyDeserializer.Deserialize<ConnectionManagementAllowedOrigins>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetConnectionManagementCorsSettingsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.ConnectionManagementAllowedOrigins = obj;
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

        public async Task<SetConnectionManagementCorsSettingsResponse> SetAsync(ConnectionManagementAllowedOrigins? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/connectionManagement/corsSettings";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("set-connection-management-cors-settings", null, _securitySource);

            httpRequest = await this.SDKConfiguration.hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 401 || _statusCode == 402 || _statusCode == 403 || _statusCode == 404 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
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
                    var obj = ResponseBodyDeserializer.Deserialize<ConnectionManagementAllowedOrigins>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new SetConnectionManagementCorsSettingsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.ConnectionManagementAllowedOrigins = obj;
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
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
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