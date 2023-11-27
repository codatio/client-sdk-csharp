
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
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0";
        private const string _sdkGenVersion = "2.195.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0 2.195.2 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
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

        public Sales(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            Customers = new CodatLendingCustomers(_defaultClient, _securityClient, _serverUrl, Config);
            Disputes = new Disputes(_defaultClient, _securityClient, _serverUrl, Config);
            Locations = new Locations(_defaultClient, _securityClient, _serverUrl, Config);
            Orders = new Orders(_defaultClient, _securityClient, _serverUrl, Config);
            PaymentMethods = new PaymentMethods(_defaultClient, _securityClient, _serverUrl, Config);
            Payments = new CodatLendingSalesPayments(_defaultClient, _securityClient, _serverUrl, Config);
            ProductCategories = new ProductCategories(_defaultClient, _securityClient, _serverUrl, Config);
            Products = new Products(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new CodatLendingTransactions(_defaultClient, _securityClient, _serverUrl, Config);
            Metrics = new Metrics(_defaultClient, _securityClient, _serverUrl, Config);
            Reports = new CodatLendingReports(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}