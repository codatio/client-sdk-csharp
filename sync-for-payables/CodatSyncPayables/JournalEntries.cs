
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables
{
    using CodatSyncPayables.Models.Operations;
    using CodatSyncPayables.Models.Shared;
    using CodatSyncPayables.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IJournalEntriesSDK
    {
        Task<Models.Operations.CreateJournalEntryResponse> CreateAsync(CreateJournalEntryRequest? request = null);
        Task<GetCreateJournalEntryModelResponse> GetCreateModelAsync(GetCreateJournalEntryModelRequest? request = null);
    }

    public class JournalEntriesSDK: IJournalEntriesSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.2";
        private const string _sdkGenVersion = "2.108.3";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public JournalEntriesSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        /// <summary>
        /// Create journal entry
        /// 
        /// <remarks>
        /// The *Create journal entry* endpoint creates a new [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company's connection.
        /// 
        /// [Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// Required data may vary by integration. To see what data to post, first call [Get create journal entry model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-journalEntries-model).
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<Models.Operations.CreateJournalEntryResponse> CreateAsync(CreateJournalEntryRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/journalEntries", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "JournalEntry", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.CreateJournalEntryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.CreateJournalEntryResponseValue = JsonConvert.DeserializeObject<Models.Shared.CreateJournalEntryResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get create journal entry model
        /// 
        /// <remarks>
        /// The *Get create journal entry model* endpoint returns the expected data for the request payload when creating a [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company and integration.
        /// 
        /// [Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// See the *response examples* for integration-specific indicative models.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetCreateJournalEntryModelResponse> GetCreateModelAsync(GetCreateJournalEntryModelRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/journalEntries", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateJournalEntryModelResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.PushOption = JsonConvert.DeserializeObject<PushOption>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}