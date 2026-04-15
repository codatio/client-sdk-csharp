# AccountsReceivable.Invoices

## Overview

### Available Operations

* [ListReconciled](#listreconciled) - List reconciled invoices
* [List](#list) - List invoices
* [Get](#get) - Get invoice
* [DownloadPdf](#downloadpdf) - Get invoice as PDF
* [ListAttachments](#listattachments) - List invoice attachments
* [GetAttachment](#getattachment) - Get invoice attachment
* [DownloadAttachment](#downloadattachment) - Download invoice attachment

## ListReconciled

Gets a list of invoices linked to the corresponding banking transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-reconciled-invoices" method="get" path="/companies/{companyId}/reports/enhancedInvoices" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListReconciledInvoicesRequest req = new ListReconciledInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
};

var res = await sdk.AccountsReceivable.Invoices.ListReconciledAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListReconciledInvoicesRequest](../../Models/Requests/ListReconciledInvoicesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListReconciledInvoicesResponse](../../Models/Requests/ListReconciledInvoicesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## List

The *List invoices* endpoint returns a list of [invoices](https://docs.codat.io/lending-api#/schemas/Invoice) for a given company's connection.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    
### Useful queries

- Outstanding invoices - `query = amountDue > 0`
- Invoices due after a certain date: `query = dueDate > 2021-01-28`

[Read more about querying](https://docs.codat.io/using-the-api/querying).

### Tips and traps

To access the `paymentAllocations` property, ensure that the `payments` data type is queued and cached in Codat before retrieving `invoices` from Codat's cache.


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoices" method="get" path="/companies/{companyId}/data/invoices" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingInvoicesRequest](../../Models/Requests/ListAccountingInvoicesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingInvoicesResponse](../../Models/Requests/ListAccountingInvoicesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get invoice* endpoint returns a single invoice for a given invoiceId.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Tips and traps

To access the `paymentAllocations` property, ensure that the `payments` data type is queued and cached in Codat before retrieving `invoices` from Codat's cache.


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAccountingInvoiceRequest](../../Models/Requests/GetAccountingInvoiceRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetAccountingInvoiceResponse](../../Models/Requests/GetAccountingInvoiceResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## DownloadPdf

﻿Download invoice as a pdf.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="download-accounting-invoice-pdf" method="get" path="/companies/{companyId}/data/invoices/{invoiceId}/pdf" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadAccountingInvoicePdfRequest req = new DownloadAccountingInvoicePdfRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.DownloadPdfAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [DownloadAccountingInvoicePdfRequest](../../Models/Requests/DownloadAccountingInvoicePdfRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[DownloadAccountingInvoicePdfResponse](../../Models/Requests/DownloadAccountingInvoicePdfResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## ListAttachments

The *List invoice attachments* endpoint returns a list of attachments available to download for given `invoiceId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-accounting-invoice-attachments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/invoices/{invoiceId}/attachments" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingInvoiceAttachmentsRequest req = new ListAccountingInvoiceAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Invoices.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [ListAccountingInvoiceAttachmentsRequest](../../Models/Requests/ListAccountingInvoiceAttachmentsRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[ListAccountingInvoiceAttachmentsResponse](../../Models/Requests/ListAccountingInvoiceAttachmentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAttachment

The *Get invoice attachment* endpoint returns a specific attachment for a given `invoiceId` and `attachmentId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-accounting-invoice-attachment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/invoices/{invoiceId}/attachments/{attachmentId}" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingInvoiceAttachmentRequest req = new GetAccountingInvoiceAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.Invoices.GetAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetAccountingInvoiceAttachmentRequest](../../Models/Requests/GetAccountingInvoiceAttachmentRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetAccountingInvoiceAttachmentResponse](../../Models/Requests/GetAccountingInvoiceAttachmentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## DownloadAttachment

The *Download invoice attachment* endpoint downloads a specific attachment for a given `invoiceId` and `attachmentId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="download-accounting-invoice-attachment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/invoices/{invoiceId}/attachments/{attachmentId}/download" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadAccountingInvoiceAttachmentRequest req = new DownloadAccountingInvoiceAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.Invoices.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [DownloadAccountingInvoiceAttachmentRequest](../../Models/Requests/DownloadAccountingInvoiceAttachmentRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[DownloadAccountingInvoiceAttachmentResponse](../../Models/Requests/DownloadAccountingInvoiceAttachmentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |