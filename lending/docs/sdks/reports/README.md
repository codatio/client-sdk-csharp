# Reports
(*Sales.Reports*)

## Overview

### Available Operations

* [GetOrders](#getorders) - Get orders report
* [GetRefunds](#getrefunds) - Get refunds report

## GetOrders

The *Get orders report* endpoint returns the number of orders, total value, and average order value for a specific company's commerce connection over one or more periods of time.

This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 

Learn more about the formulas used to calculate the order metrics [here](https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available).

Refer to the [commerce reporting structure](https://docs.codat.io/lending/commerce-metrics/reporting-structure) page for more details on commerce reports in Lending.

#### Response structure

The Orders report's dimensions and measures are:

| Index         | Dimensions     |
|---------------|----------------|
|   `index` = 0 | Period         |
|   `index` = 1 | Order metrics  |

| Index         | Measures   |
|---------------|------------|
| `index` = 0   | Count      |
| `index` = 1   | Value      |

The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrdersReportRequest req = new GetCommerceOrdersReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ReportDate = "29-09-2020",
    PeriodLength = 491586,
    NumberOfPeriods = 776309,
    PeriodUnit = Codat.Lending.Models.Components.PeriodUnit.Week,
};

var res = await sdk.Sales.Reports.GetOrdersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCommerceOrdersReportRequest](../../Models/Requests/GetCommerceOrdersReportRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetCommerceOrdersReportResponse](../../Models/Requests/GetCommerceOrdersReportResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## GetRefunds

The *Get refunds report* endpoint returns the number and total value of refunds and the refund rate for a specific company's commerce connection over one or more periods of time.

This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 

Learn more about the formulas used to calculate the refunds metrics [here](https://docs.codat.io/lending/commerce-metrics/overview#what-metrics-are-available).

Refer to the [commerce reporting structure](https://docs.codat.io/lending/commerce-metrics/reporting-structure) page for more details on commerce reports in Lending.

#### Response structure

The Refunds report's dimensions and measures are:

| Index          | Dimensions     |
|----------------|----------------|
| `index` = 0    | Period         |
| `index` = 1    | Refund metrics |

| Index          | Measures    |
|----------------|------------|
| `index` = 0    | Count      |
| `index` = 1    | Value      |
| `index` = 2    | Percentage |

The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceRefundsReportRequest req = new GetCommerceRefundsReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ReportDate = "29-09-2020",
    PeriodLength = 277786,
    NumberOfPeriods = 876670,
    PeriodUnit = Codat.Lending.Models.Components.PeriodUnit.Year,
};

var res = await sdk.Sales.Reports.GetRefundsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetCommerceRefundsReportRequest](../../Models/Requests/GetCommerceRefundsReportRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetCommerceRefundsReportResponse](../../Models/Requests/GetCommerceRefundsReportResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
