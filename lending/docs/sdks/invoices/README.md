# Invoices
(*AccountsReceivable.Invoices*)

### Available Operations

* [DownloadAttachment](#downloadattachment) - Download invoice attachment
* [DownloadPdf](#downloadpdf) - Get invoice as PDF
* [Get](#get) - Get invoice
* [GetAttachment](#getattachment) - Get invoice attachment
* [List](#list) - List invoices
* [ListAttachments](#listattachments) - List invoice attachments
* [ListReconciled](#listreconciled) - List reconciled invoices

## DownloadAttachment

The *Download invoice attachment* endpoint downloads a specific attachment for a given `invoiceId` and `attachmentId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=invoices) for integrations that support downloading an invoice attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DownloadAccountingInvoiceAttachmentRequest req = new DownloadAccountingInvoiceAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "<value>",
};

var res = await sdk.AccountsReceivable.Invoices.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [DownloadAccountingInvoiceAttachmentRequest](../../Models/Operations/DownloadAccountingInvoiceAttachmentRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |


### Response

**[DownloadAccountingInvoiceAttachmentResponse](../../Models/Operations/DownloadAccountingInvoiceAttachmentResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## DownloadPdf

﻿Download invoice as a pdf.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DownloadAccountingInvoicePdfRequest req = new DownloadAccountingInvoicePdfRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "<value>",
};

var res = await sdk.AccountsReceivable.Invoices.DownloadPdfAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [DownloadAccountingInvoicePdfRequest](../../Models/Operations/DownloadAccountingInvoicePdfRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[DownloadAccountingInvoicePdfResponse](../../Models/Operations/DownloadAccountingInvoicePdfResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## Get

The *Get invoice* endpoint returns a single invoice for a given invoiceId.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=invoices) for integrations that support getting a specific invoice.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingInvoiceRequest req = new GetAccountingInvoiceRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    InvoiceId = "<value>",
};

var res = await sdk.AccountsReceivable.Invoices.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingInvoiceRequest](../../Models/Operations/GetAccountingInvoiceRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingInvoiceResponse](../../Models/Operations/GetAccountingInvoiceResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## GetAttachment

The *Get invoice attachment* endpoint returns a specific attachment for a given `invoiceId` and `attachmentId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=invoices) for integrations that support getting an invoice attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingInvoiceAttachmentRequest req = new GetAccountingInvoiceAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "<value>",
};

var res = await sdk.AccountsReceivable.Invoices.GetAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingInvoiceAttachmentRequest](../../Models/Operations/GetAccountingInvoiceAttachmentRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingInvoiceAttachmentResponse](../../Models/Operations/GetAccountingInvoiceAttachmentResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## List

The *List invoices* endpoint returns a list of [invoices](https://docs.codat.io/lending-api#/schemas/Invoice) for a given company's connection.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    
### Useful queries

- Outstanding invoices - `query = amountDue > 0`
- Invoices due after a certain date: `query = dueDate > 2021-01-28`

[Read more about querying](https://docs.codat.io/using-the-api/querying).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingInvoicesRequest req = new ListAccountingInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.AccountsReceivable.Invoices.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingInvoicesRequest](../../Models/Operations/ListAccountingInvoicesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingInvoicesResponse](../../Models/Operations/ListAccountingInvoicesResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## ListAttachments

The *List invoice attachments* endpoint returns a list of attachments available to download for given `invoiceId`.

[Invoices](https://docs.codat.io/lending-api#/schemas/Invoice) are itemized records of goods sold or services provided to a customer.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=invoices) for integrations that support listing invoice attachments.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingInvoiceAttachmentsRequest req = new ListAccountingInvoiceAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    InvoiceId = "<value>",
};

var res = await sdk.AccountsReceivable.Invoices.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [ListAccountingInvoiceAttachmentsRequest](../../Models/Operations/ListAccountingInvoiceAttachmentsRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[ListAccountingInvoiceAttachmentsResponse](../../Models/Operations/ListAccountingInvoiceAttachmentsResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## ListReconciled

Gets a list of invoices linked to the corresponding banking transaction

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListReconciledInvoicesRequest req = new ListReconciledInvoicesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.AccountsReceivable.Invoices.ListReconciledAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListReconciledInvoicesRequest](../../Models/Operations/ListReconciledInvoicesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListReconciledInvoicesResponse](../../Models/Operations/ListReconciledInvoicesResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
