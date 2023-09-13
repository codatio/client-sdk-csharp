
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

    public interface ISalesMetricsSDK
    {
        Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest? request = null);
        Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest? request = null);
        Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest? request = null);
    }

    public class SalesMetricsSDK: ISalesMetricsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.1.0";
        private const string _sdkGenVersion = "2.109.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public SalesMetricsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        /// <summary>
        /// Get customer retention metrics
        /// 
        /// <remarks>
        /// The *Get customer retention metrics* endpoint returns customer retention insights for a specific company's commerce connection over one or more periods of time.
        /// 
        /// This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 
        /// 
        /// #### Customer retention metrics
        /// 
        /// - __Existing customers__: the number of unique customers that have placed an order(s) in the specified period and any previous period. 
        /// - __New customers__: the number of unique customers that have placed an order(s) in the specified period and none in any previous period.
        /// - __Total customers__: the total number of existing and new customers within the specified period.
        /// - __Retention rate__: the ratio of existing customers within the specified period compared to the total customers at the end of the previous period represented as a percentage.
        /// - __Repeat rate__: the ratio of existing customers to total customers over the specified period represented as a percentage.
        /// 
        /// Learn more about the formulas used to calculate customer retention metrics [here](https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available).
        /// 
        /// #### Response structure
        /// 
        /// The Customer retention report's dimensions and measures are:
        /// 
        /// | Index                       | Dimensions                 |
        /// |-----------------------------|----------------------------|
        /// | `index` = 0                 | Period                     |
        /// | `index` = 1                 | Customer retention metrics |
        /// 
        /// | Index                | Measures    |
        /// |----------------------|------------|
        /// | `index` = 0          | Count      |
        /// | `index` = 1          | Percentage |
        /// 
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.
        /// </remarks>
        /// </summary>
        public async Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/customerRetention", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommerceCustomerRetentionMetricsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
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
        /// Get lifetime value metrics
        /// 
        /// <remarks>
        /// The *Get lifetime value metrics* endpoint returns the average revenue that a specific company will generate throughout its lifespan over one or more periods of time.
        /// 
        /// This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company.
        /// 
        /// Learn more about the formulas used to calculate the lifetime value metrics [here](https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available).
        /// 
        /// Refer to the [commerce reporting structure](https://docs.codat.io/lending/commerce-metrics/reporting-structure) page for more detail on commerce reports in Lending.
        /// 
        /// #### Response structure
        /// 
        /// The Lifetime value report's dimensions and measures are:
        /// 
        /// | Index         | Dimensions             |
        /// |---------------|------------------------|
        /// | `index` = 0   | Period                 |
        /// | `index` = 1   | Lifetime value metrics |
        /// 
        /// | Index             | Measures |
        /// |-------------------|---------|
        /// |   `index` = 1     | Value   |
        /// 
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/lifetimeValue", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommerceLifetimeValueMetricsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
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
        /// Get commerce revenue metrics
        /// 
        /// <remarks>
        /// The *Get revenue report* endpoint returns the revenue and revenue growth for a specific company connection over one or more periods of time.
        /// 
        /// This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 
        /// 
        /// Learn more about the formulas used to calculate the revenue metrics [here](https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available).
        /// 
        /// Refer to the [commerce reporting structure](https://docs.codat.io/lending/commerce-metrics/reporting-structure) page for more details on commerce reports in Lending.
        /// 
        /// #### Response structure
        /// 
        /// The Revenue report's dimensions and measures are:
        /// 
        /// | Index         | Dimensions |
        /// |---------------|------------|
        /// |   `index` = 0 | Period     |
        /// |   `index` = 1 | Revenue    |
        /// 
        /// | Index         | Measures                                                                                                                 |
        /// |---------------|--------------------------------------------------------------------------------------------------------------------------|
        /// | `index` = 0   | Value                                                                                                                    |
        /// | `index` = 1   | Percentage change, defined as the change between the current and previous periods' values and expressed as a percentage. |
        /// 
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/revenue", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommerceRevenueMetricsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
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