# RefreshDataSDK
(*RefreshData*)

## Overview

Asynchronously retrieve data from an integration to refresh data in Codat.

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
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.RefreshData.AllAsync(new RefreshCompanyDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RefreshCompanyDataRequest](../../models/operations/RefreshCompanyDataRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[RefreshCompanyDataResponse](../../models/operations/RefreshCompanyDataResponse.md)**


## ByDataType

Refreshes a given data type for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.RefreshData.ByDataTypeAsync(new RefreshDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "ddf7cc78-ca1b-4a92-8fc8-16742cb73920",
    DataType = CodatPlatform.Models.Shared.DataType.Invoices,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RefreshDataTypeRequest](../../models/operations/RefreshDataTypeRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RefreshDataTypeResponse](../../models/operations/RefreshDataTypeResponse.md)**


## Get

Get the state of each data type for a company

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.RefreshData.GetAsync(new GetCompanyDataStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCompanyDataStatusRequest](../../models/operations/GetCompanyDataStatusRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetCompanyDataStatusResponse](../../models/operations/GetCompanyDataStatusResponse.md)**


## GetPullOperation

Retrieve information about a single dataset or pull operation.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.RefreshData.GetPullOperationAsync(new GetPullOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "5929396f-ea75-496e-b10f-aaa2352c5955",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPullOperationRequest](../../models/operations/GetPullOperationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetPullOperationResponse](../../models/operations/GetPullOperationResponse.md)**


## ListPullOperations

Gets the pull operation history (datasets) for a given company.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.RefreshData.ListPullOperationsAsync(new ListPullOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "excepturi",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPullOperationsRequest](../../models/operations/ListPullOperationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListPullOperationsResponse](../../models/operations/ListPullOperationsResponse.md)**

