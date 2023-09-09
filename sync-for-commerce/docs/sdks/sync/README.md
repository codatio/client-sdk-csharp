# sync

## Overview

Initiate and monitor the sync of company data into accounting software.

### Available Operations

* [GetLastSuccessfulSync](#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](#getlatestsync) - Latest sync status
* [GetStatus](#getstatus) - Get sync status
* [List](#list) - List sync statuses
* [Request](#request) - Initiate new sync
* [RequestForDateRange](#requestfordaterange) - Initiate sync for specific range

## GetLastSuccessfulSync

Gets the status of the last successful sync

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

var res = await sdk.Sync.GetLastSuccessfulSyncAsync(new GetLastSuccessfulSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetLastSuccessfulSyncRequest](../../models/operations/GetLastSuccessfulSyncRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetLastSuccessfulSyncResponse](../../models/operations/GetLastSuccessfulSyncResponse.md)**


## GetLatestSync

Gets the latest sync status

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

var res = await sdk.Sync.GetLatestSyncAsync(new GetLatestSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetLatestSyncRequest](../../models/operations/GetLatestSyncRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetLatestSyncResponse](../../models/operations/GetLatestSyncResponse.md)**


## GetStatus

Gets a list of sync statuses.

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

var res = await sdk.Sync.GetStatusAsync(new GetSyncStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSyncStatusRequest](../../models/operations/GetSyncStatusRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetSyncStatusResponse](../../models/operations/GetSyncStatusResponse.md)**


## List

Gets a list of sync statuses

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

var res = await sdk.Sync.ListAsync(new ListSyncsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListSyncsRequest](../../models/operations/ListSyncsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListSyncsResponse](../../models/operations/ListSyncsResponse.md)**


## Request

Run a Commerce sync from the last successful sync up to the date provided (optional), otherwise UtcNow is used.\r\nIf there was no previously successful sync, the start date in the config is used.

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
| `request`                                                           | [RequestSyncRequest](../../models/operations/RequestSyncRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[RequestSyncResponse](../../models/operations/RequestSyncResponse.md)**


## RequestForDateRange

Initiate a sync for the specified start date to the specified finish date in the request payload.

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

var res = await sdk.Sync.RequestForDateRangeAsync(new RequestSyncForDateRangeRequest() {
    SyncRange = new SyncRange() {
        DateRange = new SyncRangeDateRange() {
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
| `request`                                                                                   | [RequestSyncForDateRangeRequest](../../models/operations/RequestSyncForDateRangeRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[RequestSyncForDateRangeResponse](../../models/operations/RequestSyncForDateRangeResponse.md)**

