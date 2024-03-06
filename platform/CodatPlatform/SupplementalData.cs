
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform
{
    using Codat.Platform.Models.Operations;
    using Codat.Platform.Models.Shared;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// View and configure supplemental data for supported data types.
    /// </summary>
    public interface ISupplementalData
    {

        /// <summary>
        /// Configure
        /// 
        /// <remarks>
        /// The *Configure* endpoint allows you to maintain or change configuration required to return supplemental data for each integration and data type combination.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/using-the-api/additional-data">Supplemental data</a> is additional data you can include in Codat&apos;s standard data types.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// See the *examples* for integration-specific frequently requested properties.
        /// </remarks>
        /// </summary>
        Task<ConfigureSupplementalDataResponse> ConfigureAsync(ConfigureSupplementalDataRequest request);

        /// <summary>
        /// Get configuration
        /// 
        /// <remarks>
        /// The *Get configuration* endpoint returns supplemental data configuration previously created for each integration and data type combination.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/using-the-api/additional-data">Supplemental data</a> is additional data you can include in Codat&apos;s standard data types.
        /// </remarks>
        /// </summary>
        Task<GetSupplementalDataConfigurationResponse> GetConfigurationAsync(GetSupplementalDataConfigurationRequest request);
    }

    /// <summary>
    /// View and configure supplemental data for supported data types.
    /// </summary>
    public class SupplementalData: ISupplementalData
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.5.0";
        private const string _sdkGenVersion = "2.277.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.5.0 2.277.0 3.0.0 Codat.Platform";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public SupplementalData(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<ConfigureSupplementalDataResponse> ConfigureAsync(ConfigureSupplementalDataRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "SupplementalDataConfiguration", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ConfigureSupplementalDataResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
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

        

        public async Task<GetSupplementalDataConfigurationResponse> GetConfigurationAsync(GetSupplementalDataConfigurationRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetSupplementalDataConfigurationResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.SupplementalDataConfiguration = JsonConvert.DeserializeObject<SupplementalDataConfiguration>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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