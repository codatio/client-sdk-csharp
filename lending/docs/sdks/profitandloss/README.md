# FinancialStatements.ProfitAndLoss

## Overview

### Available Operations

* [GetCategorizedAccounts](#getcategorizedaccounts) - Get categorized profit and loss statement
* [Get](#get) - Get profit and loss

## GetCategorizedAccounts

The *Get categorized profit and loss statement* endpoint returns a list of categorized accounts that appear on a company’s Profit and Loss statement. It also includes a balance as of the financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/features/financial-statements-overview#recategorizing-accounts) to a more suitable one.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-categorized-profit-and-loss-statement" method="get" path="/companies/{companyId}/reports/enhancedProfitAndLoss/accounts" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCategorizedProfitAndLossStatementRequest req = new GetCategorizedProfitAndLossStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = "29-09-2020",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetCategorizedAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [GetCategorizedProfitAndLossStatementRequest](../../Models/Requests/GetCategorizedProfitAndLossStatementRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[GetCategorizedProfitAndLossStatementResponse](../../Models/Requests/GetCategorizedProfitAndLossStatementResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

Gets the latest profit and loss for a company.

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-profit-and-loss" method="get" path="/companies/{companyId}/data/financials/profitAndLoss" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetAccountingProfitAndLossRequest](../../Models/Requests/GetAccountingProfitAndLossRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetAccountingProfitAndLossResponse](../../Models/Requests/GetAccountingProfitAndLossResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |