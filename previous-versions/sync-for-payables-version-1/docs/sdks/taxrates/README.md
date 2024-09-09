# TaxRates
(*TaxRates*)

## Overview

Get, create, and update Tax rates.

### Available Operations

* [Get](#get) - Get tax rate
* [List](#list) - List all tax rates

## Get

The *Get tax rate* endpoint returns a single tax rate for a given `taxRateId`.

[Tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) are a set of taxes and associated rates within the SMB's accounting software.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=taxRates) for integrations that support getting a specific tax rate.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetTaxRateRequest req = new GetTaxRateRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TaxRateId = "<value>",
};

var res = await sdk.TaxRates.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetTaxRateRequest](../../Models/Operations/GetTaxRateRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetTaxRateResponse](../../Models/Operations/GetTaxRateResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## List

The *List tax rates* endpoint returns a list of [tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) for a given company's connection.

[Tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) are a set of taxes and associated rates within the SMB's accounting software.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListTaxRatesRequest req = new ListTaxRatesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
};

var res = await sdk.TaxRates.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListTaxRatesRequest](../../Models/Operations/ListTaxRatesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListTaxRatesResponse](../../Models/Operations/ListTaxRatesResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503               | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
