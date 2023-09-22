# JournalEntries

## Overview

Journal entries

### Available Operations

* [Create](#create) - Create journal entry
* [GetCreateModel](#getcreatemodel) - Get create journal entry model

## Create

The *Create journal entry* endpoint creates a new [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company's connection.

[Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create journal entry model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-journalEntries-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.JournalEntries.CreateAsync(new CreateJournalEntryRequest() {
    JournalEntry = new JournalEntry() {
        CreatedOn = "2022-10-23T00:00:00.000Z",
        Description = "saepe",
        Id = "189dbb30-fcb3-43ea-855b-197cd44e2f52",
        JournalLines = new List<JournalLine>() {
            new JournalLine() {
                AccountRef = new AccountRef() {
                    Id = "d82d3513-bb6f-448b-a56b-cdb35ff2e4b2",
                    Name = "Audrey Durgan",
                },
                Currency = "rem",
                Description = "eligendi",
                NetAmount = 8536.06M,
                Tracking = new JournalLineTracking() {
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "accountTransaction",
                            Id = "e7319c17-7d52-45f7-bb11-4eeb52ff785f",
                        },
                    },
                },
            },
        },
        JournalRef = new JournalRef() {
            Id = "c37814d4-c98e-40c2-bb89-eb75dad636c6",
            Name = "Mrs. Donna Hand",
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        PostedOn = "2022-10-23T00:00:00.000Z",
        RecordRef = new JournalEntryRecordReference() {
            DataType = "accountTransaction",
            Id = "31180f73-9ae9-4e05-beb8-09e2810331f3",
        },
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "atque", new Dictionary<string, object>() {
                    { "beatae", "at" },
                } },
            },
        },
        UpdatedOn = "2022-10-23T00:00:00.000Z",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 794988,
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CreateJournalEntryRequest](../../models/operations/CreateJournalEntryRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[Models.Operations.CreateJournalEntryResponse](../../models/operations/CreateJournalEntryResponse.md)**


## GetCreateModel

﻿The *Get create journal entry model* endpoint returns the expected data for the request payload when creating a [journal entry](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) for a given company and integration.

[Journal entries](https://docs.codat.io/sync-for-payables-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support creating a journal entry.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.JournalEntries.GetCreateModelAsync(new GetCreateJournalEntryModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetCreateJournalEntryModelRequest](../../models/operations/GetCreateJournalEntryModelRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[GetCreateJournalEntryModelResponse](../../models/operations/GetCreateJournalEntryModelResponse.md)**

