
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
    using Codat.Platform.Models.Errors;
    using Codat.Platform.Models.Shared;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Platform API: Platform API
    /// 
    /// <remarks>
    /// An API for the common components of all of Codat&apos;s products.<br/>
    /// <br/>
    /// These end points cover creating and managing your companies, data connections, and integrations.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/core-concepts/companies">Read about the building blocks of Codat...</a> | <a href="https://github.com/codatio/oas">See our OpenAPI spec</a> <br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Connection management | Configure connection management UI and retrieve access tokens for authentication. |<br/>
    /// | Groups | Define and manage sets of companies based on a chosen characteristic. |<br/>
    /// | Webhooks | Create and manage webhooks that listen to Codat&apos;s events. |<br/>
    /// | Integrations | Get a list of integrations supported by Codat and their logos. |<br/>
    /// | Refresh data | Initiate data refreshes, view pull status and history. |<br/>
    /// | Settings | Manage company profile configuration, sync settings, and API keys. |<br/>
    /// | Push data | Initiate and monitor Create, Update, and Delete operations. |<br/>
    /// | Supplemental data | Configure and pull additional data you can include in Codat&apos;s standard data types. |<br/>
    /// | Custom data type | Configure and pull additional data types that are not included in Codat&apos;s standardized data model. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public interface ICodatPlatform
    {

        /// <summary>
        /// Manage company profile configuration, sync settings, and API keys.
        /// </summary>
        public ISettings Settings { get; }

        /// <summary>
        /// Create and manage your SMB users&apos; companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Configure connection management UI and retrieve access tokens for authentication.
        /// </summary>
        public IConnectionManagement ConnectionManagement { get; }

        /// <summary>
        /// Create new and manage existing data connections for a company.
        /// </summary>
        public IConnections Connections { get; }

        /// <summary>
        /// Configure and pull additional data types that are not included in Codat&apos;s standardized data model.
        /// </summary>
        public ICustomDataType CustomDataType { get; }

        /// <summary>
        /// Initiate and monitor Create, Update, and Delete operations.
        /// </summary>
        public IPushData PushData { get; }

        /// <summary>
        /// Initiate data refreshes, view pull status and history.
        /// </summary>
        public IRefreshData RefreshData { get; }

        /// <summary>
        /// Define and manage sets of companies based on a chosen characteristic.
        /// </summary>
        public IGroups Groups { get; }

        /// <summary>
        /// Get a list of integrations supported by Codat and their logos.
        /// </summary>
        public IIntegrations Integrations { get; }

        /// <summary>
        /// Configure and pull additional data you can include in Codat&apos;s standard data types.
        /// </summary>
        public ISupplementalData SupplementalData { get; }

        /// <summary>
        /// Create and manage webhooks that listen to Codat&apos;s events.
        /// </summary>
        public IWebhooks Webhooks { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.codat.io",
        };

        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Platform API: Platform API
    /// 
    /// <remarks>
    /// An API for the common components of all of Codat&apos;s products.<br/>
    /// <br/>
    /// These end points cover creating and managing your companies, data connections, and integrations.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/core-concepts/companies">Read about the building blocks of Codat...</a> | <a href="https://github.com/codatio/oas">See our OpenAPI spec</a> <br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Connection management | Configure connection management UI and retrieve access tokens for authentication. |<br/>
    /// | Groups | Define and manage sets of companies based on a chosen characteristic. |<br/>
    /// | Webhooks | Create and manage webhooks that listen to Codat&apos;s events. |<br/>
    /// | Integrations | Get a list of integrations supported by Codat and their logos. |<br/>
    /// | Refresh data | Initiate data refreshes, view pull status and history. |<br/>
    /// | Settings | Manage company profile configuration, sync settings, and API keys. |<br/>
    /// | Push data | Initiate and monitor Create, Update, and Delete operations. |<br/>
    /// | Supplemental data | Configure and pull additional data you can include in Codat&apos;s standard data types. |<br/>
    /// | Custom data type | Configure and pull additional data types that are not included in Codat&apos;s standardized data model. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public class CodatPlatform: ICodatPlatform
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "3.6.0";
        private const string _sdkGenVersion = "2.314.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.6.0 2.314.0 3.0.0 Codat.Platform";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public ISettings Settings { get; private set; }
        public ICompanies Companies { get; private set; }
        public IConnectionManagement ConnectionManagement { get; private set; }
        public IConnections Connections { get; private set; }
        public ICustomDataType CustomDataType { get; private set; }
        public IPushData PushData { get; private set; }
        public IRefreshData RefreshData { get; private set; }
        public IGroups Groups { get; private set; }
        public IIntegrations Integrations { get; private set; }
        public ISupplementalData SupplementalData { get; private set; }
        public IWebhooks Webhooks { get; private set; }

        public CodatPlatform(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Settings = new Settings(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Companies = new Companies(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ConnectionManagement = new ConnectionManagement(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Connections = new Connections(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            CustomDataType = new CustomDataType(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            PushData = new PushData(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            RefreshData = new RefreshData(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Groups = new Groups(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Integrations = new Integrations(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            SupplementalData = new SupplementalData(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Webhooks = new Webhooks(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}