# Metrics
(*Sales.Metrics*)

## Overview

### Available Operations

* [GetRevenue](#getrevenue) - Get commerce revenue metrics
* [GetCustomerRetention](#getcustomerretention) - Get customer retention metrics
* [GetLifetimeValue](#getlifetimevalue) - Get lifetime value metrics

## GetRevenue

The *Get revenue report* endpoint returns the revenue and revenue growth for a specific company connection over one or more periods of time.

This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 

[Learn more](https://docs.codat.io/lending/features/sales-overview#metrics) about the formulas used to calculate the revenue metrics.

#### Response structure

The Revenue report's dimensions and measures are:

| Index         | Dimensions |
|---------------|------------|
|   `index` = 0 | Period     |
|   `index` = 1 | Revenue    |

| Index         | Measures                                                                                                                 |
|---------------|--------------------------------------------------------------------------------------------------------------------------|
| `index` = 0   | Value                                                                                                                    |
| `index` = 1   | Percentage change, defined as the change between the current and previous periods' values and expressed as a percentage. |

The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceRevenueMetricsRequest req = new GetCommerceRevenueMetricsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ReportDate = "29-09-2020",
    PeriodLength = 307462,
    NumberOfPeriods = 120092,
    PeriodUnit = PeriodUnit.Year,
};

var res = await sdk.Sales.Metrics.GetRevenueAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetCommerceRevenueMetricsRequest](../../Models/Requests/GetCommerceRevenueMetricsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetCommerceRevenueMetricsResponse](../../Models/Requests/GetCommerceRevenueMetricsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetCustomerRetention

The *Get customer retention metrics* endpoint returns customer retention insights for a specific company's commerce connection over one or more periods of time.

This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company. 

#### Customer retention metrics

- __Existing customers__: the number of unique customers that have placed an order(s) in the specified period and any previous period. 
- __New customers__: the number of unique customers that have placed an order(s) in the specified period and none in any previous period.
- __Total customers__: the total number of existing and new customers within the specified period.
- __Retention rate__: the ratio of existing customers within the specified period compared to the total customers at the end of the previous period represented as a percentage.
- __Repeat rate__: the ratio of existing customers to total customers over the specified period represented as a percentage.

[Learn more](https://docs.codat.io/lending/features/sales-overview#metrics) about the formulas used to calculate customer retention metrics.

#### Response structure

The Customer retention report's dimensions and measures are:

| Index                       | Dimensions                 |
|-----------------------------|----------------------------|
| `index` = 0                 | Period                     |
| `index` = 1                 | Customer retention metrics |

| Index                | Measures    |
|----------------------|------------|
| `index` = 0          | Count      |
| `index` = 1          | Percentage |

The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceCustomerRetentionMetricsRequest req = new GetCommerceCustomerRetentionMetricsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ReportDate = "29-09-2020",
    PeriodLength = 497588,
    NumberOfPeriods = 431272,
    PeriodUnit = PeriodUnit.Day,
};

var res = await sdk.Sales.Metrics.GetCustomerRetentionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetCommerceCustomerRetentionMetricsRequest](../../Models/Requests/GetCommerceCustomerRetentionMetricsRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[GetCommerceCustomerRetentionMetricsResponse](../../Models/Requests/GetCommerceCustomerRetentionMetricsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetLifetimeValue

The *Get lifetime value metrics* endpoint returns the average revenue that a specific company will generate throughout its lifespan over one or more periods of time.

This detail helps you assess a merchant's health and advise them on performance improvement strategies. It also provides you with key insights you need to assess the credit risk of a company.

[Learn more](https://docs.codat.io/lending/features/sales-overview#metrics) about the formulas used to calculate the lifetime value metrics.

#### Response structure

The Lifetime value report's dimensions and measures are:

| Index         | Dimensions             |
|---------------|------------------------|
| `index` = 0   | Period                 |
| `index` = 1   | Lifetime value metrics |

| Index             | Measures |
|-------------------|---------|
|   `index` = 1     | Value   |

The report data then combines multiple reporting dimensions and measures and outputs the value of each combination.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceLifetimeValueMetricsRequest req = new GetCommerceLifetimeValueMetricsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ReportDate = "29-09-2020",
    PeriodLength = 900865,
    NumberOfPeriods = 500610,
    PeriodUnit = PeriodUnit.Year,
};

var res = await sdk.Sales.Metrics.GetLifetimeValueAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetCommerceLifetimeValueMetricsRequest](../../Models/Requests/GetCommerceLifetimeValueMetricsRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[GetCommerceLifetimeValueMetricsResponse](../../Models/Requests/GetCommerceLifetimeValueMetricsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |