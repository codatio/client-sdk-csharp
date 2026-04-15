# FinancialStatements.BalanceSheet

## Overview

### Available Operations

* [GetCategorizedAccounts](#getcategorizedaccounts) - Get categorized balance sheet statement
* [Get](#get) - Get balance sheet

## GetCategorizedAccounts

The *Get categorized balance sheet statement* endpoint returns a list of categorized accounts that appear on a company’s Balance Sheet along with a balance per financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/features/financial-statements-overview#recategorizing-accounts) to a more suitable one.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-categorized-balance-sheet-statement" method="get" path="/companies/{companyId}/reports/enhancedBalanceSheet/accounts" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCategorizedBalanceSheetStatementRequest req = new GetCategorizedBalanceSheetStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = "29-09-2020",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetCategorizedAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetCategorizedBalanceSheetStatementRequest](../../Models/Requests/GetCategorizedBalanceSheetStatementRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[GetCategorizedBalanceSheetStatementResponse](../../Models/Requests/GetCategorizedBalanceSheetStatementResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

Gets the latest balance sheet for a company.

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-balance-sheet" method="get" path="/companies/{companyId}/data/financials/balanceSheet" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBalanceSheetRequest req = new GetAccountingBalanceSheetRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.BalanceSheet.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetAccountingBalanceSheetRequest](../../Models/Requests/GetAccountingBalanceSheetRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetAccountingBalanceSheetResponse](../../Models/Requests/GetAccountingBalanceSheetResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |