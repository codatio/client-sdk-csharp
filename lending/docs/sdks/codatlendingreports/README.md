# AccountsReceivable.Reports

## Overview

### Available Operations

* [IsAgedDebtorsAvailable](#isageddebtorsavailable) - Aged debtors report available
* [GetAgedDebtors](#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](#isagedcreditorsavailable) - Aged creditors report available
* [GetAgedCreditors](#getagedcreditors) - Aged creditors report

## IsAgedDebtorsAvailable

Indicates whether the aged debtors report is available for the company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="is-aged-debtors-report-available" method="get" path="/companies/{companyId}/reports/agedDebtor/available" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

IsAgedDebtorsReportAvailableRequest req = new IsAgedDebtorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.Reports.IsAgedDebtorsAvailableAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [IsAgedDebtorsReportAvailableRequest](../../Models/Requests/IsAgedDebtorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[IsAgedDebtorsReportAvailableResponse](../../Models/Requests/IsAgedDebtorsReportAvailableResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAgedDebtors

Returns aged debtors report for company that shows the total outstanding balance due from customers to the business over time.

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-debtors-report" method="get" path="/companies/{companyId}/reports/agedDebtor" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedDebtorsReportRequest req = new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetAccountingAgedDebtorsReportRequest](../../Models/Requests/GetAccountingAgedDebtorsReportRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetAccountingAgedDebtorsReportResponse](../../Models/Requests/GetAccountingAgedDebtorsReportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## IsAgedCreditorsAvailable

Indicates whether the aged creditor report is available for the company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="is-aged-creditors-report-available" method="get" path="/companies/{companyId}/reports/agedCreditor/available" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

IsAgedCreditorsReportAvailableRequest req = new IsAgedCreditorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.Reports.IsAgedCreditorsAvailableAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [IsAgedCreditorsReportAvailableRequest](../../Models/Requests/IsAgedCreditorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[IsAgedCreditorsReportAvailableResponse](../../Models/Requests/IsAgedCreditorsReportAvailableResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAgedCreditors

Returns aged creditors report for company that shows the total balance owed by a business to its suppliers over time.

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-aged-creditors-report" method="get" path="/companies/{companyId}/reports/agedCreditor" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using NodaTime;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAgedCreditorsReportRequest req = new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
};

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetAccountingAgedCreditorsReportRequest](../../Models/Requests/GetAccountingAgedCreditorsReportRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[GetAccountingAgedCreditorsReportResponse](../../Models/Requests/GetAccountingAgedCreditorsReportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |