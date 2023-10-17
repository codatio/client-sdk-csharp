# ConnectionsSDK
(*Connections*)

## Overview

Manage your companies' data connections.

### Available Operations

* [Create](#create) - Create connection
* [Delete](#delete) - Delete connection
* [Get](#get) - Get connection
* [List](#list) - List connections
* [Unlink](#unlink) - Unlink connection

## Create

﻿Creates a connection for the company by providing a valid `platformKey`. 

Use the [List Integrations](https://docs.codat.io/sync-for-payroll-api#/operations/list-integrations) endpoint to access valid platform keys. 

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.CreateAsync(new CreateConnectionRequest() {
    RequestBody = new CreateConnectionRequestBody() {
        PlatformKey = "gbol",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateConnectionRequest](../../models/operations/CreateConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[CreateConnectionResponse](../../models/operations/CreateConnectionResponse.md)**


## Delete

﻿Revoke and remove a connection from a company.
This operation is not reversible. The end user would need to reauthorize a new data connection if you wish to view new data for this company.

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.DeleteAsync(new DeleteConnectionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [DeleteConnectionRequest](../../models/operations/DeleteConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[DeleteConnectionResponse](../../models/operations/DeleteConnectionResponse.md)**


## Get

﻿Returns a specific connection for a company when valid identifiers are provided. If the identifiers are for a deleted company and/or connection, a not found response is returned.

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.GetAsync(new GetConnectionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetConnectionRequest](../../models/operations/GetConnectionRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetConnectionResponse](../../models/operations/GetConnectionResponse.md)**


## List

﻿List the connections for a company.

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.ListAsync(new ListConnectionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListConnectionsRequest](../../models/operations/ListConnectionsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListConnectionsResponse](../../models/operations/ListConnectionsResponse.md)**


## Unlink

﻿This allows you to deauthorize a connection, without deleting it from Codat. This means you can still view any data that has previously been pulled into Codat, and also lets you re-authorize in future if your customer wishes to resume sharing their data.

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.UnlinkAsync(new UnlinkConnectionRequest() {
    RequestBody = new UnlinkConnectionUpdateConnection() {},
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UnlinkConnectionRequest](../../models/operations/UnlinkConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[UnlinkConnectionResponse](../../models/operations/UnlinkConnectionResponse.md)**

