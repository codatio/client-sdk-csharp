# Sync
(*Sync*)

## Overview

Initiate and monitor the sync of company data into accounting software.

### Available Operations

* [Get](#get) - Get sync status
* [GetLastSuccessfulSync](#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](#getlatestsync) - Latest sync status
* [GetStatus](#getstatus) - Get sync status
* [List](#list) - List sync statuses
* [Request](#request) - Initiate new sync
* [RequestForDateRange](#requestfordaterange) - Initiate sync for specific range

## Get

Get the sync status for a specified sync

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.GetAsync(new GetSyncByIdRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
});

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
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.GetLastSuccessfulSyncAsync(new GetLastSuccessfulSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

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
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.GetLatestSyncAsync(new GetLatestSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetLatestSyncRequest](../../Models/Operations/GetLatestSyncRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetLatestSyncResponse](../../Models/Operations/GetLatestSyncResponse.md)**


## GetStatus

Gets a list of sync statuses.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.GetStatusAsync(new GetSyncStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSyncStatusRequest](../../Models/Operations/GetSyncStatusRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetSyncStatusResponse](../../Models/Operations/GetSyncStatusResponse.md)**


## List

Gets a list of sync statuses

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.ListAsync(new ListSyncsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListSyncsRequest](../../Models/Operations/ListSyncsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListSyncsResponse](../../Models/Operations/ListSyncsResponse.md)**


## Request

Run a Commerce sync from the last successful sync up to the date provided (optional), otherwise UtcNow is used.\r\nIf there was no previously successful sync, the start date in the config is used.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.RequestAsync(new RequestSyncRequest() {
    SyncToLatestArgs = new SyncToLatestArgs() {
        SyncTo = "2022-10-23T00:00:00.000Z",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RequestSyncRequest](../../Models/Operations/RequestSyncRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[RequestSyncResponse](../../Models/Operations/RequestSyncResponse.md)**


## RequestForDateRange

Initiate a sync for the specified start date to the specified finish date in the request payload.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sync.RequestForDateRangeAsync(new RequestSyncForDateRangeRequest() {
    SyncRange = new SyncRange() {
        DateRange = new DateRange() {
            Finish = "2022-10-23T00:00:00.000Z",
            Start = "2022-10-23T00:00:00.000Z",
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [RequestSyncForDateRangeRequest](../../Models/Operations/RequestSyncForDateRangeRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[RequestSyncForDateRangeResponse](../../Models/Operations/RequestSyncForDateRangeResponse.md)**

