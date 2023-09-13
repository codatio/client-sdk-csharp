# accountsReceivableReports

### Available Operations

* [GetAgedCreditors](#getagedcreditors) - Aged creditors report
* [GetAgedDebtors](#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](#isagedcreditorsavailable) - Aged creditors report available
* [IsAgedDebtorsAvailable](#isageddebtorsavailable) - Aged debtors report available

## GetAgedCreditors

Returns aged creditors report for company that shows the total balance owed by a business to its suppliers over time.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;
using NodaTime;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivableReports.GetAgedCreditorsAsync(new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
    ReportDate = LocalDate.FromDateTime(DateTime.Parse("2022-12-31")),
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetAccountingAgedCreditorsReportRequest](../../models/operations/GetAccountingAgedCreditorsReportRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetAccountingAgedCreditorsReportResponse](../../models/operations/GetAccountingAgedCreditorsReportResponse.md)**


## GetAgedDebtors

Returns aged debtors report for company that shows the total outstanding balance due from customers to the business over time.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;
using NodaTime;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivableReports.GetAgedDebtorsAsync(new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
    ReportDate = LocalDate.FromDateTime(DateTime.Parse("2022-12-31")),
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingAgedDebtorsReportRequest](../../models/operations/GetAccountingAgedDebtorsReportRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingAgedDebtorsReportResponse](../../models/operations/GetAccountingAgedDebtorsReportResponse.md)**


## IsAgedCreditorsAvailable

Indicates whether the aged creditor report is available for the company.

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

var res = await sdk.AccountsReceivableReports.IsAgedCreditorsAvailableAsync(new IsAgedCreditorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [IsAgedCreditorsReportAvailableRequest](../../models/operations/IsAgedCreditorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[IsAgedCreditorsReportAvailableResponse](../../models/operations/IsAgedCreditorsReportAvailableResponse.md)**


## IsAgedDebtorsAvailable

Indicates whether the aged debtors report is available for the company.

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

var res = await sdk.AccountsReceivableReports.IsAgedDebtorsAvailableAsync(new IsAgedDebtorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [IsAgedDebtorsReportAvailableRequest](../../models/operations/IsAgedDebtorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[IsAgedDebtorsReportAvailableResponse](../../models/operations/IsAgedDebtorsReportAvailableResponse.md)**

