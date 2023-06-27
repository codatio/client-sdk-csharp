
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.DataIntegrity
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using NodaTime;
    using Codat.Models.Shared;
    using Codat.Models.DataIntegrity;
    using Codat.Utils;

    public interface IDataIntegritySDK
    {
        Task<GetDataIntegrityStatusResponse> GetDataIntegrityStatusAsync(GetDataIntegrityStatusRequest request);
        Task<GetDataIntegritySummariesResponse> GetDataIntegritySummariesAsync(GetDataIntegritySummariesRequest request);
        Task<ListDataTypeDataIntegrityDetailsResponse> ListDataTypeDataIntegrityDetailsAsync(ListDataTypeDataIntegrityDetailsRequest request);
    }

    public class DataIntegritySDK: IDataIntegritySDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "1.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public DataIntegritySDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GetDataIntegrityStatusResponse> GetDataIntegrityStatusAsync(GetDataIntegrityStatusRequest request)
    {
        string baseUrl = "";
        var message = GetDataIntegrityStatusRequest.BuildHttpRequestMessage("get-data-integrity-status", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetDataIntegrityStatusResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Status = JsonConvert.DeserializeObject<Status>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetDataIntegritySummariesResponse> GetDataIntegritySummariesAsync(GetDataIntegritySummariesRequest request)
    {
        string baseUrl = "";
        var message = GetDataIntegritySummariesRequest.BuildHttpRequestMessage("get-data-integrity-summaries", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetDataIntegritySummariesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Summaries = JsonConvert.DeserializeObject<Summaries>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<ListDataTypeDataIntegrityDetailsResponse> ListDataTypeDataIntegrityDetailsAsync(ListDataTypeDataIntegrityDetailsRequest request)
    {
        string baseUrl = "";
        var message = ListDataTypeDataIntegrityDetailsRequest.BuildHttpRequestMessage("list-data-type-data-integrity-details", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new ListDataTypeDataIntegrityDetailsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Details = JsonConvert.DeserializeObject<Details>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    }
}