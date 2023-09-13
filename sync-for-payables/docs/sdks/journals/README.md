# journals

## Overview

Journals

### Available Operations

* [Create](#create) - Create journal
* [Get](#get) - Get journal
* [GetCreateModel](#getcreatemodel) - Get create journal model
* [List](#list) - List journals

## Create

The *Create journal* endpoint creates a new [journal](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) are used to record all the financial transactions of a company.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create journal model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-journals-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support creating a journal.


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

var res = await sdk.Journals.CreateAsync(new CreateJournalRequest() {
    Journal = new Journal() {
        CreatedOn = "2022-10-23T00:00:00.000Z",
        HasChildren = false,
        Id = "981d4c70-0b60-47f3-893c-73b9da3f2ced",
        JournalCode = "laborum",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Name = "Clarence Feeney Sr.",
        ParentId = "exercitationem",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.JournalStatus.Unknown,
        Type = "ab",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 72754,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateJournalRequest](../../models/operations/CreateJournalRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[Models.Operations.CreateJournalResponse](../../models/operations/CreateJournalResponse.md)**


## Get

The *Get journal* endpoint returns a single journal for a given `journalId`.

[Journals](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) are used to record all the financial transactions of a company.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support getting a specific journal.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


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

var res = await sdk.Journals.GetAsync(new GetJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "hic",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetJournalRequest](../../models/operations/GetJournalRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetJournalResponse](../../models/operations/GetJournalResponse.md)**


## GetCreateModel

The *Get create journal model* endpoint returns the expected data for the request payload when creating a [journal](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) for a given company and integration.

[Journals](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) are used to record all the financial transactions of a company.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support creating a journal.


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

var res = await sdk.Journals.GetCreateModelAsync(new GetCreateJournalModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetCreateJournalModelRequest](../../models/operations/GetCreateJournalModelRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetCreateJournalModelResponse](../../models/operations/GetCreateJournalModelResponse.md)**


## List

The *List journals* endpoint returns a list of [journals](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/sync-for-payables-api#/schemas/Journal) are used to record all the financial transactions of a company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

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

var res = await sdk.Journals.ListAsync(new ListJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "deserunt",
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListJournalsRequest](../../models/operations/ListJournalsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListJournalsResponse](../../models/operations/ListJournalsResponse.md)**
