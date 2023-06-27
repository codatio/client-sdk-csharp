
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Categories
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
    using Codat.Models.Categories;
    using Codat.Utils;

    public interface ICategoriesSDK
    {
        Task<GetAccountCategoryResponse> GetAccountCategoryAsync(GetAccountCategoryRequest request);
        Task<ListAccountsCategoriesResponse> ListAccountsCategoriesAsync(ListAccountsCategoriesRequest request);
        Task<ListAvailableAccountCategoriesResponse> ListAvailableAccountCategoriesAsync();
        Task<UpdateAccountCategoryResponse> UpdateAccountCategoryAsync(UpdateAccountCategoryRequest request);
        Task<UpdateAccountsCategoriesResponse> UpdateAccountsCategoriesAsync(UpdateAccountsCategoriesRequest request);
    }

    public class CategoriesSDK: ICategoriesSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "1.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public CategoriesSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GetAccountCategoryResponse> GetAccountCategoryAsync(GetAccountCategoryRequest request)
    {
        string baseUrl = "";
        var message = GetAccountCategoryRequest.BuildHttpRequestMessage("get-account-category", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetAccountCategoryResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CategorisedAccount = JsonConvert.DeserializeObject<CategorisedAccount>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<ListAccountsCategoriesResponse> ListAccountsCategoriesAsync(ListAccountsCategoriesRequest request)
    {
        string baseUrl = "";
        var message = ListAccountsCategoriesRequest.BuildHttpRequestMessage("list-accounts-categories", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new ListAccountsCategoriesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CategorisedAccounts = JsonConvert.DeserializeObject<CategorisedAccounts>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<ListAvailableAccountCategoriesResponse> ListAvailableAccountCategoriesAsync()
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/data/assess/accounts/categories");
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new ListAvailableAccountCategoriesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Categories = JsonConvert.DeserializeObject<List<Categories>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<UpdateAccountCategoryResponse> UpdateAccountCategoryAsync(UpdateAccountCategoryRequest request)
    {
        string baseUrl = "";
        var message = UpdateAccountCategoryRequest.BuildHttpRequestMessage("update-account-category", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new UpdateAccountCategoryResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CategorisedAccount = JsonConvert.DeserializeObject<CategorisedAccount>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<UpdateAccountsCategoriesResponse> UpdateAccountsCategoriesAsync(UpdateAccountsCategoriesRequest request)
    {
        string baseUrl = "";
        var message = UpdateAccountsCategoriesRequest.BuildHttpRequestMessage("update-accounts-categories", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new UpdateAccountsCategoriesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CategorisedAccounts = JsonConvert.DeserializeObject<List<CategorisedAccount>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    }
}