# ManageDataPullOperationsSDK
(*ManageData.PullOperations*)

### Available Operations

* [Get](#get) - Get pull operation
* [List](#list) - List pull operations

## Get

Retrieve information about a single dataset or pull operation.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ManageData.PullOperations.GetAsync(new GetPullOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "b18d8d81-fd7b-4764-a31e-475cb1f36591",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPullOperationRequest](../../models/operations/GetPullOperationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetPullOperationResponse](../../models/operations/GetPullOperationResponse.md)**


## List

﻿The *List pull operations* endpoint returns a list of [pull operations](https://docs.codat.io/lending-api#/schemas/PullOperation) made by your client.

A [pull operation](https://docs.codat.io/lending-api#/schemas/PullOperation) is a request to retrieve a specific data type from an integration.

### Tips and traps

- The *List pull operations* endpoint does not support querying the `isCompleted` property. You can filter failed pull operations by querying `status!=Complete&&status!=NotSupported` instead.



### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ManageData.PullOperations.ListAsync(new ListPullOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPullOperationsRequest](../../models/operations/ListPullOperationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListPullOperationsResponse](../../models/operations/ListPullOperationsResponse.md)**

