
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending
{
    using CodatLending.Models.Operations;
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ILoanWritebackSuppliersSDK
    {

        /// <summary>
        /// Create supplier
        /// 
        /// <remarks>
        /// The *Create supplier* endpoint creates a new <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">supplier</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// Required data may vary by integration. To see what data to post, first call <a href="https://docs.codat.io/accounting-api#/operations/get-create-update-suppliers-model">Get create/update supplier model</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support creating an account.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<CreateSupplierResponse> CreateAsync(CreateSupplierRequest? request = null);

        /// <summary>
        /// Get create/update supplier model
        /// 
        /// <remarks>
        /// The *Get create/update supplier model* endpoint returns the expected data for the request payload when creating and updating a <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">supplier</a> for a given company and integration.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// See the *response examples* for integration-specific indicative models.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support creating and updating a supplier.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCreateUpdateSuppliersModelResponse> GetCreateUpdateModelAsync(GetCreateUpdateSuppliersModelRequest? request = null);
    }

    public class LoanWritebackSuppliersSDK: ILoanWritebackSuppliersSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.1.0";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public LoanWritebackSuppliersSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<CreateSupplierResponse> CreateAsync(CreateSupplierRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/suppliers", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingSupplier", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateSupplierResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.AccountingCreateSupplierResponse = JsonConvert.DeserializeObject<AccountingCreateSupplierResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCreateUpdateSuppliersModelResponse> GetCreateUpdateModelAsync(GetCreateUpdateSuppliersModelRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/suppliers", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateUpdateSuppliersModelResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.PushOption = JsonConvert.DeserializeObject<PushOption>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}