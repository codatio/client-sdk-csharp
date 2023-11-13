# CreateOperations
(*LoanWriteback.CreateOperations*)

### Available Operations

* [Get](#get) - Get create operation
* [List](#list) - List create operations

## Get

Retrieve create operation.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.CreateOperations.GetAsync(new GetCreateOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "b18d8d81-fd7b-4764-a31e-475cb1f36591",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetCreateOperationRequest](../../Models/Operations/GetCreateOperationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetCreateOperationResponse](../../Models/Operations/GetCreateOperationResponse.md)**


## List

List create operations.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.CreateOperations.ListAsync(new ListCreateOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCreateOperationsRequest](../../Models/Operations/ListCreateOperationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListCreateOperationsResponse](../../Models/Operations/ListCreateOperationsResponse.md)**

