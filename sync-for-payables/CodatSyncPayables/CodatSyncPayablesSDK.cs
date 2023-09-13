
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables
{
    using CodatSyncPayables.Models.Shared;
    using CodatSyncPayables.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatSyncPayablesSDK
    {
        public IAccountsSDK Accounts { get; }
        public IBillCreditNotesSDK BillCreditNotes { get; }
        public IBillPaymentsSDK BillPayments { get; }
        public IBillsSDK Bills { get; }
        public ICompaniesSDK Companies { get; }
        public ICompanyInfoSDK CompanyInfo { get; }
        public IConnectionsSDK Connections { get; }
        public IJournalEntriesSDK JournalEntries { get; }
        public IJournalsSDK Journals { get; }
        public IManageDataSDK ManageData { get; }
        public IPaymentMethodsSDK PaymentMethods { get; }
        public IPushOperationsSDK PushOperations { get; }
        public ISuppliersSDK Suppliers { get; }
        public ITaxRatesSDK TaxRates { get; }
        public ITrackingCategoriesSDK TrackingCategories { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatSyncPayablesSDK: ICodatSyncPayablesSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.0";
        private const string _sdkGenVersion = "2.109.3";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsSDK Accounts { get; private set; }
        public IBillCreditNotesSDK BillCreditNotes { get; private set; }
        public IBillPaymentsSDK BillPayments { get; private set; }
        public IBillsSDK Bills { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public ICompanyInfoSDK CompanyInfo { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IJournalEntriesSDK JournalEntries { get; private set; }
        public IJournalsSDK Journals { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public IPaymentMethodsSDK PaymentMethods { get; private set; }
        public IPushOperationsSDK PushOperations { get; private set; }
        public ISuppliersSDK Suppliers { get; private set; }
        public ITaxRatesSDK TaxRates { get; private set; }
        public ITrackingCategoriesSDK TrackingCategories { get; private set; }

        public CodatSyncPayablesSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatSyncPayablesSDK.ServerList[0];

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
            BillCreditNotes = new BillCreditNotesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BillPayments = new BillPaymentsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Bills = new BillsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CompanyInfo = new CompanyInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            JournalEntries = new JournalEntriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Journals = new JournalsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PaymentMethods = new PaymentMethodsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PushOperations = new PushOperationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new SuppliersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TaxRates = new TaxRatesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TrackingCategories = new TrackingCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}