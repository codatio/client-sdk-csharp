# PushOperations
(*PushOperations*)

## Overview

View historic push operations.

### Available Operations

* [List](#list) - List push operations
* [Get](#get) - Get push operation

## List

List push operation records.

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListPushOperationsRequest req = new ListPushOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.PushOperations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListPushOperationsRequest](../../Models/Requests/ListPushOperationsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListPushOperationsResponse](../../Models/Requests/ListPushOperationsResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Get

Retrieve push operation.

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetPushOperationRequest req = new GetPushOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "b18d8d81-fd7b-4764-a31e-475cb1f36591",
};

var res = await sdk.PushOperations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetPushOperationRequest](../../Models/Requests/GetPushOperationRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetPushOperationResponse](../../Models/Requests/GetPushOperationResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
