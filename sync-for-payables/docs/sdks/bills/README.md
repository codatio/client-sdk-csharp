# Bills
(*Bills*)

## Overview

Get, create, and update Bills.

### Available Operations

* [GetBillOptions](#getbilloptions) - Get bill mapping options
* [List](#list) - List bills
* [Create](#create) - Create bill
* [UploadAttachment](#uploadattachment) - Upload bill attachment
* [ListAttachments](#listattachments) - List bill attachments
* [DownloadAttachment](#downloadattachment) - Download bill attachment

## GetBillOptions

﻿Use the *Get mapping options - Bills* endpoint to return a list of available mapping options for a given company's connection ID.

By default, this endpoint returns a list of active accounts and tax rates. You can use [querying](https://docs.codat.io/using-the-api/querying) to change that.

Mapping options are a set of accounts and tax rates used to configure the SMB's payables integration.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.GetBillOptionsAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    continuationToken: "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    statusQuery: "status=Archived"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    | Example                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CompanyId`                                                                                                                                                                    | *string*                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                             | Unique identifier for a company.                                                                                                                                               | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                                           |
| `ConnectionId`                                                                                                                                                                 | *string*                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                             | Unique identifier for a connection.                                                                                                                                            | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                                           |
| `ContinuationToken`                                                                                                                                                            | *string*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                             | Retrieve the next page of results using the continuation token from the previous response.                                                                                     | continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==                                                                                                     |
| `StatusQuery`                                                                                                                                                                  | *string*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                             | Codat query string allows you to filter by `status` (`status=Active\|\|status=Archived`). [Learn more](https://docs.codat.io/using-the-api/querying) about Codat's query string. | status=Archived                                                                                                                                                                |

### Response

**[GetMappingOptionsBillsResponse](../../Models/Requests/GetMappingOptionsBillsResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

By default, the endpoint will return all bills with a status of 'Open' & 'PartiallyPaid' to show all oustanding bills.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.ListAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    continuationToken: "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    query: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                 | Type                                                                                                                                                                                                                                                                                                                                                      | Required                                                                                                                                                                                                                                                                                                                                                  | Description                                                                                                                                                                                                                                                                                                                                               | Example                                                                                                                                                                                                                                                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                                                                                                                                               | *string*                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                        | Unique identifier for a company.                                                                                                                                                                                                                                                                                                                          | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                                                                                                                                                                                                                      |
| `ConnectionId`                                                                                                                                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                        | Unique identifier for a connection.                                                                                                                                                                                                                                                                                                                       | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                                                                                                                                                                                                                      |
| `ContinuationToken`                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                        | Retrieve the next page of results using the continuation token from the previous response.                                                                                                                                                                                                                                                                | continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==                                                                                                                                                                                                                                                                                |
| `Query`                                                                                                                                                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                        | Codat query string allows you to filter by `status` and `sourceModifiedDate`. Learn more about Codat's query string [here](https://docs.codat.io/using-the-api/querying). Platfrom specfic statuses: Xero supports  Open \| PartiallyPaid \| Paid \| Void \| Draft. Qbo supports Open \| PartiallyPaid \| Paid. FreeAgent supports Open \| PartiallyPaid \| Paid. |                                                                                                                                                                                                                                                                                                                                                           |

### Response

**[ListBillsResponse](../../Models/Requests/ListBillsResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Openapi.Models.Errors.ErrorMessage  | 400,401,402,403,404,409,429,500,503 | application/json                    |
| Openapi.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |


## Create

The *Create bill* endpoint creates a new [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.CreateAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    idempotencyKey: "<value>",
    billPrototype: new BillPrototype() {
        SupplierRef = new SupplierRef() {
            Id = "<id>",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "USD",
        Status = Openapi.Models.Components.BillStatus.Open,
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 | Example                                                                     |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `CompanyId`                                                                 | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a company.                                            | 8a210b68-6988-11ed-a1eb-0242ac120002                                        |
| `ConnectionId`                                                              | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a connection.                                         | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                        |
| `IdempotencyKey`                                                            | *string*                                                                    | :heavy_minus_sign:                                                          | A unique identifier to ensure idempotent behaviour for subsequent requests. |                                                                             |
| `BillPrototype`                                                             | [BillPrototype](../../Models/Components/BillPrototype.md)                   | :heavy_minus_sign:                                                          | N/A                                                                         |                                                                             |

### Response

**[CreateBillResponse](../../Models/Requests/CreateBillResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Openapi.Models.Errors.ErrorMessage  | 400,401,402,403,404,409,429,500,503 | application/json                    |
| Openapi.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |


## UploadAttachment

The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.UploadAttachmentAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    billId: "EILBDVJVNUAGVKRQ",
    attachmentUpload: new AttachmentUpload() {
        File = new CodatFile() {
            FileName = "your_file_here",
            Content = System.Text.Encoding.UTF8.GetBytes("0x3ABc1980Ef"),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     | Example                                                         |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `CompanyId`                                                     | *string*                                                        | :heavy_check_mark:                                              | Unique identifier for a company.                                | 8a210b68-6988-11ed-a1eb-0242ac120002                            |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | Unique identifier for a connection.                             | 2e9d2c44-f675-40ba-8049-353bfcb5e171                            |
| `BillId`                                                        | *string*                                                        | :heavy_check_mark:                                              | Unique identifier for a bill.                                   | 13d946f0-c5d5-42bc-b092-97ece17923ab                            |
| `AttachmentUpload`                                              | [AttachmentUpload](../../Models/Components/AttachmentUpload.md) | :heavy_minus_sign:                                              | N/A                                                             |                                                                 |

### Response

**[UploadBillAttachmentResponse](../../Models/Requests/UploadBillAttachmentResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.ListAttachmentsAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    billId: "EILBDVJVNUAGVKRQ"
);

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |
| `ConnectionId`                       | *string*                             | :heavy_check_mark:                   | Unique identifier for a connection.  | 2e9d2c44-f675-40ba-8049-353bfcb5e171 |
| `BillId`                             | *string*                             | :heavy_check_mark:                   | Unique identifier for a bill.        | 13d946f0-c5d5-42bc-b092-97ece17923ab |

### Response

**[ListBillAttachmentsResponse](../../Models/Requests/ListBillAttachmentsResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.


### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Bills.DownloadAttachmentAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    billId: "EILBDVJVNUAGVKRQ",
    attachmentId: "8a210b68-6988-11ed-a1eb-0242ac120002"
);

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |
| `ConnectionId`                       | *string*                             | :heavy_check_mark:                   | Unique identifier for a connection.  | 2e9d2c44-f675-40ba-8049-353bfcb5e171 |
| `BillId`                             | *string*                             | :heavy_check_mark:                   | Unique identifier for a bill.        | 13d946f0-c5d5-42bc-b092-97ece17923ab |
| `AttachmentId`                       | *string*                             | :heavy_check_mark:                   | Unique identifier for an attachment. | 8a210b68-6988-11ed-a1eb-0242ac120002 |

### Response

**[DownloadBillAttachmentResponse](../../Models/Requests/DownloadBillAttachmentResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
