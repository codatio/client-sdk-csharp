
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce
{
    using CodatSyncCommerce.Models.Shared;
    using CodatSyncCommerce.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatSyncCommerceSDK
    {
        public IAdvancedControlsSDK AdvancedControls { get; }
        public IConnectionsSDK Connections { get; }
        public IIntegrationsSDK Integrations { get; }
        public ISyncSDK Sync { get; }
        public ISyncFlowPreferencesSDK SyncFlowPreferences { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatSyncCommerceSDK: ICodatSyncCommerceSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.91.4";
        private const string _openapiDocVersion = "1.1";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAdvancedControlsSDK AdvancedControls { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IIntegrationsSDK Integrations { get; private set; }
        public ISyncSDK Sync { get; private set; }
        public ISyncFlowPreferencesSDK SyncFlowPreferences { get; private set; }

        public CodatSyncCommerceSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatSyncCommerceSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            AdvancedControls = new AdvancedControlsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Integrations = new IntegrationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Sync = new SyncSDK(_defaultClient, _securityClient, _serverUrl, Config);
            SyncFlowPreferences = new SyncFlowPreferencesSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}