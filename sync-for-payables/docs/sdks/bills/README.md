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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetMappingOptionsBillsRequest req = new GetMappingOptionsBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    StatusQuery = "status=Archived",
};

var res = await sdk.Bills.GetBillOptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetMappingOptionsBillsRequest](../../Models/Requests/GetMappingOptionsBillsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[GetMappingOptionsBillsResponse](../../Models/Requests/GetMappingOptionsBillsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

By default, the endpoint will return all bills with a status of 'Open' & 'PartiallyPaid' to show all oustanding bills.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [ListBillsRequest](../../Models/Requests/ListBillsRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[ListBillsResponse](../../Models/Requests/ListBillsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429, 500, 503    | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create bill* endpoint creates a new [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillRequest req = new CreateBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillPrototype = new BillPrototype() {
        SupplierRef = new SupplierRef() {
            Id = "<id>",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "USD",
        Status = Codat.Sync.Payables.Models.Components.BillStatus.Open,
    },
};

var res = await sdk.Bills.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CreateBillRequest](../../Models/Requests/CreateBillRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[CreateBillResponse](../../Models/Requests/CreateBillResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429, 500, 503    | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UploadAttachment

The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UploadBillAttachmentRequest req = new UploadBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "EILBDVJVNUAGVKRQ",
};

var res = await sdk.Bills.UploadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UploadBillAttachmentRequest](../../Models/Requests/UploadBillAttachmentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UploadBillAttachmentResponse](../../Models/Requests/UploadBillAttachmentResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillAttachmentsRequest req = new ListBillAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "EILBDVJVNUAGVKRQ",
};

var res = await sdk.Bills.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListBillAttachmentsRequest](../../Models/Requests/ListBillAttachmentsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListBillAttachmentsResponse](../../Models/Requests/ListBillAttachmentsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429, 500, 503         | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadBillAttachmentRequest req = new DownloadBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "EILBDVJVNUAGVKRQ",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Bills.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DownloadBillAttachmentRequest](../../Models/Requests/DownloadBillAttachmentRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DownloadBillAttachmentResponse](../../Models/Requests/DownloadBillAttachmentResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |