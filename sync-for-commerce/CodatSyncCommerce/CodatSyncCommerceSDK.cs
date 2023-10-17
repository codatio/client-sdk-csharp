
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

    /// <summary>
    /// Sync for Commerce: The API for Sync for Commerce. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Commerce automatically replicates and reconciles sales data from a merchant’s source PoS, Payments, and eCommerce systems into their accounting software. This eliminates manual processing by merchants and transforms their ability to run and grow their business.<br/>
    ///   <br/>
    /// <a href="https://docs.codat.io/commerce/overview">Read More...</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-commerce-v1-api#/">different version of Sync for Commerce</a>.
    /// </remarks>
    /// </summary>
    public interface ICodatSyncCommerceSDK
    {

        /// <summary>
        /// Advanced company management and sync preferences.
        /// </summary>
        public IAdvancedControlsSDK AdvancedControls { get; }

        /// <summary>
        /// Create new and manage existing Sync for Commerce connections using the Sync flow UI.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// View useful information about codat&apos;s integrations.
        /// </summary>
        public IIntegrationsSDK Integrations { get; }

        /// <summary>
        /// Initiate and monitor the sync of company data into accounting software.
        /// </summary>
        public ISyncSDK Sync { get; }

        /// <summary>
        /// Configure preferences for any given Sync for Commerce company using sync flow.
        /// </summary>
        public ISyncFlowSettingsSDK SyncFlowSettings { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Sync for Commerce: The API for Sync for Commerce. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Commerce automatically replicates and reconciles sales data from a merchant’s source PoS, Payments, and eCommerce systems into their accounting software. This eliminates manual processing by merchants and transforms their ability to run and grow their business.<br/>
    ///   <br/>
    /// <a href="https://docs.codat.io/commerce/overview">Read More...</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-commerce-v1-api#/">different version of Sync for Commerce</a>.
    /// </remarks>
    /// </summary>
    public class CodatSyncCommerceSDK: ICodatSyncCommerceSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.2.0";
        private const string _sdkGenVersion = "2.159.2";
        private const string _openapiDocVersion = "1.1";
        private const string _userAgent = "speakeasy-sdk/csharp 2.2.0 2.159.2 1.1 Codat.Sync.Commerce";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAdvancedControlsSDK AdvancedControls { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IIntegrationsSDK Integrations { get; private set; }
        public ISyncSDK Sync { get; private set; }
        public ISyncFlowSettingsSDK SyncFlowSettings { get; private set; }

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
            SyncFlowSettings = new SyncFlowSettingsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}