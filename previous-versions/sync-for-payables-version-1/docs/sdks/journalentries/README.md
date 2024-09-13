# JournalEntries
(*JournalEntries*)

## Overview

Get, create, and update Journal entries.

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create journal entry model
* [Create](#create) - Create journal entry

## GetCreateModel

﻿The *Get create journal entry model* endpoint returns the expected data for the request payload when creating a [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company and integration.

[Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateJournalEntryModelRequest req = new GetCreateJournalEntryModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.JournalEntries.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCreateJournalEntryModelRequest](../../Models/Requests/GetCreateJournalEntryModelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetCreateJournalEntryModelResponse](../../Models/Requests/GetCreateJournalEntryModelResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Create

The *Create journal entry* endpoint creates a new [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company's connection.

[Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create journal entry model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-journalEntries-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateJournalEntryRequest req = new CreateJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    JournalEntry = new JournalEntry() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        PostedOn = "2022-10-23T00:00:00Z",
        CreatedOn = "2022-10-23T00:00:00Z",
        UpdatedOn = "2022-10-23T00:00:00Z",
        JournalLines = new List<JournalLine>() {
            new JournalLine() {
                NetAmount = 7964.74M,
                Tracking = new JournalLineTracking() {
                    RecordRefs = new List<TrackingRecordRef>() {
                        new TrackingRecordRef() {
                            DataType = Codat.Sync.Payables.V1.Models.Components.TrackingRecordRefDataType.TrackingCategories,
                        },
                    },
                },
            },
        },
        RecordRef = new JournalEntryRecordRef() {
            DataType = Codat.Sync.Payables.V1.Models.Components.JournalEntryRecordRefDataType.Transfers,
        },
    },
};

var res = await sdk.JournalEntries.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateJournalEntryRequest](../../Models/Requests/CreateJournalEntryRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[Models.Requests.CreateJournalEntryResponse](../../Models/Requests/CreateJournalEntryResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
