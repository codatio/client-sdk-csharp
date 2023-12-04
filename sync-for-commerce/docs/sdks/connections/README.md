# Connections
(*Connections*)

## Overview

Create new and manage existing Sync for Commerce connections using the Sync flow UI.

### Available Operations

* [Create](#create) - Create connection
* [GetSyncFlowUrl](#getsyncflowurl) - Start new sync flow
* [List](#list) - List connections
* [UpdateAuthorization](#updateauthorization) - Update authorization
* [UpdateConnection](#updateconnection) - Update connection

## Create

﻿Creates a connection for the company by providing a valid `platformKey`. 

Use the [List Integrations](https://docs.codat.io/sync-for-sync-for-commerce-api#/operations/list-integrations) endpoint to access valid platform keys. 

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateConnectionRequest req = new CreateConnectionRequest() {
    RequestBody = new CreateConnectionRequestBody() {
        PlatformKey = "gbol",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Connections.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateConnectionRequest](../../Models/Operations/CreateConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[CreateConnectionResponse](../../Models/Operations/CreateConnectionResponse.md)**


## GetSyncFlowUrl

Create a new company and connections. Get a URL for Sync Flow, including a one time passcode.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    AccountingKey = "string",
    CommerceKey = "string",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetSyncFlowUrlRequest](../../Models/Operations/GetSyncFlowUrlRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetSyncFlowUrlResponse](../../Models/Operations/GetSyncFlowUrlResponse.md)**


## List

﻿List the connections for a company.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListConnectionsRequest req = new ListConnectionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Connections.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListConnectionsRequest](../../Models/Operations/ListConnectionsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListConnectionsResponse](../../Models/Operations/ListConnectionsResponse.md)**


## UpdateAuthorization

Update data connection's authorization.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateConnectionAuthorizationRequest req = new UpdateConnectionAuthorizationRequest() {
    RequestBody = new Dictionary<string, string>() {
        { "key", "string" },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Connections.UpdateAuthorizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateConnectionAuthorizationRequest](../../Models/Operations/UpdateConnectionAuthorizationRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateConnectionAuthorizationResponse](../../Models/Operations/UpdateConnectionAuthorizationResponse.md)**


## UpdateConnection

Update a data connection

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateConnectionRequest req = new UpdateConnectionRequest() {
    UpdateConnection = new UpdateConnection() {},
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Connections.UpdateConnectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateConnectionRequest](../../Models/Operations/UpdateConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[UpdateConnectionResponse](../../Models/Operations/UpdateConnectionResponse.md)**

