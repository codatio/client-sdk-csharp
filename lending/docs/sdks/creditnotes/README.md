# AccountsReceivable.CreditNotes

## Overview

### Available Operations

* [List](#list) - List credit notes
* [Get](#get) - Get credit note

## List

The *List credit notes* endpoint returns a list of [credit notes](https://docs.codat.io/lending-api#/schemas/CreditNote) for a given company's connection.

[Credit notes](https://docs.codat.io/lending-api#/schemas/CreditNote) are issued to a customer to indicate debt, typically with reference to a previously issued invoice and/or purchase.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-credit-notes" method="get" path="/companies/{companyId}/data/creditNotes" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingCreditNotesRequest req = new ListAccountingCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.CreditNotes.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListAccountingCreditNotesRequest](../../Models/Requests/ListAccountingCreditNotesRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListAccountingCreditNotesResponse](../../Models/Requests/ListAccountingCreditNotesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get credit note* endpoint returns a single credit note for a given creditNoteId.

[Credit notes](https://docs.codat.io/lending-api#/schemas/CreditNote) are issued to a customer to indicate debt, typically with reference to a previously issued invoice and/or purchase.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-credit-note" method="get" path="/companies/{companyId}/data/creditNotes/{creditNoteId}" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCreditNoteRequest req = new GetAccountingCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CreditNoteId = "<id>",
};

var res = await sdk.AccountsReceivable.CreditNotes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetAccountingCreditNoteRequest](../../Models/Requests/GetAccountingCreditNoteRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetAccountingCreditNoteResponse](../../Models/Requests/GetAccountingCreditNoteResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |