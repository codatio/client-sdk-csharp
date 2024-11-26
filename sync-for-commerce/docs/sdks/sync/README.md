# Sync
(*Sync*)

## Overview

Initiate data syncs and monitor their status.

### Available Operations

* [Request](#request) - Initiate new sync
* [RequestForDateRange](#requestfordaterange) - Initiate sync for specific range
* [GetStatus](#getstatus) - Get sync status
* [GetLastSuccessfulSync](#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](#getlatestsync) - Latest sync status
* [Get](#get) - Get sync status
* [List](#list) - List sync statuses

## Request

Run a Commerce sync from the last successful sync up to the date provided (optional), otherwise UtcNow is used.\r\nIf there was no previously successful sync, the start date in the config is used.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RequestSyncRequest req = new RequestSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncToLatestArgs = new SyncToLatestArgs() {
        SyncTo = "2022-10-23T00:00:00Z",
    },
};

var res = await sdk.Sync.RequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [RequestSyncRequest](../../Models/Requests/RequestSyncRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[RequestSyncResponse](../../Models/Requests/RequestSyncResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## RequestForDateRange

Initiate a sync for the specified start date to the specified finish date in the request payload.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RequestSyncForDateRangeRequest req = new RequestSyncForDateRangeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncRange = new SyncRange() {
        DateRange = new DateRange() {
            Start = "2022-10-23T00:00:00Z",
            Finish = "2022-10-23T00:00:00Z",
        },
    },
};

var res = await sdk.Sync.RequestForDateRangeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RequestSyncForDateRangeRequest](../../Models/Requests/RequestSyncForDateRangeRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[RequestSyncForDateRangeResponse](../../Models/Requests/RequestSyncForDateRangeResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetStatus

Gets a list of sync statuses.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncStatusRequest req = new GetSyncStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetStatusAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetSyncStatusRequest](../../Models/Requests/GetSyncStatusRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetSyncStatusResponse](../../Models/Requests/GetSyncStatusResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetLastSuccessfulSync

Gets the status of the last successful sync

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetLastSuccessfulSyncRequest req = new GetLastSuccessfulSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetLastSuccessfulSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetLastSuccessfulSyncRequest](../../Models/Requests/GetLastSuccessfulSyncRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetLastSuccessfulSyncResponse](../../Models/Requests/GetLastSuccessfulSyncResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetLatestSync

Gets the latest sync status

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetLatestSyncRequest req = new GetLatestSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetLatestSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetLatestSyncRequest](../../Models/Requests/GetLatestSyncRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetLatestSyncResponse](../../Models/Requests/GetLatestSyncResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Get

Get the sync status for a specified sync

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncByIdRequest req = new GetSyncByIdRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
};

var res = await sdk.Sync.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetSyncByIdRequest](../../Models/Requests/GetSyncByIdRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetSyncByIdResponse](../../Models/Requests/GetSyncByIdResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## List

Gets a list of sync statuses

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSyncsRequest req = new ListSyncsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [ListSyncsRequest](../../Models/Requests/ListSyncsRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[ListSyncsResponse](../../Models/Requests/ListSyncsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |