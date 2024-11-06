//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Models.Components;
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Utils;
    using System;

    public interface IAccountsReceivable
    {
        public IInvoices Invoices { get; }
        public ICreditNotes CreditNotes { get; }
        public ICustomers Customers { get; }
        public IDirectIncomes DirectIncomes { get; }
        public IPayments Payments { get; }
        public ICodatLendingReports Reports { get; }
    }

    public class AccountsReceivable: IAccountsReceivable
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "7.0.0";
        private const string _sdkGenVersion = "2.451.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 7.0.0 2.451.0 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Lending.Models.Components.Security>? _securitySource;
        public IInvoices Invoices { get; private set; }
        public ICreditNotes CreditNotes { get; private set; }
        public ICustomers Customers { get; private set; }
        public IDirectIncomes DirectIncomes { get; private set; }
        public IPayments Payments { get; private set; }
        public ICodatLendingReports Reports { get; private set; }

        public AccountsReceivable(ISpeakeasyHttpClient client, Func<Codat.Lending.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Invoices = new Invoices(_client, _securitySource, _serverUrl, SDKConfiguration);
            CreditNotes = new CreditNotes(_client, _securitySource, _serverUrl, SDKConfiguration);
            Customers = new Customers(_client, _securitySource, _serverUrl, SDKConfiguration);
            DirectIncomes = new DirectIncomes(_client, _securitySource, _serverUrl, SDKConfiguration);
            Payments = new Payments(_client, _securitySource, _serverUrl, SDKConfiguration);
            Reports = new CodatLendingReports(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}