# Suppliers
(*Suppliers*)

## Overview

Get, create, and update Suppliers.

### Available Operations

* [List](#list) - List suppliers
* [Create](#create) - Create supplier

## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

By default, this endpoint returns a list of active and archived suppliers. You can use [querying](https://docs.codat.io/using-the-api/querying) to change that. 

For example, to retrieve only active suppliers (i.e. `status=Active`) or suppliers created within the specified number of days (e.g. `sourceModifiedDate>2023-12-15T00:00:00.000Z`), query the endpoint as follows: `/payables/suppliers?query=sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=Active`.For example, to retrieve active suppliers modified after a particular date use `query=sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=Active`.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Suppliers.ListAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    continuationToken: "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    query: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                        | Example                                                                                                                                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                 | Unique identifier for a company.                                                                                                                                                                                                   | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                                                                                               |
| `ConnectionId`                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                 | Unique identifier for a connection.                                                                                                                                                                                                | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                                                                                               |
| `ContinuationToken`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                 | Retrieve the next page of results using the continuation token from the previous response.                                                                                                                                         | continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==                                                                                                                                                         |
| `Query`                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                 | Codat query string allows you to filter by `sourceModifiedDate` or if a supplier is `Active` or `Archived` in the accounting software. Learn more about Codat's query string [here](https://docs.codat.io/using-the-api/querying). |                                                                                                                                                                                                                                    |

### Response

**[ListSuppliersResponse](../../Models/Requests/ListSuppliersResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Openapi.Models.Errors.ErrorMessage  | 400,401,402,403,404,409,429,500,503 | application/json                    |
| Openapi.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |


## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.


### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Suppliers.CreateAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    idempotencyKey: "<value>",
    supplierPrototype: new SupplierPrototype() {
        SupplierName = "<value>",
        Phone = "(877) 492-8687",
        Status = Openapi.Models.Components.SupplierStatus.Active,
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 | Example                                                                     |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `CompanyId`                                                                 | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a company.                                            | 8a210b68-6988-11ed-a1eb-0242ac120002                                        |
| `ConnectionId`                                                              | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a connection.                                         | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                        |
| `IdempotencyKey`                                                            | *string*                                                                    | :heavy_minus_sign:                                                          | A unique identifier to ensure idempotent behaviour for subsequent requests. |                                                                             |
| `SupplierPrototype`                                                         | [SupplierPrototype](../../Models/Components/SupplierPrototype.md)           | :heavy_minus_sign:                                                          | N/A                                                                         |                                                                             |

### Response

**[CreateSupplierResponse](../../Models/Requests/CreateSupplierResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
