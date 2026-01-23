# ManagedBankFeeds

## Overview

Manage bank feed syncs for source accounts.

### Available Operations

* [GetSync](#getsync) - Get sync
* [GetLatestSync](#getlatestsync) - Get latest sync
* [RunAdHocSync](#runadhocsync) - Run ad-hoc sync

## GetSync

The _Get sync_ endpoint returns the [sync status](https://docs.codat.io/bank-feeds-api#/schemas/SyncStatusResult) for a given 'syncId'. 

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-managed-bank-feed-sync" method="get" path="/companies/{companyId}/connections/{connectionId}/bankFeedAccounts/{sourceAccountId}/managedBankFeeds/syncs/{syncId}" -->
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetManagedBankFeedSyncRequest req = new GetManagedBankFeedSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SourceAccountId = "<id>",
    SyncId = "823d304f-a204-4760-9b5d-b8a89bf29bed",
};

var res = await sdk.ManagedBankFeeds.GetSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetManagedBankFeedSyncRequest](../../Models/Operations/GetManagedBankFeedSyncRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetManagedBankFeedSyncResponse](../../Models/Operations/GetManagedBankFeedSyncResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                    | application/json                           |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 500, 503                                   | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## GetLatestSync

The _Get latest sync_ endpoint returns the status for a given source account's [most recent sync](https://docs.codat.io/bank-feeds-api#/schemas/SyncStatusResult). 

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-latest-managed-bank-feed-sync" method="get" path="/companies/{companyId}/connections/{connectionId}/bankFeedAccounts/{sourceAccountId}/managedBankFeeds/syncs/latest" -->
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

var res = await sdk.ManagedBankFeeds.GetLatestSyncAsync(req);

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

## RunAdHocSync

The _Run ad-hoc sync_ endpoint immediately runs a sync with a fetch period from the last successful sync to the execution time of the new sync.

A sync is a single execution that fetches bank transactions from a connected bank account and records them in the company's accounting software.

Use either the [_Get latest sync_](https://docs.codat.io/bank-feeds-api#/operations/get-latest-managed-bank-feed-sync) endpoint or the [_Get sync_](https://docs.codat.io/bank-feeds-api#/operations/fetch-managed-bank-feed-sync-by-id) endpoint to get the result of this sync.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="run-managed-bank-feed-ad-hoc-sync" method="post" path="/companies/{companyId}/connections/{connectionId}/bankFeedAccounts/{sourceAccountId}/managedBankFeeds/syncs" -->
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

RunManagedBankFeedAdHocSyncRequest req = new RunManagedBankFeedAdHocSyncRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SourceAccountId = "<id>",
};

var res = await sdk.ManagedBankFeeds.RunAdHocSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [RunManagedBankFeedAdHocSyncRequest](../../Models/Operations/RunManagedBankFeedAdHocSyncRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[RunManagedBankFeedAdHocSyncResponse](../../Models/Operations/RunManagedBankFeedAdHocSyncResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429          | application/json                           |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 500, 503                                   | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |