# RefreshData

## Overview

Initiate data refreshes, view pull status and history.

### Available Operations

* [All](#all) - Refresh all data
* [ByDataType](#bydatatype) - Refresh data type
* [Get](#get) - Get data status
* [ListPullOperations](#listpulloperations) - List pull operations
* [GetPullOperation](#getpulloperation) - Get pull operation

## All

Refreshes all data types with `fetch on first link` set to `true` for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

[Read more](https://docs.codat.io/core-concepts/data-type-settings) about data type settings and `fetch on first link`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="refresh-company-data" method="post" path="/companies/{companyId}/data/all" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshCompanyDataRequest req = new RefreshCompanyDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.RefreshData.AllAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [RefreshCompanyDataRequest](../../Models/Requests/RefreshCompanyDataRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[RefreshCompanyDataResponse](../../Models/Requests/RefreshCompanyDataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## ByDataType

Refreshes a given data type for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="refresh-data-type" method="post" path="/companies/{companyId}/data/queue/{dataType}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshDataTypeRequest req = new RefreshDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DataType = SchemaDataType.Invoices,
};

var res = await sdk.RefreshData.ByDataTypeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RefreshDataTypeRequest](../../Models/Requests/RefreshDataTypeRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[RefreshDataTypeResponse](../../Models/Requests/RefreshDataTypeResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Get

Get the state of each data type for a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company-data-status" method="get" path="/companies/{companyId}/dataStatus" example="Example" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyDataStatusRequest req = new GetCompanyDataStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.RefreshData.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetCompanyDataStatusRequest](../../Models/Requests/GetCompanyDataStatusRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetCompanyDataStatusResponse](../../Models/Requests/GetCompanyDataStatusResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## ListPullOperations

Gets the pull operation history (datasets) for a given company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-pull-operations" method="get" path="/companies/{companyId}/data/history" example="Example" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListPullOperationsRequest req = new ListPullOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.RefreshData.ListPullOperationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListPullOperationsRequest](../../Models/Requests/ListPullOperationsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListPullOperationsResponse](../../Models/Requests/ListPullOperationsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetPullOperation

Retrieve information about a single dataset or pull operation.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-pull-operation" method="get" path="/companies/{companyId}/data/history/{datasetId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetPullOperationRequest req = new GetPullOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "fa5f3e86-bd80-49b8-853c-5fbba4b201f5",
};

var res = await sdk.RefreshData.GetPullOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetPullOperationRequest](../../Models/Requests/GetPullOperationRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetPullOperationResponse](../../Models/Requests/GetPullOperationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |