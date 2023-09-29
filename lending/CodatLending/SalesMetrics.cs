
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

        /// <summary>
        /// Get customer retention metrics
        /// 
        /// <remarks>
        /// The *Get customer retention metrics* endpoint returns customer retention insights for a specific company&apos;s commerce connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// #### Customer retention metrics<br/>
        /// <br/>
        /// - __Existing customers__: the number of unique customers that have placed an order(s) in the specified period and any previous period. <br/>
        /// - __New customers__: the number of unique customers that have placed an order(s) in the specified period and none in any previous period.<br/>
        /// - __Total customers__: the total number of existing and new customers within the specified period.<br/>
        /// - __Retention rate__: the ratio of existing customers within the specified period compared to the total customers at the end of the previous period represented as a percentage.<br/>
        /// - __Repeat rate__: the ratio of existing customers to total customers over the specified period represented as a percentage.<br/>
        /// <br/>
        /// Learn more about the formulas used to calculate customer retention metrics <a href="https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available">here</a>.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Customer retention report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index                       | Dimensions                 |<br/>
        /// |-----------------------------|----------------------------|<br/>
        /// | `index` = 0                 | Period                     |<br/>
        /// | `index` = 1                 | Customer retention metrics |<br/>
        /// <br/>
        /// | Index                | Measures    |<br/>
        /// |----------------------|------------|<br/>
        /// | `index` = 0          | Count      |<br/>
        /// | `index` = 1          | Percentage |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.
        /// </remarks>
        /// </summary>
        Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest? request = null);

        /// <summary>
        /// Get lifetime value metrics
        /// 
        /// <remarks>
        /// The *Get lifetime value metrics* endpoint returns the average revenue that a specific company will generate throughout its lifespan over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company.<br/>
        /// <br/>
        /// Learn more about the formulas used to calculate the lifetime value metrics <a href="https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available">here</a>.<br/>
        /// <br/>
        /// Refer to the <a href="https://docs.codat.io/lending/commerce-metrics/reporting-structure">commerce reporting structure</a> page for more detail on commerce reports in Lending.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Lifetime value report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index         | Dimensions             |<br/>
        /// |---------------|------------------------|<br/>
        /// | `index` = 0   | Period                 |<br/>
        /// | `index` = 1   | Lifetime value metrics |<br/>
        /// <br/>
        /// | Index             | Measures |<br/>
        /// |-------------------|---------|<br/>
        /// |   `index` = 1     | Value   |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest? request = null);

        /// <summary>
        /// Get commerce revenue metrics
        /// 
        /// <remarks>
        /// The *Get revenue report* endpoint returns the revenue and revenue growth for a specific company connection over one or more periods of time.<br/>
        /// <br/>
        /// This detail helps you assess a merchant&apos;s health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. <br/>
        /// <br/>
        /// Learn more about the formulas used to calculate the revenue metrics <a href="https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available">here</a>.<br/>
        /// <br/>
        /// Refer to the <a href="https://docs.codat.io/lending/commerce-metrics/reporting-structure">commerce reporting structure</a> page for more details on commerce reports in Lending.<br/>
        /// <br/>
        /// #### Response structure<br/>
        /// <br/>
        /// The Revenue report&apos;s dimensions and measures are:<br/>
        /// <br/>
        /// | Index         | Dimensions |<br/>
        /// |---------------|------------|<br/>
        /// |   `index` = 0 | Period     |<br/>
        /// |   `index` = 1 | Revenue    |<br/>
        /// <br/>
        /// | Index         | Measures                                                                                                                 |<br/>
        /// |---------------|--------------------------------------------------------------------------------------------------------------------------|<br/>
        /// | `index` = 0   | Value                                                                                                                    |<br/>
        /// | `index` = 1   | Percentage change, defined as the change between the current and previous periods&apos; values and expressed as a percentage. |<br/>
        /// <br/>
        /// The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest? request = null);
    }

    public class SalesMetricsSDK: ISalesMetricsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.3.0";
        private const string _sdkGenVersion = "2.139.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.3.0 2.139.1 3.0.0 Codat.Lending";
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
        

        public async Task<GetCommerceCustomerRetentionMetricsResponse> GetCustomerRetentionAsync(GetCommerceCustomerRetentionMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/customerRetention", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
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
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCommerceLifetimeValueMetricsResponse> GetLifetimeValueAsync(GetCommerceLifetimeValueMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/lifetimeValue", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
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
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCommerceRevenueMetricsResponse> GetRevenueAsync(GetCommerceRevenueMetricsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/connections/{connectionId}/assess/commerceMetrics/revenue", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
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
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceReport = JsonConvert.DeserializeObject<CommerceReport>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
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