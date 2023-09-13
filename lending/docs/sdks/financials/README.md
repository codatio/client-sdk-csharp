# financials

## Overview

Financial data and reports from a linked accounting platform.

### Available Operations

* [GetAccount](#getaccount) - Get account
* [GetBalanceSheet](#getbalancesheet) - Get balance sheet
* [GetCashFlowStatement](#getcashflowstatement) - Get cash flow statement
* [GetEnhancedBalanceSheetAccounts](#getenhancedbalancesheetaccounts) - Get enhanced balance sheet accounts
* [GetEnhancedProfitAndLossAccounts](#getenhancedprofitandlossaccounts) - Get enhanced profit and loss accounts
* [GetProfitAndLoss](#getprofitandloss) - Get profit and loss
* [ListAccounts](#listaccounts) - List accounts

## GetAccount

The *Get account* endpoint returns a single account for a given accountId.

[Accounts](https://docs.codat.io/accounting-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support getting a specific account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetAccountAsync(new GetAccountingAccountRequest() {
    AccountId = "qui",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingAccountRequest](../../models/operations/GetAccountingAccountRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingAccountResponse](../../models/operations/GetAccountingAccountResponse.md)**


## GetBalanceSheet

Gets the latest balance sheet for a company.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetBalanceSheetAsync(new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00.000Z",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetAccountingBalanceSheetRequest](../../models/operations/GetAccountingBalanceSheetRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetAccountingBalanceSheetResponse](../../models/operations/GetAccountingBalanceSheetResponse.md)**


## GetCashFlowStatement

Gets the latest cash flow statement for a company.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetCashFlowStatementAsync(new GetAccountingCashFlowStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00.000Z",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingCashFlowStatementRequest](../../models/operations/GetAccountingCashFlowStatementRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingCashFlowStatementResponse](../../models/operations/GetAccountingCashFlowStatementResponse.md)**


## GetEnhancedBalanceSheetAccounts

﻿The *Get enhanced balance sheet accounts* endpoint returns a list of categorized accounts that appear on a company’s Balance Sheet along with a balance per financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/enhanced-financials/overview#categorize-accounts) to a more suitable one.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetEnhancedBalanceSheetAccountsAsync(new GetEnhancedBalanceSheetAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 456150,
    ReportDate = "29-09-2020",
});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetEnhancedBalanceSheetAccountsRequest](../../models/operations/GetEnhancedBalanceSheetAccountsRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |


### Response

**[GetEnhancedBalanceSheetAccountsResponse](../../models/operations/GetEnhancedBalanceSheetAccountsResponse.md)**


## GetEnhancedProfitAndLossAccounts

﻿The *Get enhanced profit and loss accounts* endpoint returns a list of categorized accounts that appear on a company’s Profit and Loss statement. It also includes a balance as of the financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/enhanced-financials/overview#categorize-accounts) to a more suitable one.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetEnhancedProfitAndLossAccountsAsync(new GetEnhancedProfitAndLossAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 216550,
    ReportDate = "29-09-2020",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetEnhancedProfitAndLossAccountsRequest](../../models/operations/GetEnhancedProfitAndLossAccountsRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetEnhancedProfitAndLossAccountsResponse](../../models/operations/GetEnhancedProfitAndLossAccountsResponse.md)**


## GetProfitAndLoss

Gets the latest profit and loss for a company.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.GetProfitAndLossAsync(new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00.000Z",
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetAccountingProfitAndLossRequest](../../models/operations/GetAccountingProfitAndLossRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[GetAccountingProfitAndLossResponse](../../models/operations/GetAccountingProfitAndLossResponse.md)**


## ListAccounts

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/accounting-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/accounting-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Financials.ListAccountsAsync(new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "aspernatur",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingAccountsRequest](../../models/operations/ListAccountingAccountsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingAccountsResponse](../../models/operations/ListAccountingAccountsResponse.md)**

