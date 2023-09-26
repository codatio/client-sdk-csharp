
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform
{
    using CodatPlatform.Models.Shared;
    using CodatPlatform.Utils;
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
    /// <a href="https://docs.codat.io/core-concepts/companies">Read about the building blocks of Codat...</a><br/>
    /// <br/>
    /// <a href="https://github.com/codatio/oas">See our OpenAPI spec</a> 
    /// </remarks>
    /// </summary>
    public interface ICodatPlatformSDK
    {

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; }

        /// <summary>
        /// Manage your companies&amp;apos; data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// View and manage your available integrations in Codat.
        /// </summary>
        public IIntegrationsSDK Integrations { get; }

        /// <summary>
        /// View push options and get push statuses.
        /// </summary>
        public IPushDataSDK PushData { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IRefreshDataSDK RefreshData { get; }

        /// <summary>
        /// Manage your Codat instance.
        /// </summary>
        public ISettingsSDK Settings { get; }

        /// <summary>
        /// View and configure supplemental data for supported data types.
        /// </summary>
        public ISupplementalDataSDK SupplementalData { get; }

        /// <summary>
        /// Manage webhooks, rules, and events.
        /// </summary>
        public IWebhooksSDK Webhooks { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Platform API: Platform API
    /// 
    /// <remarks>
    /// An API for the common components of all of Codat&apos;s products.<br/>
    /// <br/>
    /// These end points cover creating and managing your companies, data connections, and integrations.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/core-concepts/companies">Read about the building blocks of Codat...</a><br/>
    /// <br/>
    /// <a href="https://github.com/codatio/oas">See our OpenAPI spec</a> 
    /// </remarks>
    /// </summary>
    public class CodatPlatformSDK: ICodatPlatformSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.1.1";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ICompaniesSDK Companies { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IIntegrationsSDK Integrations { get; private set; }
        public IPushDataSDK PushData { get; private set; }
        public IRefreshDataSDK RefreshData { get; private set; }
        public ISettingsSDK Settings { get; private set; }
        public ISupplementalDataSDK SupplementalData { get; private set; }
        public IWebhooksSDK Webhooks { get; private set; }

        public CodatPlatformSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatPlatformSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Integrations = new IntegrationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PushData = new PushDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            RefreshData = new RefreshDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Settings = new SettingsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            SupplementalData = new SupplementalDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Webhooks = new WebhooksSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}