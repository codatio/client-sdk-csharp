
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

    public interface IBillsSDK
    {
        Task<Models.Operations.CreateBillResponse> CreateAsync(CreateBillRequest? request = null);
        Task<DeleteBillResponse> DeleteAsync(DeleteBillRequest? request = null);
        Task<DownloadBillAttachmentResponse> DownloadAttachmentAsync(DownloadBillAttachmentRequest? request = null);
        Task<GetBillResponse> GetAsync(GetBillRequest? request = null);
        Task<GetBillAttachmentResponse> GetAttachmentAsync(GetBillAttachmentRequest? request = null);
        Task<GetCreateUpdateBillModelResponse> GetCreateUpdateModelAsync(GetCreateUpdateBillModelRequest? request = null);
        Task<ListBillsResponse> ListAsync(ListBillsRequest? request = null);
        Task<ListBillAttachmentsResponse> ListAttachmentsAsync(ListBillAttachmentsRequest? request = null);
        Task<Models.Operations.UpdateBillResponse> UpdateAsync(UpdateBillRequest? request = null);
        Task<UploadBillAttachmentResponse> UploadAttachmentAsync(UploadBillAttachmentRequest? request = null);
    }

    public class BillsSDK: IBillsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.0";
        private const string _sdkGenVersion = "2.109.3";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BillsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        /// <summary>
        /// Create bill
        /// 
        /// <remarks>
        /// The *Create bill* endpoint creates a new [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// Required data may vary by integration. To see what data to post, first call [Get create/update bill model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bills-model).
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating a bill.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<Models.Operations.CreateBillResponse> CreateAsync(CreateBillRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/bills", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Bill", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.CreateBillResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.CreateBillResponseValue = JsonConvert.DeserializeObject<Models.Shared.CreateBillResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        /// Delete bill
        /// 
        /// <remarks>
        /// The *Delete bill* endpoint allows you to delete a specified bill from an accounting platform. 
        /// 
        /// [Bills](https://docs.codat.io/accounting-api#/schemas/Bill) are itemized records of goods received or services provided to the SMB.
        /// 
        /// ### Process 
        /// 1. Pass the `{billId}` to the *Delete bill* endpoint and store the `pushOperationKey` returned.
        /// 2. Check the status of the delete operation by checking the status of push operation either via
        ///     1. [Push operation webhook](https://docs.codat.io/introduction/webhooks/core-rules-types#push-operation-status-has-changed) (advised),
        ///     2. [Push operation status endpoint](https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation).
        /// 
        ///    A `Success` status indicates that the bill object was deleted from the accounting platform.
        /// 3. (Optional) Check that the bill was deleted from the accounting platform.
        /// 
        /// ### Effect on related objects
        /// 
        /// Be aware that deleting a bill from an accounting platform might cause related objects to be modified. For example, if you delete a paid bill in QuickBooks Online, the bill is deleted but the bill payment against that bill is not. The bill payment is converted to a payment on account.
        /// 
        /// ## Integration specifics
        /// Integrations that support soft delete do not permanently delete the object in the accounting platform.
        /// 
        /// | Integration | Soft Delete | Details                                                                                                      |  
        /// |-------------|-------------|--------------------------------------------------------------------------------------------------------------|
        /// | QuickBooks Online | No          | -                                                                                                            |
        /// | Oracle NetSuite   | No          | When deleting a bill that's already linked to a bill payment, you must delete the linked bill payment first. |
        /// 
        /// > **Supported Integrations**
        /// > 
        /// > This functionality is currently only supported for our QuickBooks Online abd Oracle NetSuite integrations. Check out our [public roadmap](https://portal.productboard.com/codat/7-public-product-roadmap/tabs/46-accounting-api) to see what we're building next, and to submit ideas for new features.
        /// </remarks>
        /// </summary>
        public async Task<DeleteBillResponse> DeleteAsync(DeleteBillRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/bills/{billId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DeleteBillResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.PushOperation = JsonConvert.DeserializeObject<PushOperation>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// Download bill attachment
        /// 
        /// <remarks>
        /// The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<DownloadBillAttachmentResponse> DownloadAttachmentAsync(DownloadBillAttachmentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments/{attachmentId}/download", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DownloadBillAttachmentResponse
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
        

        /// <summary>
        /// Get bill
        /// 
        /// <remarks>
        /// The *Get bill* endpoint returns a single bill for a given `billId`.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a specific bill.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetBillResponse> GetAsync(GetBillRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/bills/{billId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBillResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.Bill = JsonConvert.DeserializeObject<Bill>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// Get bill attachment
        /// 
        /// <remarks>
        /// The *Get bill attachment* endpoint returns a specific attachment for a given `billId` and `attachmentId`.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a bill attachment.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetBillAttachmentResponse> GetAttachmentAsync(GetBillAttachmentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments/{attachmentId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBillAttachmentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.Attachment = JsonConvert.DeserializeObject<Attachment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// Get create/update bill model
        /// 
        /// <remarks>
        /// The *Get create/update bill model* endpoint returns the expected data for the request payload when creating and updating a [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company and integration.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// See the *response examples* for integration-specific indicative models.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating and updating a bill.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetCreateUpdateBillModelResponse> GetCreateUpdateModelAsync(GetCreateUpdateBillModelRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/bills", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateUpdateBillModelResponse
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
        

        /// <summary>
        /// List bills
        /// 
        /// <remarks>
        /// The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
        ///     
        /// </remarks>
        /// </summary>
        public async Task<ListBillsResponse> ListAsync(ListBillsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/bills", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBillsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.Bills = JsonConvert.DeserializeObject<Bills>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// List bill attachments
        /// 
        /// <remarks>
        /// The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support listing bill attachments.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<ListBillAttachmentsResponse> ListAttachmentsAsync(ListBillAttachmentsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBillAttachmentsResponse
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
        

        /// <summary>
        /// Update bill
        /// 
        /// <remarks>
        /// The *Update bill* endpoint updates an existing [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// Required data may vary by integration. To see what data to post, first call [Get create/update bill model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bills-model).
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating a bill.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<Models.Operations.UpdateBillResponse> UpdateAsync(UpdateBillRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/bills/{billId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Bill", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.UpdateBillResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.UpdateBillResponseValue = JsonConvert.DeserializeObject<Models.Shared.UpdateBillResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        /// Upload bill attachment
        /// 
        /// <remarks>
        /// The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.
        /// 
        /// [Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.
        /// 
        /// **Integration-specific behaviour**
        /// 
        /// For more details on supported file types by integration see [Attachments](https://docs.codat.io/sync-for-payables-api#/schemas/Attachment).
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support uploading a bill attachment.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<UploadBillAttachmentResponse> UploadAttachmentAsync(UploadBillAttachmentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/bills/{billId}/attachments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "multipart");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UploadBillAttachmentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                
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