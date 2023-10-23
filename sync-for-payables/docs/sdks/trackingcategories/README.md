# TrackingCategoriesSDK
(*TrackingCategories*)

## Overview

Tracking categories

### Available Operations

* [Get](#get) - Get tracking categories
* [List](#list) - List tracking categories

## Get

The *Get tracking category* endpoint returns a single tracking category for a given `trackingCategoryId`.

[Tracking categories](https://docs.codat.io/sync-for-payables-api#/schemas/TrackingCategory) are used to monitor cost centres and control budgets that sit outside the standard set of accounts.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=trackingCategories) for integrations that support getting a specific tracking category.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TrackingCategories.GetAsync(new GetTrackingCategoryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TrackingCategoryId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetTrackingCategoryRequest](../../models/operations/GetTrackingCategoryRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetTrackingCategoryResponse](../../models/operations/GetTrackingCategoryResponse.md)**


## List

The *List tracking categories* endpoint returns a list of [tracking categories](https://docs.codat.io/sync-for-payables-api#/schemas/TrackingCategory) for a given company's connection.

[Tracking categories](https://docs.codat.io/sync-for-payables-api#/schemas/TrackingCategory) are used to monitor cost centres and control budgets that sit outside the standard set of accounts.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TrackingCategories.ListAsync(new ListTrackingCategoriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListTrackingCategoriesRequest](../../models/operations/ListTrackingCategoriesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListTrackingCategoriesResponse](../../models/operations/ListTrackingCategoriesResponse.md)**

