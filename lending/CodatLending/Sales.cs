
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

    public interface ISalesSDK
    {
        public ISalesCustomersSDK Customers { get; }
        public ISalesDisputesSDK Disputes { get; }
        public ISalesLocationsSDK Locations { get; }
        public ISalesMetricsSDK Metrics { get; }
        public ISalesOrdersSDK Orders { get; }
        public ISalesPaymentMethodsSDK PaymentMethods { get; }
        public ISalesPaymentsSDK Payments { get; }
        public ISalesProductCategoriesSDK ProductCategories { get; }
        public ISalesProductsSDK Products { get; }
        public ISalesReportsSDK Reports { get; }
        public ISalesTransactionsSDK Transactions { get; }
    }

    public class SalesSDK: ISalesSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.1.0";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ISalesCustomersSDK Customers { get; private set; }
        public ISalesDisputesSDK Disputes { get; private set; }
        public ISalesLocationsSDK Locations { get; private set; }
        public ISalesMetricsSDK Metrics { get; private set; }
        public ISalesOrdersSDK Orders { get; private set; }
        public ISalesPaymentMethodsSDK PaymentMethods { get; private set; }
        public ISalesPaymentsSDK Payments { get; private set; }
        public ISalesProductCategoriesSDK ProductCategories { get; private set; }
        public ISalesProductsSDK Products { get; private set; }
        public ISalesReportsSDK Reports { get; private set; }
        public ISalesTransactionsSDK Transactions { get; private set; }

        public SalesSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            Customers = new SalesCustomersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Disputes = new SalesDisputesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Locations = new SalesLocationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Metrics = new SalesMetricsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Orders = new SalesOrdersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PaymentMethods = new SalesPaymentMethodsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Payments = new SalesPaymentsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ProductCategories = new SalesProductCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Products = new SalesProductsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Reports = new SalesReportsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new SalesTransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}