# ConnectionsSDK
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
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
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


## GetSyncFlowUrl

Create a new company and connections. Get a URL for Sync Flow, including a one time passcode.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.GetSyncFlowUrlAsync(new GetSyncFlowUrlRequest() {
    AccountingKey = "string",
    CommerceKey = "string",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetSyncFlowUrlRequest](../../models/operations/GetSyncFlowUrlRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetSyncFlowUrlResponse](../../models/operations/GetSyncFlowUrlResponse.md)**


## List

﻿List the connections for a company.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
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


## UpdateAuthorization

Update data connection's authorization.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.UpdateAuthorizationAsync(new UpdateConnectionAuthorizationRequest() {
    RequestBody = new Dictionary<string, string>() {
        { "key", "string" },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateConnectionAuthorizationRequest](../../models/operations/UpdateConnectionAuthorizationRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateConnectionAuthorizationResponse](../../models/operations/UpdateConnectionAuthorizationResponse.md)**


## UpdateConnection

Update a data connection

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Connections.UpdateConnectionAsync(new UpdateConnectionRequest() {
    UpdateConnection = new UpdateConnection() {},
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateConnectionRequest](../../models/operations/UpdateConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[UpdateConnectionResponse](../../models/operations/UpdateConnectionResponse.md)**

