
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

    public interface IAccountsPayableSDK
    {
        public IAccountsPayableBillCreditNotesSDK BillCreditNotes { get; }
        public IAccountsPayableBillPaymentsSDK BillPayments { get; }
        public IAccountsPayableBillsSDK Bills { get; }
        public IAccountsPayableSuppliersSDK Suppliers { get; }
    }

    public class AccountsPayableSDK: IAccountsPayableSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.2.1";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsPayableBillCreditNotesSDK BillCreditNotes { get; private set; }
        public IAccountsPayableBillPaymentsSDK BillPayments { get; private set; }
        public IAccountsPayableBillsSDK Bills { get; private set; }
        public IAccountsPayableSuppliersSDK Suppliers { get; private set; }

        public AccountsPayableSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            BillCreditNotes = new AccountsPayableBillCreditNotesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BillPayments = new AccountsPayableBillPaymentsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Bills = new AccountsPayableBillsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new AccountsPayableSuppliersSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}