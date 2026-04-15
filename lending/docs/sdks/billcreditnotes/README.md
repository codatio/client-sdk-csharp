# AccountsPayable.BillCreditNotes

## Overview

### Available Operations

* [List](#list) - List bill credit notes
* [Get](#get) - Get bill credit note

## List

The *List bill credit notes* endpoint returns a list of [bill credit notes](https://docs.codat.io/lending-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/lending-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-credit-notes" method="get" path="/companies/{companyId}/data/billCreditNotes" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillCreditNotesRequest req = new ListAccountingBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillCreditNotes.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListAccountingBillCreditNotesRequest](../../Models/Requests/ListAccountingBillCreditNotesRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[ListAccountingBillCreditNotesResponse](../../Models/Requests/ListAccountingBillCreditNotesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get bill credit note* endpoint returns a single bill credit note for a given billCreditNoteId.

[Bill credit notes](https://docs.codat.io/lending-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-credit-note" method="get" path="/companies/{companyId}/data/billCreditNotes/{billCreditNoteId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillCreditNoteRequest req = new GetAccountingBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillCreditNotes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetAccountingBillCreditNoteRequest](../../Models/Requests/GetAccountingBillCreditNoteRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GetAccountingBillCreditNoteResponse](../../Models/Requests/GetAccountingBillCreditNoteResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |