
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Models.Operations;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Match mutable accounting data with immutable banking data to increase confidence in financial data.
    /// </summary>
    public interface IDataIntegrity
    {

        /// <summary>
        /// List data integrity details
        /// 
        /// <remarks>
        /// The *List data integrity details* endpoint returns the match result record by record for a given data type, filtered based on a query string in the same way as summary results.<br/>
        /// <br/>
        /// The <a href="https://docs.codat.io/lending-api#/schemas/DataIntegrityDetails">details</a> are paginated and support ordering, following the same conventions as our other data endpoints.
        /// </remarks>
        /// </summary>
        Task<ListDataIntegrityDetailsResponse> DetailsAsync(ListDataIntegrityDetailsRequest? request = null);

        /// <summary>
        /// Get data integrity status
        /// 
        /// <remarks>
        /// The *Get data integrity status* endpoint returns the <a href="https://docs.codat.io/lending-api#/schemas/DataIntegrityStatus">status</a> for the company’s match results between the data type provided in the URL and other data types that Data Integrity uses to support matching.<br/>
        /// This endpoint helps you understand whether match data is available and, if so, how to usefully query it.<br/>
        /// <br/>
        /// The response tells you:<br/>
        /// <br/>
        /// - Whether match results are available.<br/>
        /// - When the results were generated, and their status.<br/>
        /// - The connection IDs, amounts, and dates involved to support useful querying.
        /// </remarks>
        /// </summary>
        Task<GetDataIntegrityStatusResponse> StatusAsync(GetDataIntegrityStatusRequest? request = null);

        /// <summary>
        /// Get data integrity summaries
        /// 
        /// <remarks>
        /// The *Get data integrity summary* endpoint returns a <a href="https://docs.codat.io/lending-api#/schemas/DataIntegritySummary">summary</a> of match results for a given data type filtered by a query string in the <a href="https://docs.codat.io/using-the-api/querying">Codat query language</a>. <br/>
        /// <br/>
        /// For example, if you wanted to see summary match results only for transactions after 1 December 2020, you could include a query parameter of `query=date&gt;2020-12-01`.<br/>
        /// <br/>
        /// The endpoint response includes only the summary results, not transactions. To view match data for transactions, use the <a href="https://docs.codat.io/lending-api#/operations/list-data-type-data-integrity-details">List data integrity details</a> endpoint.
        /// </remarks>
        /// </summary>
        Task<GetDataIntegritySummariesResponse> SummariesAsync(GetDataIntegritySummariesRequest? request = null);
    }

    /// <summary>
    /// Match mutable accounting data with immutable banking data to increase confidence in financial data.
    /// </summary>
    public class DataIntegrity: IDataIntegrity
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.3.0";
        private const string _sdkGenVersion = "2.257.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.3.0 2.257.2 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public DataIntegrity(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<ListDataIntegrityDetailsResponse> DetailsAsync(ListDataIntegrityDetailsRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/dataTypes/{dataType}/dataIntegrity/details", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListDataIntegrityDetailsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.DataIntegrityDetails = JsonConvert.DeserializeObject<DataIntegrityDetails>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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

        

        public async Task<GetDataIntegrityStatusResponse> StatusAsync(GetDataIntegrityStatusRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/dataTypes/{dataType}/dataIntegrity/status", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetDataIntegrityStatusResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.DataIntegrityStatuses = JsonConvert.DeserializeObject<DataIntegrityStatuses>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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

        

        public async Task<GetDataIntegritySummariesResponse> SummariesAsync(GetDataIntegritySummariesRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/data/companies/{companyId}/assess/dataTypes/{dataType}/dataIntegrity/summaries", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetDataIntegritySummariesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.DataIntegritySummaries = JsonConvert.DeserializeObject<DataIntegritySummaries>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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

        
    }
}