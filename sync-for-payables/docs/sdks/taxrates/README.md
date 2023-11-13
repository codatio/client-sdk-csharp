# TaxRates
(*TaxRates*)

## Overview

Tax rates

### Available Operations

* [Get](#get) - Get tax rate
* [List](#list) - List all tax rates

## Get

The *Get tax rate* endpoint returns a single tax rate for a given `taxRateId`.

[Tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) are a set of taxes and associated rates within the SMB's accounting package.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=taxRates) for integrations that support getting a specific tax rate.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TaxRates.GetAsync(new GetTaxRateRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TaxRateId = "string",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetTaxRateRequest](../../Models/Operations/GetTaxRateRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetTaxRateResponse](../../Models/Operations/GetTaxRateResponse.md)**


## List

The *List tax rates* endpoint returns a list of [tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) for a given company's connection.

[Tax rates](https://docs.codat.io/sync-for-payables-api#/schemas/TaxRate) are a set of taxes and associated rates within the SMB's accounting package.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TaxRates.ListAsync(new ListTaxRatesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListTaxRatesRequest](../../Models/Operations/ListTaxRatesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListTaxRatesResponse](../../Models/Operations/ListTaxRatesResponse.md)**

