# Reports
(*AccountsReceivable.Reports*)

### Available Operations

* [GetAgedCreditors](#getagedcreditors) - Aged creditors report
* [GetAgedDebtors](#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](#isagedcreditorsavailable) - Aged creditors report available
* [IsAgedDebtorsAvailable](#isageddebtorsavailable) - Aged debtors report available

## GetAgedCreditors

Returns aged creditors report for company that shows the total balance owed by a business to its suppliers over time.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;
using NodaTime;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivable.Reports.GetAgedCreditorsAsync(new GetAccountingAgedCreditorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetAccountingAgedCreditorsReportRequest](../../Models/Operations/GetAccountingAgedCreditorsReportRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetAccountingAgedCreditorsReportResponse](../../Models/Operations/GetAccountingAgedCreditorsReportResponse.md)**


## GetAgedDebtors

Returns aged debtors report for company that shows the total outstanding balance due from customers to the business over time.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;
using NodaTime;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivable.Reports.GetAgedDebtorsAsync(new GetAccountingAgedDebtorsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 12,
    PeriodLengthDays = 30,
    ReportDate = LocalDate.FromDateTime(System.DateTime.Parse("2022-12-31")),
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingAgedDebtorsReportRequest](../../Models/Operations/GetAccountingAgedDebtorsReportRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingAgedDebtorsReportResponse](../../Models/Operations/GetAccountingAgedDebtorsReportResponse.md)**


## IsAgedCreditorsAvailable

Indicates whether the aged creditor report is available for the company.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivable.Reports.IsAgedCreditorsAvailableAsync(new IsAgedCreditorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [IsAgedCreditorsReportAvailableRequest](../../Models/Operations/IsAgedCreditorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[IsAgedCreditorsReportAvailableResponse](../../Models/Operations/IsAgedCreditorsReportAvailableResponse.md)**


## IsAgedDebtorsAvailable

Indicates whether the aged debtors report is available for the company.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountsReceivable.Reports.IsAgedDebtorsAvailableAsync(new IsAgedDebtorsReportAvailableRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [IsAgedDebtorsReportAvailableRequest](../../Models/Operations/IsAgedDebtorsReportAvailableRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[IsAgedDebtorsReportAvailableResponse](../../Models/Operations/IsAgedDebtorsReportAvailableResponse.md)**

