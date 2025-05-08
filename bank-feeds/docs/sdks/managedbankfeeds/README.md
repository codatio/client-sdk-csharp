# ManagedBankFeeds
(*ManagedBankFeeds*)

## Overview

Manage bank feed syncs for source accounts.

### Available Operations

* [FetchManagedBankFeedSyncById](#fetchmanagedbankfeedsyncbyid) - Get sync
* [Get](#get) - Get latest sync
* [RunManagedBankFeedAdhocSync](#runmanagedbankfeedadhocsync) - Run ad-hoc sync

## FetchManagedBankFeedSyncById

The _Get sync_ endpoint returns the [sync status](https://docs.codat.io/bank-feeds-api#/schemas/SyncStatusResult) for a given 'syncId'. 

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

FetchManagedBankFeedSyncByIdRequest req = new FetchManagedBankFeedSyncByIdRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SourceAccountId = "<id>",
    SyncId = "00d2db9c-5a7e-484c-aa9d-2c5fea34f8c4",
};

var res = await sdk.ManagedBankFeeds.FetchManagedBankFeedSyncByIdAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [FetchManagedBankFeedSyncByIdRequest](../../Models/Operations/FetchManagedBankFeedSyncByIdRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[FetchManagedBankFeedSyncByIdResponse](../../Models/Operations/FetchManagedBankFeedSyncByIdResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                    | application/json                           |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 500, 503                                   | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## Get

The _Get latest sync_ endpoint returns the status for a given source account's [most recent sync](https://docs.codat.io/bank-feeds-api#/schemas/SyncStatusResult). 

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetLatestManagedBankFeedSyncRequest req = new GetLatestManagedBankFeedSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SourceAccountId = "<id>",
};

var res = await sdk.ManagedBankFeeds.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetLatestManagedBankFeedSyncRequest](../../Models/Operations/GetLatestManagedBankFeedSyncRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GetLatestManagedBankFeedSyncResponse](../../Models/Operations/GetLatestManagedBankFeedSyncResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                    | application/json                           |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 500, 503                                   | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## RunManagedBankFeedAdhocSync

The _Run ad-hoc sync_ endpoint immediately runs a sync with a fetch period from the last successful sync to the execution time of the new sync.

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

Use either the [_Get latest sync_](https://docs.codat.io/bank-feeds-api#/operations/get-latest-managed-bank-feed-sync) endpoint or the [_Get sync_](https://docs.codat.io/bank-feeds-api#/operations/fetch-managed-bank-feed-sync-by-id) endpoint to get the result of this sync.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

RunManagedBankFeedAdhocSyncRequest req = new RunManagedBankFeedAdhocSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SourceAccountId = "<id>",
};

var res = await sdk.ManagedBankFeeds.RunManagedBankFeedAdhocSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [RunManagedBankFeedAdhocSyncRequest](../../Models/Operations/RunManagedBankFeedAdhocSyncRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[RunManagedBankFeedAdhocSyncResponse](../../Models/Operations/RunManagedBankFeedAdhocSyncResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429          | application/json                           |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 500, 503                                   | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |