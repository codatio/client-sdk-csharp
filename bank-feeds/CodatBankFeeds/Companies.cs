
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds
{
    using Codat.BankFeeds.Models.Operations;
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Create and manage your Codat companies.
    /// </summary>
    public interface ICompanies
    {

        /// <summary>
        /// Create company
        /// 
        /// <remarks>
        /// Creates a new company that can be used to assign connections to. <br/>
        /// <br/>
        /// If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.<br/>
        /// <br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<CreateCompanyResponse> CreateAsync(CompanyRequestBody? request = null);

        /// <summary>
        /// Delete a company
        /// 
        /// <remarks>
        /// <br/>
        /// Permanently deletes a company, its connections and any cached data. This operation is irreversible. If the company ID does not exist an error is returned.
        /// </remarks>
        /// </summary>
        Task<DeleteCompanyResponse> DeleteAsync(DeleteCompanyRequest? request = null);

        /// <summary>
        /// Get company
        /// 
        /// <remarks>
        /// Returns the company for a valid identifier. If the identifier is for a deleted company, a not found response is returned.
        /// </remarks>
        /// </summary>
        Task<GetCompanyResponse> GetAsync(GetCompanyRequest? request = null);

        /// <summary>
        /// List companies
        /// 
        /// <remarks>
        /// Returns a list of your companies. The company schema contains a list of <a href="https://docs.codat.io/bank-feeds-api#/schemas/Connection">connections</a> related to the company.
        /// </remarks>
        /// </summary>
        Task<ListCompaniesResponse> ListAsync(ListCompaniesRequest? request = null);

        /// <summary>
        /// Update company
        /// 
        /// <remarks>
        /// Updates both the name and description of the company.
        /// </remarks>
        /// </summary>
        Task<UpdateCompanyResponse> UpdateAsync(UpdateCompanyRequest? request = null);
    }

    /// <summary>
    /// Create and manage your Codat companies.
    /// </summary>
    public class Companies: ICompanies
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.0.1";
        private const string _sdkGenVersion = "2.210.6";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.0.1 2.210.6 3.0.0 Codat.BankFeeds";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Companies(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateCompanyResponse> CreateAsync(CompanyRequestBody? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
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
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<DeleteCompanyResponse> DeleteAsync(DeleteCompanyRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DeleteCompanyResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 204))
            {
                
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
        

        public async Task<GetCompanyResponse> GetAsync(GetCompanyRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCompanyResponse
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
        

        public async Task<ListCompaniesResponse> ListAsync(ListCompaniesRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
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
                    response.Companies = JsonConvert.DeserializeObject<Models.Shared.Companies>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<UpdateCompanyResponse> UpdateAsync(UpdateCompanyRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CompanyRequestBody", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateCompanyResponse
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