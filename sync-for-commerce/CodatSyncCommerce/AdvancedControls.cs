
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce
{
    using CodatSyncCommerce.Models.Operations;
    using CodatSyncCommerce.Models.Shared;
    using CodatSyncCommerce.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Advanced company management and sync preferences.
    /// </summary>
    public interface IAdvancedControlsSDK
    {

        /// <summary>
        /// Create company
        /// 
        /// <remarks>
        /// Creates a Codat company..
        /// </remarks>
        /// </summary>
        Task<CreateCompanyResponse> CreateCompanyAsync(CreateCompany? request = null);

        /// <summary>
        /// Get company configuration
        /// 
        /// <remarks>
        /// Returns a company&apos;s commerce sync configuration&apos;.
        /// </remarks>
        /// </summary>
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest? request = null);

        /// <summary>
        /// List companies
        /// 
        /// <remarks>
        /// Returns a list of companies.
        /// </remarks>
        /// </summary>
        Task<ListCompaniesResponse> ListCompaniesAsync(ListCompaniesRequest? request = null);

        /// <summary>
        /// Set configuration
        /// 
        /// <remarks>
        /// Sets a company&apos;s commerce sync configuration.
        /// </remarks>
        /// </summary>
        Task<SetConfigurationResponse> SetConfigurationAsync(SetConfigurationRequest? request = null);
    }

    /// <summary>
    /// Advanced company management and sync preferences.
    /// </summary>
    public class AdvancedControlsSDK: IAdvancedControlsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.2.0";
        private const string _sdkGenVersion = "2.150.0";
        private const string _openapiDocVersion = "1.1";
        private const string _userAgent = "speakeasy-sdk/csharp 2.2.0 2.150.0 1.1 Codat.Sync.Commerce";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public AdvancedControlsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<CreateCompanyResponse> CreateCompanyAsync(CreateCompany? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/companies";
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateCompanyResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Company = JsonConvert.DeserializeObject<Company>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/config/companies/{companyId}/sync/commerce", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetConfigurationResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Configuration = JsonConvert.DeserializeObject<Dictionary<string, object>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListCompaniesResponse> ListCompaniesAsync(ListCompaniesRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListCompaniesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Companies = JsonConvert.DeserializeObject<Companies>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<SetConfigurationResponse> SetConfigurationAsync(SetConfigurationRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/config/companies/{companyId}/sync/commerce", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new SetConfigurationResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Configuration = JsonConvert.DeserializeObject<Dictionary<string, object>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}