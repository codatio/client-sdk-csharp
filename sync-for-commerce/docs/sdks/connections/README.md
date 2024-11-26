# Connections
(*Connections*)

## Overview

Create new and manage existing data connections for a company.

### Available Operations

* [GetSyncFlowUrl](#getsyncflowurl) - Start new sync flow
* [List](#list) - List connections
* [Create](#create) - Create connection
* [UpdateConnection](#updateconnection) - Update connection
* [UpdateAuthorization](#updateauthorization) - Update authorization

## GetSyncFlowUrl

Create a new company and connections. Get a URL for Sync Flow, including a one time passcode.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSyncFlowUrlRequest](../../Models/Requests/GetSyncFlowUrlRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetSyncFlowUrlResponse](../../Models/Requests/GetSyncFlowUrlResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## List

﻿List the connections for a company.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

﻿Creates a connection for the company by providing a valid `platformKey`. 

Use the [List Integrations](https://docs.codat.io/platform-api#/operations/list-integrations) endpoint to access valid platform keys. 

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateConnectionRequest req = new CreateConnectionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new CreateConnectionRequestBody() {
        PlatformKey = "gbol",
    },
};

var res = await sdk.Connections.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CreateConnectionRequest](../../Models/Requests/CreateConnectionRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CreateConnectionResponse](../../Models/Requests/CreateConnectionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UpdateConnection

Update a data connection

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateConnectionRequest req = new UpdateConnectionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Connections.UpdateConnectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateConnectionRequest](../../Models/Requests/UpdateConnectionRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateConnectionResponse](../../Models/Requests/UpdateConnectionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UpdateAuthorization

Update data connection's authorization.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using System.Collections.Generic;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateConnectionAuthorizationRequest req = new UpdateConnectionAuthorizationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Connections.UpdateAuthorizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateConnectionAuthorizationRequest](../../Models/Requests/UpdateConnectionAuthorizationRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateConnectionAuthorizationResponse](../../Models/Requests/UpdateConnectionAuthorizationResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |