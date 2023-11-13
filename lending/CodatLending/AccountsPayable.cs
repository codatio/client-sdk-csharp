
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Utils;
    using System;

    public interface IAccountsPayable
    {
        public IBills Bills { get; }
        public ISuppliers Suppliers { get; }
        public IBillCreditNotes BillCreditNotes { get; }
        public IBillPayments BillPayments { get; }
    }

    public class AccountsPayable: IAccountsPayable
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0";
        private const string _sdkGenVersion = "2.188.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0 2.188.1 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IBills Bills { get; private set; }
        public ISuppliers Suppliers { get; private set; }
        public IBillCreditNotes BillCreditNotes { get; private set; }
        public IBillPayments BillPayments { get; private set; }

        public AccountsPayable(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            Bills = new Bills(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new Suppliers(_defaultClient, _securityClient, _serverUrl, Config);
            BillCreditNotes = new BillCreditNotes(_defaultClient, _securityClient, _serverUrl, Config);
            BillPayments = new BillPayments(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}