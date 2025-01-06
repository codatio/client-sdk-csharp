# CodatLendingReports
(*AccountsReceivable.Reports*)

## Overview

### Available Operations

* [IsAgedDebtorsAvailable](#isageddebtorsavailable) - Aged debtors report available
* [GetAgedDebtors](#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](#isagedcreditorsavailable) - Aged creditors report available
* [GetAgedCreditors](#getagedcreditors) - Aged creditors report

## IsAgedDebtorsAvailable

Indicates whether the aged debtors report is available for the company.

### Example Usage

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
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAgedDebtors

Returns aged debtors report for company that shows the total outstanding balance due from customers to the business over time.

### Example Usage

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
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## IsAgedCreditorsAvailable

Indicates whether the aged creditor report is available for the company.

### Example Usage

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
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAgedCreditors

Returns aged creditors report for company that shows the total balance owed by a business to its suppliers over time.

### Example Usage

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
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |