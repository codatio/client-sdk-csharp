# Sync
(*Sync*)

## Overview

Trigger and monitor expense syncs to accounting software.

### Available Operations

* [Get](#get) - Get sync status
* [GetLastSuccessfulSync](#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](#getlatestsync) - Latest sync status
* [InitiateSync](#initiatesync) - Initiate sync
* [List](#list) - List sync statuses

## Get

Get the sync status for a specified sync

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetSyncByIdRequest req = new GetSyncByIdRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
};

var res = await sdk.Sync.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetSyncByIdRequest](../../Models/Operations/GetSyncByIdRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[GetSyncByIdResponse](../../Models/Operations/GetSyncByIdResponse.md)**


## GetLastSuccessfulSync

Gets the status of the last successful sync

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetLastSuccessfulSyncRequest req = new GetLastSuccessfulSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetLastSuccessfulSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetLastSuccessfulSyncRequest](../../Models/Operations/GetLastSuccessfulSyncRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetLastSuccessfulSyncResponse](../../Models/Operations/GetLastSuccessfulSyncResponse.md)**


## GetLatestSync

Gets the latest sync status

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetLatestSyncRequest req = new GetLatestSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetLatestSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetLatestSyncRequest](../../Models/Operations/GetLatestSyncRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetLatestSyncResponse](../../Models/Operations/GetLatestSyncResponse.md)**


## InitiateSync

Initiate sync of pending transactions.

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

InitiateSyncRequest req = new InitiateSyncRequest() {
    InitiateSync = new InitiateSync() {
        DatasetIds = new List<string>() {
            "acce2362-83d6-4e3e-a27f-f4a08e7217d5",
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.InitiateSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [InitiateSyncRequest](../../Models/Operations/InitiateSyncRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[InitiateSyncResponse](../../Models/Operations/InitiateSyncResponse.md)**


## List

Gets a list of sync statuses

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListSyncsRequest req = new ListSyncsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListSyncsRequest](../../Models/Operations/ListSyncsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListSyncsResponse](../../Models/Operations/ListSyncsResponse.md)**

