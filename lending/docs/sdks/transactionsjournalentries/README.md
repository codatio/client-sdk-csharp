# TransactionsJournalEntriesSDK
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
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Transactions.JournalEntries.GetAsync(new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetAccountingJournalEntryRequest](../../models/operations/GetAccountingJournalEntryRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetAccountingJournalEntryResponse](../../models/operations/GetAccountingJournalEntryResponse.md)**


## List

The *List journal entries* endpoint returns a list of [journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) for a given company's connection.

[Journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Transactions.JournalEntries.ListAsync(new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListAccountingJournalEntriesRequest](../../models/operations/ListAccountingJournalEntriesRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[ListAccountingJournalEntriesResponse](../../models/operations/ListAccountingJournalEntriesResponse.md)**

