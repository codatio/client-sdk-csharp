
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses
{
    using CodatSyncExpenses.Models.Operations;
    using CodatSyncExpenses.Models.Shared;
    using CodatSyncExpenses.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Customers
    /// </summary>
    public interface ICustomersSDK
    {

        /// <summary>
        /// Create customer
        /// 
        /// <remarks>
        /// The *Create customer* endpoint creates a new <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">customer</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">Customers</a> are people or organizations that buy goods or services from the SMB.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// Required data may vary by integration. To see what data to post, first call <a href="https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model">Get create/update customer model</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=customers">coverage explorer</a> for integrations that support creating an account.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<Models.Operations.CreateCustomerResponse> CreateAsync(CreateCustomerRequest? request = null);

        /// <summary>
        /// Get customer
        /// 
        /// <remarks>
        /// The *Get customer* endpoint returns a single customer for a given customerId.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">Customers</a> are people or organizations that buy goods or services from the SMB.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=customers">coverage explorer</a> for integrations that support getting a specific customer.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCustomerResponse> GetAsync(GetCustomerRequest? request = null);

        /// <summary>
        /// List customers
        /// 
        /// <remarks>
        /// The *List customers* endpoint returns a list of <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">customers</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">Customers</a> are people or organizations that buy goods or services from the SMB.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListCustomersResponse> ListAsync(ListCustomersRequest? request = null);

        /// <summary>
        /// Update customer
        /// 
        /// <remarks>
        /// The *Update customer* endpoint updates an existing <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">customer</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Customer">Customers</a> are people or organizations that buy goods or services from the SMB.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// Required data may vary by integration. To see what data to post, first call <a href="https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model">Get create/update customer model</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=customers">coverage explorer</a> for integrations that support creating an account.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<Models.Operations.UpdateCustomerResponse> UpdateAsync(UpdateCustomerRequest? request = null);
    }

    /// <summary>
    /// Customers
    /// </summary>
    public class CustomersSDK: ICustomersSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.0";
        private const string _sdkGenVersion = "2.143.2";
        private const string _openapiDocVersion = "prealpha";
        private const string _userAgent = "speakeasy-sdk/csharp 2.3.0 2.143.2 prealpha Codat.Sync.Expenses";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public CustomersSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<Models.Operations.CreateCustomerResponse> CreateAsync(CreateCustomerRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/customers", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Customer", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.CreateCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateCustomerResponseValue = JsonConvert.DeserializeObject<Models.Shared.CreateCustomerResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
        

        public async Task<GetCustomerResponse> GetAsync(GetCustomerRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/customers/{customerId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Customer = JsonConvert.DeserializeObject<Customer>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListCustomersResponse> ListAsync(ListCustomersRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/customers", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListCustomersResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Customers = JsonConvert.DeserializeObject<Customers>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<Models.Operations.UpdateCustomerResponse> UpdateAsync(UpdateCustomerRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/customers/{customerId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Customer", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.UpdateCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.UpdateCustomerResponseValue = JsonConvert.DeserializeObject<Models.Shared.UpdateCustomerResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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