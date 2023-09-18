
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

    public interface IFinancialStatementsSDK
    {
        public IFinancialStatementsAccountsSDK Accounts { get; }
        public IFinancialStatementsBalanceSheetSDK BalanceSheet { get; }
        public IFinancialStatementsCashFlowSDK CashFlow { get; }
        public IFinancialStatementsProfitAndLossSDK ProfitAndLoss { get; }
    }

    public class FinancialStatementsSDK: IFinancialStatementsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.1.0";
        private const string _sdkGenVersion = "2.116.0";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IFinancialStatementsAccountsSDK Accounts { get; private set; }
        public IFinancialStatementsBalanceSheetSDK BalanceSheet { get; private set; }
        public IFinancialStatementsCashFlowSDK CashFlow { get; private set; }
        public IFinancialStatementsProfitAndLossSDK ProfitAndLoss { get; private set; }

        public FinancialStatementsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            Accounts = new FinancialStatementsAccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BalanceSheet = new FinancialStatementsBalanceSheetSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CashFlow = new FinancialStatementsCashFlowSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ProfitAndLoss = new FinancialStatementsProfitAndLossSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}