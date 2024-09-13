# Refresh
(*ManageData.Refresh*)

## Overview

### Available Operations

* [AllDataTypes](#alldatatypes) - Refresh all data
* [DataType](#datatype) - Refresh data type

## AllDataTypes

Refreshes all data types with `fetch on first link` set to `true` for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

[Read more](https://docs.codat.io/core-concepts/data-type-settings) about data type settings and `fetch on first link`.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshAllDataTypesRequest req = new RefreshAllDataTypesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.ManageData.Refresh.AllDataTypesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RefreshAllDataTypesRequest](../../Models/Requests/RefreshAllDataTypesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[RefreshAllDataTypesResponse](../../Models/Requests/RefreshAllDataTypesResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## DataType

Refreshes a given data type for a given company.

This is an asynchronous operation, and will bring updated data into Codat from the linked integration for you to view.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshDataTypeRequest req = new RefreshDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DataType = Codat.Lending.Models.Components.DataType.Invoices,
};

var res = await sdk.ManageData.Refresh.DataTypeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RefreshDataTypeRequest](../../Models/Requests/RefreshDataTypeRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[RefreshDataTypeResponse](../../Models/Requests/RefreshDataTypeResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
