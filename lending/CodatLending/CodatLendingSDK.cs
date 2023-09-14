
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending
{
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatLendingSDK
    {
        public IAccountingBankDataSDK AccountingBankData { get; }
        public ICompaniesSDK Companies { get; }
        public ICompanyInfoSDK CompanyInfo { get; }
        public IConnectionsSDK Connections { get; }
        public IDataIntegritySDK DataIntegrity { get; }
        public IExcelReportsSDK ExcelReports { get; }
        public IFileUploadSDK FileUpload { get; }
        public ILiabilitiesSDK Liabilities { get; }
        public IAccountsPayableSDK AccountsPayable { get; }
        public IAccountsReceivableSDK AccountsReceivable { get; }
        public IBankingSDK Banking { get; }
        public IFinancialStatementsSDK FinancialStatements { get; }
        public IManageDataSDK ManageData { get; }
        public ISalesSDK Sales { get; }
        public ITransactionsSDK Transactions { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatLendingSDK: ICodatLendingSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.1.0";
        private const string _sdkGenVersion = "2.109.3";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountingBankDataSDK AccountingBankData { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public ICompanyInfoSDK CompanyInfo { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IDataIntegritySDK DataIntegrity { get; private set; }
        public IExcelReportsSDK ExcelReports { get; private set; }
        public IFileUploadSDK FileUpload { get; private set; }
        public ILiabilitiesSDK Liabilities { get; private set; }
        public IAccountsPayableSDK AccountsPayable { get; private set; }
        public IAccountsReceivableSDK AccountsReceivable { get; private set; }
        public IBankingSDK Banking { get; private set; }
        public IFinancialStatementsSDK FinancialStatements { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public ISalesSDK Sales { get; private set; }
        public ITransactionsSDK Transactions { get; private set; }

        public CodatLendingSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatLendingSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            AccountingBankData = new AccountingBankDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CompanyInfo = new CompanyInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DataIntegrity = new DataIntegritySDK(_defaultClient, _securityClient, _serverUrl, Config);
            ExcelReports = new ExcelReportsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            FileUpload = new FileUploadSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Liabilities = new LiabilitiesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            AccountsPayable = new AccountsPayableSDK(_defaultClient, _securityClient, _serverUrl, Config);
            AccountsReceivable = new AccountsReceivableSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Banking = new BankingSDK(_defaultClient, _securityClient, _serverUrl, Config);
            FinancialStatements = new FinancialStatementsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Sales = new SalesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new TransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}