
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
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using System;

    public interface ISales
    {
        public ICodatLendingCustomers Customers { get; }
        public IDisputes Disputes { get; }
        public ILocations Locations { get; }
        public IOrders Orders { get; }
        public IPaymentMethods PaymentMethods { get; }
        public ICodatLendingSalesPayments Payments { get; }
        public IProductCategories ProductCategories { get; }
        public IProducts Products { get; }
        public ICodatLendingTransactions Transactions { get; }
        public IMetrics Metrics { get; }
        public ICodatLendingReports Reports { get; }
    }

    public class Sales: ISales
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.4.0";
        private const string _sdkGenVersion = "2.319.7";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.4.0 2.319.7 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public ICodatLendingCustomers Customers { get; private set; }
        public IDisputes Disputes { get; private set; }
        public ILocations Locations { get; private set; }
        public IOrders Orders { get; private set; }
        public IPaymentMethods PaymentMethods { get; private set; }
        public ICodatLendingSalesPayments Payments { get; private set; }
        public IProductCategories ProductCategories { get; private set; }
        public IProducts Products { get; private set; }
        public ICodatLendingTransactions Transactions { get; private set; }
        public IMetrics Metrics { get; private set; }
        public ICodatLendingReports Reports { get; private set; }

        public Sales(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Customers = new CodatLendingCustomers(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Disputes = new Disputes(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Locations = new Locations(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Orders = new Orders(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            PaymentMethods = new PaymentMethods(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Payments = new CodatLendingSalesPayments(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ProductCategories = new ProductCategories(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Products = new Products(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Transactions = new CodatLendingTransactions(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Metrics = new Metrics(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Reports = new CodatLendingReports(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}