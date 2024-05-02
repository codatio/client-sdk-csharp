# ManageData
(*ManageData*)

## Overview

Control how data is retrieved from an integration.

### Available Operations

* [GetDataStatus](#getdatastatus) - Get data status
* [GetPullOperation](#getpulloperation) - Get pull operation
* [GetPushOperation](#getpushoperation) - Get push operation
* [List](#list) - List push operations
* [ListPullOperations](#listpulloperations) - List pull operations
* [RefreshAllDataTypes](#refreshalldatatypes) - Refresh all data
* [RefreshDataType](#refreshdatatype) - Refresh data type

## GetDataStatus

Get the state of each data type for a company

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetDataStatusRequest req = new GetDataStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.ManageData.GetDataStatusAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetDataStatusRequest](../../Models/Operations/GetDataStatusRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetDataStatusResponse](../../Models/Operations/GetDataStatusResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## GetPullOperation

Retrieve information about a single dataset or pull operation.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetPullOperationRequest req = new GetPullOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "7911a54a-c808-4f4b-b87e-b195f52b4da5",
};

var res = await sdk.ManageData.GetPullOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPullOperationRequest](../../Models/Operations/GetPullOperationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetPullOperationResponse](../../Models/Operations/GetPullOperationResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## GetPushOperation

Retrieve push operation.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetPushOperationRequest req = new GetPushOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "2a6486f4-00c4-40bd-900d-b29c15ad0581",
};

var res = await sdk.ManageData.GetPushOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPushOperationRequest](../../Models/Operations/GetPushOperationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetPushOperationResponse](../../Models/Operations/GetPushOperationResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## List

List push operation records.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListPushOperationsRequest req = new ListPushOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.ManageData.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPushOperationsRequest](../../Models/Operations/ListPushOperationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListPushOperationsResponse](../../Models/Operations/ListPushOperationsResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## ListPullOperations

Gets the pull operation history (datasets) for a given company.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListPullOperationsRequest req = new ListPullOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.ManageData.ListPullOperationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPullOperationsRequest](../../Models/Operations/ListPullOperationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListPullOperationsResponse](../../Models/Operations/ListPullOperationsResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## RefreshAllDataTypes

Refreshes all data types with `fetch on first link` set to `true` for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

[Read more](https://docs.codat.io/core-concepts/data-type-settings) about data type settings and `fetch on first link`.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

RefreshAllDataTypesRequest req = new RefreshAllDataTypesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.ManageData.RefreshAllDataTypesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [RefreshAllDataTypesRequest](../../Models/Operations/RefreshAllDataTypesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[RefreshAllDataTypesResponse](../../Models/Operations/RefreshAllDataTypesResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## RefreshDataType

Refreshes a given data type for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

RefreshDataTypeRequest req = new RefreshDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DataType = Codat.Sync.Payroll.Models.Shared.SchemaDataType.Invoices,
};

var res = await sdk.ManageData.RefreshDataTypeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RefreshDataTypeRequest](../../Models/Operations/RefreshDataTypeRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RefreshDataTypeResponse](../../Models/Operations/RefreshDataTypeResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |
