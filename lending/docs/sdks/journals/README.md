# Transactions.Journals

## Overview

### Available Operations

* [List](#list) - List journals
* [Get](#get) - Get journal

## List

The *List journals* endpoint returns a list of [journals](https://docs.codat.io/lending-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/lending-api#/schemas/Journal) are used to record all the financial transactions of a company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-journals" method="get" path="/companies/{companyId}/data/journals" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-journals" method="get" path="/companies/{companyId}/data/journals" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-journals" method="get" path="/companies/{companyId}/data/journals" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-journals" method="get" path="/companies/{companyId}/data/journals" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-journals" method="get" path="/companies/{companyId}/data/journals" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingJournalsRequest](../../Models/Requests/ListAccountingJournalsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingJournalsResponse](../../Models/Requests/ListAccountingJournalsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get journal* endpoint returns a single journal for a given journalId.

[Journals](https://docs.codat.io/lending-api#/schemas/Journal) are used to record all the financial transactions of a company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal" method="get" path="/companies/{companyId}/data/journals/{journalId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<id>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal" method="get" path="/companies/{companyId}/data/journals/{journalId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<id>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal" method="get" path="/companies/{companyId}/data/journals/{journalId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<id>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal" method="get" path="/companies/{companyId}/data/journals/{journalId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<id>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-journal" method="get" path="/companies/{companyId}/data/journals/{journalId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<id>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAccountingJournalRequest](../../Models/Requests/GetAccountingJournalRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetAccountingJournalResponse](../../Models/Requests/GetAccountingJournalResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |