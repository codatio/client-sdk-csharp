# JournalEntries
(*Transactions.JournalEntries*)

### Available Operations

* [Get](#get) - Get journal entry
* [List](#list) - List journal entries

## Get

The *Get journal entry* endpoint returns a single journal entry for a given journalEntryId.

[Journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journalEntries) for integrations that support getting a specific journal entry.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "<value>",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetAccountingJournalEntryRequest](../../Models/Operations/GetAccountingJournalEntryRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetAccountingJournalEntryResponse](../../Models/Operations/GetAccountingJournalEntryResponse.md)**


## List

The *List journal entries* endpoint returns a list of [journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) for a given company's connection.

[Journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListAccountingJournalEntriesRequest](../../Models/Operations/ListAccountingJournalEntriesRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[ListAccountingJournalEntriesResponse](../../Models/Operations/ListAccountingJournalEntriesResponse.md)**

