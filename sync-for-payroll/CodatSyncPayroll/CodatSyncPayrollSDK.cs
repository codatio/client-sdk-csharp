
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

    /// <summary>
    /// Sync for Payroll: The API for Sync for Payroll. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Payroll is an API and a set of supporting tools built to help integrate your customers&apos; payroll data from their HR and payroll platforms into their accounting platforms and to support its reconciliation.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/payroll/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Accounts             | Get, create, and update Accounts.                                                           |<br/>
    /// | Journal entries      | Get, create, and update Journal entries.                                                           |<br/>
    /// | Journals             | Get, create, and update Journals.                                                           |<br/>
    /// | Tracking categories  | Get, create, and update Tracking Categories for additional categorization of payroll components.                                                           |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |
    /// </remarks>
    /// </summary>
    public interface ICodatSyncPayrollSDK
    {

        /// <summary>
        /// Accounts
        /// </summary>
        public IAccountsSDK Accounts { get; }

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; }

        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfoSDK CompanyInfo { get; }

        /// <summary>
        /// Manage your companies&apos; data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// Journal entries
        /// </summary>
        public IJournalEntriesSDK JournalEntries { get; }

        /// <summary>
        /// Journals
        /// </summary>
        public IJournalsSDK Journals { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IManageDataSDK ManageData { get; }

        /// <summary>
        /// Tracking categories
        /// </summary>
        public ITrackingCategoriesSDK TrackingCategories { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Sync for Payroll: The API for Sync for Payroll. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Payroll is an API and a set of supporting tools built to help integrate your customers&apos; payroll data from their HR and payroll platforms into their accounting platforms and to support its reconciliation.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/payroll/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Accounts             | Get, create, and update Accounts.                                                           |<br/>
    /// | Journal entries      | Get, create, and update Journal entries.                                                           |<br/>
    /// | Journals             | Get, create, and update Journals.                                                           |<br/>
    /// | Tracking categories  | Get, create, and update Tracking Categories for additional categorization of payroll components.                                                           |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |
    /// </remarks>
    /// </summary>
    public class CodatSyncPayrollSDK: ICodatSyncPayrollSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.0";
        private const string _sdkGenVersion = "2.169.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.3.0 2.169.0 3.0.0 Codat.Sync.Payroll";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsSDK Accounts { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public ICompanyInfoSDK CompanyInfo { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IJournalEntriesSDK JournalEntries { get; private set; }
        public IJournalsSDK Journals { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
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
            CompanyInfo = new CompanyInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            JournalEntries = new JournalEntriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Journals = new JournalsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TrackingCategories = new TrackingCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}