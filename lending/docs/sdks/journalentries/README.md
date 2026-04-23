# Transactions.JournalEntries

## Overview

### Available Operations

* [List](#list) - List journal entries
* [Get](#get) - Get journal entry

## List

The *List journal entries* endpoint returns a list of [journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) for a given company's connection.

[Journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-journal-entries" method="get" path="/companies/{companyId}/data/journalEntries" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalEntriesRequest req = new ListAccountingJournalEntriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.JournalEntries.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListAccountingJournalEntriesRequest](../../Models/Requests/ListAccountingJournalEntriesRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListAccountingJournalEntriesResponse](../../Models/Requests/ListAccountingJournalEntriesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get journal entry* endpoint returns a single journal entry for a given journalEntryId.

[Journal entries](https://docs.codat.io/lending-api#/schemas/JournalEntry) are  made in a company's general ledger, or accounts, when transactions are approved.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal-entry" method="get" path="/companies/{companyId}/data/journalEntries/{journalEntryId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalEntryRequest req = new GetAccountingJournalEntryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalEntryId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.JournalEntries.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetAccountingJournalEntryRequest](../../Models/Requests/GetAccountingJournalEntryRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetAccountingJournalEntryResponse](../../Models/Requests/GetAccountingJournalEntryResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |