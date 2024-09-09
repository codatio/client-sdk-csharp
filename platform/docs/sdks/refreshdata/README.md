# RefreshData
(*RefreshData*)

## Overview

Initiate data refreshes, view pull status and history.

### Available Operations

* [All](#all) - Refresh all data
* [ByDataType](#bydatatype) - Refresh data type
* [Get](#get) - Get data status
* [GetPullOperation](#getpulloperation) - Get pull operation
* [ListPullOperations](#listpulloperations) - List pull operations

## All

Refreshes all data types with `fetch on first link` set to `true` for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

[Read more](https://docs.codat.io/core-concepts/data-type-settings) about data type settings and `fetch on first link`.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

RefreshCompanyDataRequest req = new RefreshCompanyDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.RefreshData.AllAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RefreshCompanyDataRequest](../../Models/Operations/RefreshCompanyDataRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[RefreshCompanyDataResponse](../../Models/Operations/RefreshCompanyDataResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ByDataType

Refreshes a given data type for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

RefreshDataTypeRequest req = new RefreshDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DataType = Codat.Platform.Models.Shared.SchemaDataType.Invoices,
};

var res = await sdk.RefreshData.ByDataTypeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RefreshDataTypeRequest](../../Models/Operations/RefreshDataTypeRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[RefreshDataTypeResponse](../../Models/Operations/RefreshDataTypeResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## Get

Get the state of each data type for a company

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetCompanyDataStatusRequest req = new GetCompanyDataStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.RefreshData.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCompanyDataStatusRequest](../../Models/Operations/GetCompanyDataStatusRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCompanyDataStatusResponse](../../Models/Operations/GetCompanyDataStatusResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## GetPullOperation

Retrieve information about a single dataset or pull operation.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetPullOperationRequest req = new GetPullOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "7911a54a-c808-4f4b-b87e-b195f52b4da5",
};

var res = await sdk.RefreshData.GetPullOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPullOperationRequest](../../Models/Operations/GetPullOperationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetPullOperationResponse](../../Models/Operations/GetPullOperationResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ListPullOperations

Gets the pull operation history (datasets) for a given company.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListPullOperationsRequest req = new ListPullOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
};

var res = await sdk.RefreshData.ListPullOperationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPullOperationsRequest](../../Models/Operations/ListPullOperationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListPullOperationsResponse](../../Models/Operations/ListPullOperationsResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
