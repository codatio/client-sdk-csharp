# CreateOperations
(*LoanWriteback.CreateOperations*)

## Overview

### Available Operations

* [Get](#get) - Get create operation
* [List](#list) - List create operations

## Get

Retrieve create operation.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateOperationRequest req = new GetCreateOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "b18d8d81-fd7b-4764-a31e-475cb1f36591",
};

var res = await sdk.LoanWriteback.CreateOperations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetCreateOperationRequest](../../Models/Requests/GetCreateOperationRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetCreateOperationResponse](../../Models/Requests/GetCreateOperationResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## List

List create operations.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCreateOperationsRequest req = new ListCreateOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.LoanWriteback.CreateOperations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListCreateOperationsRequest](../../Models/Requests/ListCreateOperationsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListCreateOperationsResponse](../../Models/Requests/ListCreateOperationsResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
