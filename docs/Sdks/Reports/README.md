# reports

## Overview

Data integrity is important

### Available Operations

* [GetAccountsForEnhancedBalanceSheet](#getaccountsforenhancedbalancesheet) - Get enhanced balance sheet accounts
* [GetAccountsForEnhancedProfitAndLoss](#getaccountsforenhancedprofitandloss) - Get enhanced profit and loss accounts
* [GetCommerceCustomerRetentionMetrics](#getcommercecustomerretentionmetrics) - Get customer retention metrics
* [GetCommerceLifetimeValueMetrics](#getcommercelifetimevaluemetrics) - Get lifetime value metric
* [GetCommerceOrdersMetrics](#getcommerceordersmetrics) - Get orders report
* [GetCommerceRefundsMetrics](#getcommercerefundsmetrics) - Get refunds report
* [GetCommerceRevenueMetrics](#getcommercerevenuemetrics) - Get commerce revenue metrics
* [~~GetEnhancedBalanceSheet~~](#getenhancedbalancesheet) - Get enhanced balance sheet report :warning: **Deprecated**
* [GetEnhancedCashFlowTransactions](#getenhancedcashflowtransactions) - Get enhanced cash flow report
* [~~GetEnhancedFinancialMetrics~~](#getenhancedfinancialmetrics) - List financial metrics :warning: **Deprecated**
* [GetEnhancedInvoicesReport](#getenhancedinvoicesreport) - Get enhanced invoices report
* [~~GetEnhancedProfitAndLoss~~](#getenhancedprofitandloss) - Get enhanced profit and loss report :warning: **Deprecated**
* [GetRecurringRevenueMetrics](#getrecurringrevenuemetrics) - Get key subscription revenue metrics
* [RequestRecurringRevenueMetrics](#requestrecurringrevenuemetrics) - Generate key subscription revenue metrics

## GetAccountsForEnhancedBalanceSheet

The Enhanced Balance Sheet Accounts endpoint returns a list of categorized accounts that appear on a company’s Balance Sheet along with a balance per financial statement date.

Codat suggests a category for each account automatically, but you can [change it](/docs/assess-categorizing-accounts-ecommerce-lending) to a more suitable one.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetAccountsForEnhancedBalanceSheet(request);
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                      | [GetAccountsForEnhancedBalanceSheetRequest](../../Models/Reports/GetAccountsForEnhancedBalanceSheetRequest.md) | :heavy_check_mark:                                                                                             | The request object to use for the request.                                                                     |


### Response

**[GetAccountsForEnhancedBalanceSheetResponse](../../Models/Reports/GetAccountsForEnhancedBalanceSheetResponse.md)**


## GetAccountsForEnhancedProfitAndLoss

The Enhanced Profit and Loss Accounts endpoint returns a list of categorized accounts that appear on a company’s Profit and Loss. It also includes a balance per the financial statement date.

Codat suggests a category for each account automatically, but you can [change it](/docs/assess-categorizing-accounts-ecommerce-lending) to a more suitable one.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetAccountsForEnhancedProfitAndLoss(request);
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                        | [GetAccountsForEnhancedProfitAndLossRequest](../../Models/Reports/GetAccountsForEnhancedProfitAndLossRequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |


### Response

**[GetAccountsForEnhancedProfitAndLossResponse](../../Models/Reports/GetAccountsForEnhancedProfitAndLossResponse.md)**


## GetCommerceCustomerRetentionMetrics

Gets the customer retention metrics for a specific company connection, over one or more periods of time.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetCommerceCustomerRetentionMetrics(request);
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                        | [GetCommerceCustomerRetentionMetricsRequest](../../Models/Reports/GetCommerceCustomerRetentionMetricsRequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |


### Response

**[GetCommerceCustomerRetentionMetricsResponse](../../Models/Reports/GetCommerceCustomerRetentionMetricsResponse.md)**


## GetCommerceLifetimeValueMetrics

Gets the lifetime value metric for a specific company connection, over one or more periods of time.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetCommerceLifetimeValueMetrics(request);
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                | [GetCommerceLifetimeValueMetricsRequest](../../Models/Reports/GetCommerceLifetimeValueMetricsRequest.md) | :heavy_check_mark:                                                                                       | The request object to use for the request.                                                               |


### Response

**[GetCommerceLifetimeValueMetricsResponse](../../Models/Reports/GetCommerceLifetimeValueMetricsResponse.md)**


## GetCommerceOrdersMetrics

Gets the order information for a specific company connection, over one or more periods of time.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetCommerceOrdersMetrics(request);
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `request`                                                                                  | [GetCommerceOrdersMetricsRequest](../../Models/Reports/GetCommerceOrdersMetricsRequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |


### Response

**[GetCommerceOrdersMetricsResponse](../../Models/Reports/GetCommerceOrdersMetricsResponse.md)**


## GetCommerceRefundsMetrics

Gets the refunds information for a specific company connection, over one or more periods of time.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetCommerceRefundsMetrics(request);
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `request`                                                                                    | [GetCommerceRefundsMetricsRequest](../../Models/Reports/GetCommerceRefundsMetricsRequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |


### Response

**[GetCommerceRefundsMetricsResponse](../../Models/Reports/GetCommerceRefundsMetricsResponse.md)**


## GetCommerceRevenueMetrics

Get the revenue and revenue growth for a specific company connection, over one or more periods of time.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetCommerceRevenueMetrics(request);
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `request`                                                                                    | [GetCommerceRevenueMetricsRequest](../../Models/Reports/GetCommerceRevenueMetricsRequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |


### Response

**[GetCommerceRevenueMetricsResponse](../../Models/Reports/GetCommerceRevenueMetricsResponse.md)**


## ~~GetEnhancedBalanceSheet~~

Gets a fully categorized balance sheet statement for a given company, over one or more period(s).

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetEnhancedBalanceSheet(request);
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [GetEnhancedBalanceSheetRequest](../../Models/Reports/GetEnhancedBalanceSheetRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |


### Response

**[GetEnhancedBalanceSheetResponse](../../Models/Reports/GetEnhancedBalanceSheetResponse.md)**


## GetEnhancedCashFlowTransactions

> **Categorization engine**
> 
> The categorization engine uses machine learning and has been fully trained against Plaid and TrueLayer banking data sources. It is not fully trained against the Basiq banking data source.

The Enhanced Cash Flow Transactions endpoint provides a fully categorized list of banking transactions for a company. Accounts and transaction data are obtained from the company's banking data sources.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetEnhancedCashFlowTransactions(request);
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                | [GetEnhancedCashFlowTransactionsRequest](../../Models/Reports/GetEnhancedCashFlowTransactionsRequest.md) | :heavy_check_mark:                                                                                       | The request object to use for the request.                                                               |


### Response

**[GetEnhancedCashFlowTransactionsResponse](../../Models/Reports/GetEnhancedCashFlowTransactionsResponse.md)**


## ~~GetEnhancedFinancialMetrics~~

Gets all the available financial metrics for a given company, over one or more periods.

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetEnhancedFinancialMetrics(request);
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `request`                                                                                        | [GetEnhancedFinancialMetricsRequest](../../Models/Reports/GetEnhancedFinancialMetricsRequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |


### Response

**[GetEnhancedFinancialMetricsResponse](../../Models/Reports/GetEnhancedFinancialMetricsResponse.md)**


## GetEnhancedInvoicesReport

Gets a list of invoices linked to the corresponding banking transaction

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetEnhancedInvoicesReport(request);
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `request`                                                                                    | [GetEnhancedInvoicesReportRequest](../../Models/Reports/GetEnhancedInvoicesReportRequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |


### Response

**[GetEnhancedInvoicesReportResponse](../../Models/Reports/GetEnhancedInvoicesReportResponse.md)**


## ~~GetEnhancedProfitAndLoss~~

Gets a fully categorized profit and loss statement for a given company, over one or more period(s).

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetEnhancedProfitAndLoss(request);
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `request`                                                                                  | [GetEnhancedProfitAndLossRequest](../../Models/Reports/GetEnhancedProfitAndLossRequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |


### Response

**[GetEnhancedProfitAndLossResponse](../../Models/Reports/GetEnhancedProfitAndLossResponse.md)**


## GetRecurringRevenueMetrics

Gets key metrics for subscription revenue.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.GetRecurringRevenueMetrics(request);
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `request`                                                                                      | [GetRecurringRevenueMetricsRequest](../../Models/Reports/GetRecurringRevenueMetricsRequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |


### Response

**[GetRecurringRevenueMetricsResponse](../../Models/Reports/GetRecurringRevenueMetricsResponse.md)**


## RequestRecurringRevenueMetrics

Requests production of key subscription revenue metrics.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Reports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Reports.RequestRecurringRevenueMetrics(request);
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `request`                                                                                              | [RequestRecurringRevenueMetricsRequest](../../Models/Reports/RequestRecurringRevenueMetricsRequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |


### Response

**[RequestRecurringRevenueMetricsResponse](../../Models/Reports/RequestRecurringRevenueMetricsResponse.md)**

