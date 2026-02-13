# Bills

## Overview

Get, create, and update Bills.

### Available Operations

* [GetBillOptions](#getbilloptions) - Get bill mapping options
* [List](#list) - List bills
* [Create](#create) - Create bill
* [Update](#update) - Update bill
* [UploadAttachment](#uploadattachment) - Upload bill attachment
* [ListAttachments](#listattachments) - List bill attachments
* [DownloadAttachment](#downloadattachment) - Download bill attachment

## GetBillOptions

﻿Use the *Get mapping options - Bills* endpoint to return a list of available mapping options for a given company's connection ID.

By default, this endpoint returns a list of active accounts and tax rates. You can use [querying](https://docs.codat.io/using-the-api/querying) to change that.

Mapping options are a set of accounts and tax rates used to configure the SMB's payables integration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-mapping-options-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/mappingOptions/bills" example="Mapping options" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

By default, the endpoint will return all bills with a status of 'Open' & 'PartiallyPaid' to show all oustanding bills.

### Example Usage: Bills

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Bills" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```
### Example Usage: Source modified date

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```
### Example Usage: Status (open)

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Status (open)" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "status=Open",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```
### Example Usage: Status (open) & source modified date

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Status (open) & source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=Open",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```
### Example Usage: Status (partially paid)

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Status (partially paid)" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "status=PartiallyPaid",
};

var res = await sdk.Bills.ListAsync(req);

// handle response
```
### Example Usage: Status (partially paid) & source modified date

<!-- UsageSnippet language="csharp" operationID="list-bills" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Status (partially paid) & source modified date" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillsRequest req = new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    Query = "sourceModifiedDate>2023-12-15T00:00:00.000Z&&status=PartiallyPaid",
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create bill* endpoint creates a new [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage: Create bill

<!-- UsageSnippet language="csharp" operationID="create-bill" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Create bill" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillRequest req = new CreateBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillPrototype = new BillPrototype() {
        Reference = "bill_b8qmmj4ksf1suax",
        SupplierRef = new SupplierRef() {
            Id = "1262c350-fe0f-40ec-aeff-41c95b4a45af",
            SupplierName = "DIISR - Small Business Services",
        },
        IssueDate = "2023-04-23T00:00:00",
        DueDate = "2023-04-23T00:00:00",
        Currency = "GBP",
        CurrencyRate = 1M,
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                Description = "Half day training - Microsoft Office",
                UnitAmount = 1800M,
                Quantity = 1M,
                TaxAmount = 360M,
                AccountRef = new BillAccountRef() {
                    Id = "46f9461e-788b-4906-8b74-d1ea17f6dc10",
                },
                TotalAmount = 2160M,
                TaxRateRef = new BillTaxRateRef() {
                    Id = "INPUT2",
                },
            },
            new BillLineItem() {
                Description = "Desktop/network support via email & phone.Per month fixed fee for minimum 20 hours/month.",
                UnitAmount = 4000M,
                Quantity = 1M,
                TaxAmount = 800M,
                AccountRef = new BillAccountRef() {
                    Id = "f96c9458-d724-47bf-8f74-a9d5726465ce",
                },
                TotalAmount = 4800M,
                TaxRateRef = new BillTaxRateRef() {
                    Id = "INPUT2",
                },
            },
            new BillLineItem() {
                Description = "Stationery charges",
                UnitAmount = 32M,
                Quantity = 8M,
                TaxAmount = 51.2M,
                AccountRef = new BillAccountRef() {
                    Id = "cba6527d-f102-4538-b421-e483233e9d5a",
                },
                TotalAmount = 307.2M,
                TaxRateRef = new BillTaxRateRef() {
                    Id = "INPUT2",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "dba3d4da-f9ed-4eee-8e0b-452d11fdb1fa",
                        DataType = DataType.TrackingCategories,
                    },
                },
            },
        },
        Status = BillStatus.Open,
    },
};

var res = await sdk.Bills.CreateAsync(req);

// handle response
```
### Example Usage: Created bill

<!-- UsageSnippet language="csharp" operationID="create-bill" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Created bill" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
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
        Currency = "GBP",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                TrackingRefs = null,
            },
        },
        Status = BillStatus.Open,
    },
};

var res = await sdk.Bills.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-bill" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
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
        Currency = "GBP",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                TrackingRefs = null,
            },
        },
        Status = BillStatus.Open,
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

The *Update bill* endpoint updates an existing [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Supported Integrations

| Integration                   | Supported |
|-------------------------------|-----------|
| FreeAgent                     | Yes       |
| QuickBooks Online             | Yes       |
| Xero                          | Yes       |
| Oracle NetSuite               | No        |
| Sage Intacct                  | No        |
| Zoho Books                    | No        |


### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="update-bill" method="put" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateBillRequest req = new UpdateBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPrototype = new BillPrototype() {
        SupplierRef = new SupplierRef() {
            Id = "<id>",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                        DataType = DataType.TrackingCategories,
                    },
                },
            },
        },
        Status = BillStatus.Open,
    },
};

