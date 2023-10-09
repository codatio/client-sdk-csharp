
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
    using CodatLending.Utils;
    using System;

    public interface IAccountsReceivableSDK
    {
        public IAccountsReceivableCreditNotesSDK CreditNotes { get; }
        public IAccountsReceivableCustomersSDK Customers { get; }
        public IAccountsReceivableDirectIncomesSDK DirectIncomes { get; }
        public IAccountsReceivableInvoicesSDK Invoices { get; }
        public IAccountsReceivablePaymentsSDK Payments { get; }
        public IAccountsReceivableReportsSDK Reports { get; }
    }

    public class AccountsReceivableSDK: IAccountsReceivableSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.3.0";
        private const string _sdkGenVersion = "2.150.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.3.0 2.150.0 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsReceivableCreditNotesSDK CreditNotes { get; private set; }
        public IAccountsReceivableCustomersSDK Customers { get; private set; }
        public IAccountsReceivableDirectIncomesSDK DirectIncomes { get; private set; }
        public IAccountsReceivableInvoicesSDK Invoices { get; private set; }
        public IAccountsReceivablePaymentsSDK Payments { get; private set; }
        public IAccountsReceivableReportsSDK Reports { get; private set; }

        public AccountsReceivableSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            CreditNotes = new AccountsReceivableCreditNotesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Customers = new AccountsReceivableCustomersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DirectIncomes = new AccountsReceivableDirectIncomesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Invoices = new AccountsReceivableInvoicesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Payments = new AccountsReceivablePaymentsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Reports = new AccountsReceivableReportsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}