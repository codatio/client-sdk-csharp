# journalEntries

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
        Description = "nam",
        Id = "dc41ff5d-4e2a-4e4f-b5cb-35d17638f1ed",
        JournalLines = new List<JournalLine>() {
            new JournalLine() {
                AccountRef = new AccountRef() {
                    Id = "78359ecc-5cb8-460f-8cd5-80ba73810e4f",
                    Name = "Don Hagenes",
                },
                Currency = "magni",
                Description = "excepturi",
                NetAmount = 4576.85F,
                Tracking = new JournalLineTracking() {
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "transfer",
                            Id = "3b1dd3bb-ce24-47b7-a84e-ff50126d71cf",
                        },
                        new RecordRef() {
                            DataType = "transfer",
                            Id = "bd0eb74b-8421-4953-b44b-d3c43159d33e",
                        },
                        new RecordRef() {
                            DataType = "invoice",
                            Id = "953c0011-3986-43aa-81e6-c31cc2f1fcb5",
                        },
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "c9a41ffb-e9cb-4d79-9ee6-5e076cc7abf6",
                        },
                    },
                },
            },
            new JournalLine() {
                AccountRef = new AccountRef() {
                    Id = "16ea5c71-6419-434b-90f2-e09d19d2fc2f",
                    Name = "Merle Cormier Jr.",
                },
                Currency = "nemo",
                Description = "provident",
                NetAmount = 2529.57F,
                Tracking = new JournalLineTracking() {
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "accountTransaction",
                            Id = "935d237a-72f9-4084-9d6a-ed4aecb7537c",
                        },
                        new RecordRef() {
                            DataType = "transfer",
                            Id = "9222c9ff-5749-41aa-bfa2-e761f0ca4d45",
                        },
                    },
                },
            },
            new JournalLine() {
                AccountRef = new AccountRef() {
                    Id = "6ef1031e-6899-4f0c-a001-e22cd55cc058",
                    Name = "Hattie Botsford",
                },
                Currency = "possimus",
                Description = "nihil",
                NetAmount = 3758.77F,
                Tracking = new JournalLineTracking() {
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "accountTransaction",
                            Id = "71fc820c-65b0-437b-b8e0-cc885187e4de",
                        },
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "4af28c5d-ddb4-46aa-9cfd-6d828da01319",
                        },
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "12964664-5c1d-481f-a904-2f569b7aff0e",
                        },
                        new RecordRef() {
                            DataType = "accountTransaction",
                            Id = "2216cbe0-71bc-4163-a279-a3b084da9925",
                        },
                    },
                },
            },
        },
        JournalRef = new JournalRef() {
            Id = "7d04f408-47a7-442d-8449-6cbdeecf6b99",
            Name = "Wilbert Jerde",
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        PostedOn = "2022-10-23T00:00:00.000Z",
        RecordRef = new JournalEntryRecordReference() {
            DataType = "transfer",
            Id = "bfdf55c2-94c0-460b-86a1-287764eef6d0",
        },
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "temporibus", new Dictionary<string, object>() {
                    { "itaque", "nulla" },
                    { "excepturi", "quod" },
                } },
                { "in", new Dictionary<string, object>() {
                    { "temporibus", "temporibus" },
                } },
            },
        },
        UpdatedOn = "2022-10-23T00:00:00.000Z",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 247927,
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