var res = await sdk.Bills.UpdateAsync(req);

// handle response
```
### Example Usage: Update bill

<!-- UsageSnippet language="csharp" operationID="update-bill" method="put" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}" example="Update bill" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateBillRequest req = new UpdateBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPrototype = new BillPrototype() {
        Reference = "bill_updated_ref",
        SupplierRef = new SupplierRef() {
            Id = "1262c350-fe0f-40ec-aeff-41c95b4a45af",
        },
        IssueDate = "2023-04-23T00:00:00",
        DueDate = "2023-05-23T00:00:00",
        Currency = "GBP",
        CurrencyRate = 1M,
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                Description = "Updated line item - Microsoft Office training",
                UnitAmount = 2000M,
                Quantity = 1M,
                TaxAmount = 400M,
                AccountRef = new BillAccountRef() {
                    Id = "46f9461e-788b-4906-8b74-d1ea17f6dc10",
                },
                TotalAmount = 2400M,
                TaxRateRef = new BillTaxRateRef() {
                    Id = "INPUT2",
                },
            },
            new BillLineItem() {
                Description = "Desktop/network support via email & phone - updated rate",
                UnitAmount = 4500M,
                Quantity = 1M,
                TaxAmount = 900M,
                AccountRef = new BillAccountRef() {
                    Id = "f96c9458-d724-47bf-8f74-a9d5726465ce",
                },
                TotalAmount = 5400M,
                TaxRateRef = new BillTaxRateRef() {
                    Id = "INPUT2",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "dba3d4da-f9ed-4eee-8e0b-452d11fdb1fa",
                        DataType = DataType.TrackingCategories,
                    },
                },
            },
        },
        Status = BillStatus.Open,
    },
};

var res = await sdk.Bills.UpdateAsync(req);

// handle response
```
### Example Usage: Updated bill

<!-- UsageSnippet language="csharp" operationID="update-bill" method="put" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}" example="Updated bill" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateBillRequest req = new UpdateBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPrototype = new BillPrototype() {
        SupplierRef = new SupplierRef() {
            Id = "<id>",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                        DataType = DataType.TrackingCategories,
                    },
                },
            },
        },
        Status = BillStatus.Open,
    },
};

var res = await sdk.Bills.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [UpdateBillRequest](../../Models/Requests/UpdateBillRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[UpdateBillResponse](../../Models/Requests/UpdateBillResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UploadAttachment

The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="upload-bill-attachment" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/attachments" example="Attachment metadata" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UploadBillAttachmentRequest req = new UploadBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-bill-attachments" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/attachments" example="Success" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillAttachmentsRequest req = new ListBillAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="download-bill-attachment" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/attachments/{attachmentId}/download" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadBillAttachmentRequest req = new DownloadBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |