
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform
{
    using CodatPlatform.Models.Operations;
    using CodatPlatform.Models.Shared;
    using CodatPlatform.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// View push options and get push statuses.
    /// </summary>
    public interface IPushDataSDK
    {

        /// <summary>
        /// Get push options
        /// 
        /// <remarks>
        /// This is the generic documentation for creation and updating of data. See the equivalent endpoint for a given data type for more specific information. <br/>
        /// <br/>
        /// Before pushing data into accounting software, it is often necessary to collect some details from the user as to how they would like the data to be inserted. This includes names and amounts on transactional entities, but also factors such as categorisation of entities, which is often handled differently between different accounting packages. A good example of this is specifying where on the balance sheet/profit and loss reports the user would like a newly-created nominal account to appear.<br/>
        /// <br/>
        /// Codat tries not to limit users to pushing to a very limited number of standard categories, so we have implemented &quot;options&quot; endpoints, which allow us to expose to our clients the fields which are required to be pushed for a specific linked company, and the options which may be selected for each field.<br/>
        /// <br/>
        /// <br/>
        /// &gt; **Supported Integrations**<br/>
        /// &gt; <br/>
        /// &gt; Check out our <a href="https://knowledge.codat.io/">coverage explorer</a> for integrations that support push (POST/PUT methods).
        /// </remarks>
        /// </summary>
        Task<GetCreateUpdateModelOptionsByDataTypeResponse> GetModelOptionsAsync(GetCreateUpdateModelOptionsByDataTypeRequest? request = null);

        /// <summary>
        /// Get push operation
        /// 
        /// <remarks>
        /// Retrieve push operation.
        /// </remarks>
        /// </summary>
        Task<GetPushOperationResponse> GetOperationAsync(GetPushOperationRequest? request = null);

        /// <summary>
        /// List push operations
        /// 
        /// <remarks>
        /// List push operation records.
        /// </remarks>
        /// </summary>
        Task<GetCompanyPushHistoryResponse> ListOperationsAsync(GetCompanyPushHistoryRequest? request = null);
    }

    /// <summary>
    /// View push options and get push statuses.
    /// </summary>
    public class PushDataSDK: IPushDataSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.0";
        private const string _sdkGenVersion = "2.142.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.3.0 2.142.2 3.0.0 Codat.Platform";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public PushDataSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<GetCreateUpdateModelOptionsByDataTypeResponse> GetModelOptionsAsync(GetCreateUpdateModelOptionsByDataTypeRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/{dataType}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateUpdateModelOptionsByDataTypeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PushOption = JsonConvert.DeserializeObject<PushOption>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetPushOperationResponse> GetOperationAsync(GetPushOperationRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/push/{pushOperationKey}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetPushOperationResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PushOperation = JsonConvert.DeserializeObject<PushOperation>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCompanyPushHistoryResponse> ListOperationsAsync(GetCompanyPushHistoryRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/push", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCompanyPushHistoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PushOperations = JsonConvert.DeserializeObject<PushOperations>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
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