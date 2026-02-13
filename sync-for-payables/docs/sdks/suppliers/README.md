# Suppliers

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

### Example Usage: Source modified date

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Status (active)

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Status (active)" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "status=Active",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Status (active) & source modified date

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Status (active) & source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=Active",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Status (archived)

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Status (archived)" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "status=Archived",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Status (archived) & source modified date

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Status (archived) & source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=Archived",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Suppliers

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Suppliers" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListSuppliersRequest](../../Models/Requests/ListSuppliersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListSuppliersResponse](../../Models/Requests/ListSuppliersResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.


### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SupplierPrototype = new SupplierPrototype() {
        SupplierName = "<value>",
        Phone = "+44 25691 154789",
        Status = SupplierStatus.Unknown,
    },
};

var res = await sdk.Suppliers.CreateAsync(req);

// handle response
```
### Example Usage: Suppliers

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/suppliers" example="Suppliers" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SupplierPrototype = new SupplierPrototype() {
        SupplierName = "Greggs",
        ContactName = "Greg Greggs",
        EmailAddress = "greg@greggs.com",
        Phone = "+44 (0)1223 322410",
        Addresses = new List<Address>() {
            new Address() {
                Type = AddressType.Billing,
                Line1 = "Flat 1",
                Line2 = "2 Dennis Avenue",
                City = "London",
                Region = "Camden",
                Country = "GBR",
                PostalCode = "EC1N 7TE",
            },
        },
        Status = SupplierStatus.Active,
        DefaultCurrency = "GBP",
    },
};

var res = await sdk.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateSupplierRequest](../../Models/Requests/CreateSupplierRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CreateSupplierResponse](../../Models/Requests/CreateSupplierResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |