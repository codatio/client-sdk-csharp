
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

    public interface IAccountsPayableSuppliersSDK
    {

        /// <summary>
        /// Download supplier attachment
        /// 
        /// <remarks>
        /// The *Download supplier attachment* endpoint downloads a specific attachment for a given `supplierId` and `attachmentId`.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support downloading a supplier attachment.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<DownloadAccountingSupplierAttachmentResponse> DownloadAttachmentAsync(DownloadAccountingSupplierAttachmentRequest? request = null);

        /// <summary>
        /// Get supplier
        /// 
        /// <remarks>
        /// The *Get supplier* endpoint returns a single supplier for a given supplierId.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support getting a specific supplier.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetAccountingSupplierResponse> GetAsync(GetAccountingSupplierRequest? request = null);

        /// <summary>
        /// Get supplier attachment
        /// 
        /// <remarks>
        /// The *Get supplier attachment* endpoint returns a specific attachment for a given `supplierId` and `attachmentId`.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support getting a supplier attachment.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetAccountingSupplierAttachmentResponse> GetAttachmentAsync(GetAccountingSupplierAttachmentRequest? request = null);

        /// <summary>
        /// List suppliers
        /// 
        /// <remarks>
        /// The *List suppliers* endpoint returns a list of <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">suppliers</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListAccountingSuppliersResponse> ListAsync(ListAccountingSuppliersRequest? request = null);

        /// <summary>
        /// List supplier attachments
        /// 
        /// <remarks>
        /// The *List supplier attachments* endpoint returns a list of attachments available to download for given `supplierId`.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/accounting-api#/schemas/Supplier">Suppliers</a> are people or organizations that provide something, such as a product or service.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers">coverage explorer</a> for integrations that support listing supplier attachments.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<ListAccountingSupplierAttachmentsResponse> ListAttachmentsAsync(ListAccountingSupplierAttachmentsRequest? request = null);
    }

    public class AccountsPayableSuppliersSDK: IAccountsPayableSuppliersSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.2.1";
        private const string _sdkGenVersion = "2.118.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public AccountsPayableSuppliersSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<DownloadAccountingSupplierAttachmentResponse> DownloadAttachmentAsync(DownloadAccountingSupplierAttachmentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/suppliers/{supplierId}/attachments/{attachmentId}/download", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DownloadAccountingSupplierAttachmentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/octet-stream", response.ContentType))
                {
                    response.Data = await httpResponse.Content.ReadAsByteArrayAsync();
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
        

        public async Task<GetAccountingSupplierResponse> GetAsync(GetAccountingSupplierRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/suppliers/{supplierId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAccountingSupplierResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.AccountingSupplier = JsonConvert.DeserializeObject<AccountingSupplier>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetAccountingSupplierAttachmentResponse> GetAttachmentAsync(GetAccountingSupplierAttachmentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/suppliers/{supplierId}/attachments/{attachmentId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAccountingSupplierAttachmentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.AccountingAttachment = JsonConvert.DeserializeObject<AccountingAttachment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        public async Task<ListAccountingSuppliersResponse> ListAsync(ListAccountingSuppliersRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/suppliers", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListAccountingSuppliersResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.AccountingSuppliers = JsonConvert.DeserializeObject<AccountingSuppliers>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListAccountingSupplierAttachmentsResponse> ListAttachmentsAsync(ListAccountingSupplierAttachmentsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/suppliers/{supplierId}/attachments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListAccountingSupplierAttachmentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.Attachments = JsonConvert.DeserializeObject<Attachments>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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