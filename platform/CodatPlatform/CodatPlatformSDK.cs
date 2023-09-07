
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

    public interface ICodatPlatformSDK
    {
        public ICompaniesSDK Companies { get; }
        public IConnectionsSDK Connections { get; }
        public IIntegrationsSDK Integrations { get; }
        public IPushDataSDK PushData { get; }
        public IRefreshDataSDK RefreshData { get; }
        public ISettingsSDK Settings { get; }
        public ISupplementalDataSDK SupplementalData { get; }
        public IWebhooksSDK Webhooks { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatPlatformSDK: ICodatPlatformSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.91.4";
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