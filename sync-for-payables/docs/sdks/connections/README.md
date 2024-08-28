# Connections
(*Connections*)

## Overview

Create new and manage existing data connections for a company.

### Available Operations

* [List](#list) - List connections
* [Create](#create) - Create connection
* [Get](#get) - Get connection
* [Delete](#delete) - Delete connection
* [Unlink](#unlink) - Unlink connection

## List

﻿List the connections for a company.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListConnectionsRequest req = new ListConnectionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Connections.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListConnectionsRequest](../../Models/Requests/ListConnectionsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListConnectionsResponse](../../Models/Requests/ListConnectionsResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Create

﻿Creates a connection for the company by providing a valid `platformKey`. 

Use the [List Integrations](https://docs.codat.io/sync-for-payables-api#/operations/list-integrations) endpoint to access valid platform keys. 

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Connections.CreateAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    requestBody: new CreateConnectionRequestBody() {
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         | Example                                                                             |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `CompanyId`                                                                         | *string*                                                                            | :heavy_check_mark:                                                                  | Unique identifier for a company.                                                    | 8a210b68-6988-11ed-a1eb-0242ac120002                                                |
| `RequestBody`                                                                       | [CreateConnectionRequestBody](../../Models/Requests/CreateConnectionRequestBody.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |

### Response

**[CreateConnectionResponse](../../Models/Requests/CreateConnectionResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Get

﻿Returns a specific connection for a company when valid identifiers are provided. If the identifiers are for a deleted company and/or connection, a not found response is returned.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Connections.GetAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |
| `ConnectionId`                       | *string*                             | :heavy_check_mark:                   | Unique identifier for a connection.  | 2e9d2c44-f675-40ba-8049-353bfcb5e171 |

### Response

**[GetConnectionResponse](../../Models/Requests/GetConnectionResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Delete

﻿Revoke and remove a connection from a company.
This operation is not reversible. The end user would need to reauthorize a new data connection if you wish to view new data for this company.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Connections.DeleteAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |
| `ConnectionId`                       | *string*                             | :heavy_check_mark:                   | Unique identifier for a connection.  | 2e9d2c44-f675-40ba-8049-353bfcb5e171 |

### Response

**[DeleteConnectionResponse](../../Models/Requests/DeleteConnectionResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Unlink

﻿This allows you to deauthorize a connection, without deleting it from Codat. This means you can still view any data that has previously been pulled into Codat, and also lets you re-authorize in future if your customer wishes to resume sharing their data.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Connections.UnlinkAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    requestBody: new UnlinkConnectionUpdateConnection() {});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | Unique identifier for a company.                                                              | 8a210b68-6988-11ed-a1eb-0242ac120002                                                          |
| `ConnectionId`                                                                                | *string*                                                                                      | :heavy_check_mark:                                                                            | Unique identifier for a connection.                                                           | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                          |
| `RequestBody`                                                                                 | [UnlinkConnectionUpdateConnection](../../Models/Requests/UnlinkConnectionUpdateConnection.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |

### Response

**[UnlinkConnectionResponse](../../Models/Requests/UnlinkConnectionResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
