
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

    public interface IAccountsReceivable
    {
        public ICustomers Customers { get; }
        public IDirectIncomes DirectIncomes { get; }
        public IInvoices Invoices { get; }
        public ICreditNotes CreditNotes { get; }
        public IPayments Payments { get; }
        public IReports Reports { get; }
    }

    public class AccountsReceivable: IAccountsReceivable
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0";
        private const string _sdkGenVersion = "2.210.3";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0 2.210.3 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ICustomers Customers { get; private set; }
        public IDirectIncomes DirectIncomes { get; private set; }
        public IInvoices Invoices { get; private set; }
        public ICreditNotes CreditNotes { get; private set; }
        public IPayments Payments { get; private set; }
        public IReports Reports { get; private set; }

        public AccountsReceivable(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Customers = new Customers(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            DirectIncomes = new DirectIncomes(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Invoices = new Invoices(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            CreditNotes = new CreditNotes(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Payments = new Payments(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Reports = new Reports(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
        
    }
}