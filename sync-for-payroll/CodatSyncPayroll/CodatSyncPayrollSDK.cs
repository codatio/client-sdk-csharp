
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll
{
    using CodatSyncPayroll.Models.Shared;
    using CodatSyncPayroll.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatSyncPayrollSDK
    {
        public IAccountsSDK Accounts { get; }
        public ICompaniesSDK Companies { get; }
        public IConnectionsSDK Connections { get; }
        public IJournalEntriesSDK JournalEntries { get; }
        public IJournalsSDK Journals { get; }
        public IManageDataSDK ManageData { get; }
        public IPushOperationsSDK PushOperations { get; }
        public ITrackingCategoriesSDK TrackingCategories { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatSyncPayrollSDK: ICodatSyncPayrollSDK
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
        public IAccountsSDK Accounts { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IJournalEntriesSDK JournalEntries { get; private set; }
        public IJournalsSDK Journals { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public IPushOperationsSDK PushOperations { get; private set; }
        public ITrackingCategoriesSDK TrackingCategories { get; private set; }

        public CodatSyncPayrollSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatSyncPayrollSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            Accounts = new AccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            JournalEntries = new JournalEntriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Journals = new JournalsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PushOperations = new PushOperationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TrackingCategories = new TrackingCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}