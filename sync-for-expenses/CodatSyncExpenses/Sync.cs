
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses
{
    using Codat.Sync.Expenses.Models.Operations;
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Trigger and monitor expense syncs to accounting software.
    /// </summary>
    public interface ISync
    {

        /// <summary>
        /// Get sync status
        /// 
        /// <remarks>
        /// Get the sync status for a specified sync
        /// </remarks>
        /// </summary>
        Task<GetSyncByIdResponse> GetAsync(GetSyncByIdRequest? request = null);

        /// <summary>
        /// Last successful sync
        /// 
        /// <remarks>
        /// Gets the status of the last successful sync
        /// </remarks>
        /// </summary>
        Task<GetLastSuccessfulSyncResponse> GetLastSuccessfulSyncAsync(GetLastSuccessfulSyncRequest? request = null);

        /// <summary>
        /// Latest sync status
        /// 
        /// <remarks>
        /// Gets the latest sync status
        /// </remarks>
        /// </summary>
        Task<GetLatestSyncResponse> GetLatestSyncAsync(GetLatestSyncRequest? request = null);

        /// <summary>
        /// Initiate sync
        /// 
        /// <remarks>
        /// Initiate sync of pending transactions.
        /// </remarks>
        /// </summary>
        Task<InitiateSyncResponse> InitiateSyncAsync(InitiateSyncRequest? request = null);

        /// <summary>
        /// List sync statuses
        /// 
        /// <remarks>
        /// Gets a list of sync statuses
        /// </remarks>
        /// </summary>
        Task<ListSyncsResponse> ListAsync(ListSyncsRequest? request = null);
    }

    /// <summary>
    /// Trigger and monitor expense syncs to accounting software.
    /// </summary>
    public class Sync: ISync
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.0.0";
        private const string _sdkGenVersion = "2.210.6";
        private const string _openapiDocVersion = "prealpha";
        private const string _userAgent = "speakeasy-sdk/csharp 4.0.0 2.210.6 prealpha Codat.Sync.Expenses";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Sync(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetSyncByIdResponse> GetAsync(GetSyncByIdRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/syncs/{syncId}/status", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetSyncByIdResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CompanySyncStatus = JsonConvert.DeserializeObject<CompanySyncStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLastSuccessfulSyncResponse> GetLastSuccessfulSyncAsync(GetLastSuccessfulSyncRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/syncs/lastSuccessful/status", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetLastSuccessfulSyncResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CompanySyncStatus = JsonConvert.DeserializeObject<CompanySyncStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetLatestSyncResponse> GetLatestSyncAsync(GetLatestSyncRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/syncs/latest/status", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetLatestSyncResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CompanySyncStatus = JsonConvert.DeserializeObject<CompanySyncStatus>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<InitiateSyncResponse> InitiateSyncAsync(InitiateSyncRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/syncs", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "InitiateSync", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new InitiateSyncResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 202))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.SyncInitiated = JsonConvert.DeserializeObject<SyncInitiated>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListSyncsResponse> ListAsync(ListSyncsRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/sync/expenses/syncs/list/status", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListSyncsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Classes = JsonConvert.DeserializeObject<List<CompanySyncStatus>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
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