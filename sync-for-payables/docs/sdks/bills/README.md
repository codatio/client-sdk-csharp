# Bills
(*Bills*)

## Overview

Bills

### Available Operations

* [Create](#create) - Create bill
* [Delete](#delete) - Delete bill
* [DeleteAttachment](#deleteattachment) - Delete bill attachment
* [DownloadAttachment](#downloadattachment) - Download bill attachment
* [Get](#get) - Get bill
* [GetAttachment](#getattachment) - Get bill attachment
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update bill model
* [List](#list) - List bills
* [ListAttachments](#listattachments) - List bill attachments
* [Update](#update) - Update bill
* [UploadAttachment](#uploadattachment) - Upload bill attachment

## Create

The *Create bill* endpoint creates a new [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bills-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating a bill.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.CreateAsync(new CreateBillRequest() {
    Bill = new Bill() {
        Currency = "USD",
        DueDate = "2022-10-23T00:00:00.000Z",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {},
                ItemRef = new ItemRef() {
                    Id = "<ID>",
                },
                PurchaseOrderLineRef = new RecordLineReference() {},
                Quantity = 8592.13M,
                TaxRateRef = new TaxRateRef() {},
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                        },
                    },
                    CustomerRef = new CustomerRef() {
                        Id = "<ID>",
                    },
                    IsBilledTo = BilledToType.NotApplicable,
                    IsRebilledTo = BilledToType.NotApplicable,
                    ProjectRef = new AccountingProjectReference() {
                        Id = "<ID>",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "<ID>",
                    },
                },
                UnitAmount = 1343.65M,
            },
        },
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new BillAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {},
                    Currency = "EUR",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                },
            },
        },
        PurchaseOrderRefs = new List<PurchaseOrderReference>() {
            new PurchaseOrderReference() {},
        },
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = BillStatus.Draft,
        SubTotal = 0.86M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "key", new Dictionary<string, object>() {
                    { "key", "string" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
        },
        TaxAmount = 4552.22M,
        TotalAmount = 1697.27M,
        WithholdingTax = new List<WithholdingTax>() {
            new WithholdingTax() {
                Amount = 3015.1M,
                Name = "string",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateBillRequest](../../Models/Operations/CreateBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[Models.Operations.CreateBillResponse](../../Models/Operations/CreateBillResponse.md)**


## Delete

The *Delete bill* endpoint allows you to delete a specified bill from an accounting platform. 

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are itemized records of goods received or services provided to the SMB.

### Process 
1. Pass the `{billId}` to the *Delete bill* endpoint and store the `pushOperationKey` returned.
2. Check the status of the delete operation by checking the status of the push operation either via
    1. [Push operation webhook](https://docs.codat.io/introduction/webhooks/core-rules-types#push-operation-status-has-changed) (advised),
    2. [Push operation status endpoint](https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation).

   A `Success` status indicates that the bill object was deleted from the accounting platform.
3. (Optional) Check that the bill was deleted from the accounting platform.

### Effect on related objects

Be aware that deleting a bill from an accounting platform might cause related objects to be modified. For example, if you delete a paid bill in QuickBooks Online, the bill is deleted but the bill payment against that bill is not. The bill payment is converted to a payment on account.

## Integration specifics
Integrations that support soft delete do not permanently delete the object in the accounting platform.

| Integration | Soft Delete | Details                                                                                                      |  
|-------------|-------------|--------------------------------------------------------------------------------------------------------------|
| QuickBooks Online | No          | -                                                                                                            |
| Oracle NetSuite   | No          | When deleting a bill that's already linked to a bill payment, you must delete the linked bill payment first. |                                                                                                      |
| Sage Intacct   | No          | When deleting a bill that's already linked to a bill payment, you must delete the linked bill payment first. |

> **Supported Integrations**
> 
> This functionality is currently supported for our QuickBooks Online, Xero, Oracle NetSuite and Sage Intacct integrations.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.DeleteAsync(new DeleteBillRequest() {
    BillId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [DeleteBillRequest](../../Models/Operations/DeleteBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[DeleteBillResponse](../../Models/Operations/DeleteBillResponse.md)**


## DeleteAttachment

The *Delete bill attachment* endpoint allows you to delete a specified bill attachment from an accounting platform.  

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices
that represent the SMB's financial obligations to their supplier for a
purchase of goods or services. 

### Process  

1. Pass the `{billId}` and `{attachmentId}` to the *Delete bill attachment* endpoint and store the `pushOperationKey` returned. 

2. Check the status of the delete operation by checking the status of push operation either via 

1. [Push operation webhook](https://docs.codat.io/introduction/webhookscore-rules-types#push-operation-status-has-changed) (advised), 

2. [Push operation status endpoint](https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation). A `Success` status indicates that the bill attachment object was deleted from the accounting platform. 

3. (Optional) Check that the bill attachment was deleted from the accounting platform. 

>**Supported Integrations**
>
>This functionality is currently only supported for our QuickBooks Online integration. 

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.DeleteAttachmentAsync(new DeleteBillAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [DeleteBillAttachmentRequest](../../Models/Operations/DeleteBillAttachmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[DeleteBillAttachmentResponse](../../Models/Operations/DeleteBillAttachmentResponse.md)**


## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.DownloadAttachmentAsync(new DownloadBillAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [DownloadBillAttachmentRequest](../../Models/Operations/DownloadBillAttachmentRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[DownloadBillAttachmentResponse](../../Models/Operations/DownloadBillAttachmentResponse.md)**


## Get

The *Get bill* endpoint returns a single bill for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a specific bill.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.GetAsync(new GetBillRequest() {
    BillId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetBillRequest](../../Models/Operations/GetBillRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[GetBillResponse](../../Models/Operations/GetBillResponse.md)**


## GetAttachment

The *Get bill attachment* endpoint returns a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a bill attachment.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.GetAttachmentAsync(new GetBillAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetBillAttachmentRequest](../../Models/Operations/GetBillAttachmentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetBillAttachmentResponse](../../Models/Operations/GetBillAttachmentResponse.md)**


## GetCreateUpdateModel

﻿The *Get create/update bill model* endpoint returns the expected data for the request payload when creating and updating a [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company and integration.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating and updating a bill.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.GetCreateUpdateModelAsync(new GetCreateUpdateBillModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetCreateUpdateBillModelRequest](../../Models/Operations/GetCreateUpdateBillModelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetCreateUpdateBillModelResponse](../../Models/Operations/GetCreateUpdateBillModelResponse.md)**


## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.ListAsync(new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListBillsRequest](../../Models/Operations/ListBillsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListBillsResponse](../../Models/Operations/ListBillsResponse.md)**


## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support listing bill attachments.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.ListAttachmentsAsync(new ListBillAttachmentsRequest() {
    BillId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListBillAttachmentsRequest](../../Models/Operations/ListBillAttachmentsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ListBillAttachmentsResponse](../../Models/Operations/ListBillAttachmentsResponse.md)**


## Update

The *Update bill* endpoint updates an existing [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bills-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating a bill.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.UpdateAsync(new UpdateBillRequest() {
    Bill = new Bill() {
        Currency = "EUR",
        DueDate = "2022-10-23T00:00:00.000Z",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {},
                ItemRef = new ItemRef() {
                    Id = "<ID>",
                },
                PurchaseOrderLineRef = new RecordLineReference() {},
                Quantity = 156.52M,
                TaxRateRef = new TaxRateRef() {},
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                        },
                    },
                    CustomerRef = new CustomerRef() {
                        Id = "<ID>",
                    },
                    IsBilledTo = BilledToType.NotApplicable,
                    IsRebilledTo = BilledToType.Customer,
                    ProjectRef = new AccountingProjectReference() {
                        Id = "<ID>",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "<ID>",
                    },
                },
                UnitAmount = 9914.64M,
            },
        },
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new BillAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {},
                    Currency = "USD",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                },
            },
        },
        PurchaseOrderRefs = new List<PurchaseOrderReference>() {
            new PurchaseOrderReference() {},
        },
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = BillStatus.Unknown,
        SubTotal = 540.62M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "key", new Dictionary<string, object>() {
                    { "key", "string" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
        },
        TaxAmount = 2782.81M,
        TotalAmount = 8965.01M,
        WithholdingTax = new List<WithholdingTax>() {
            new WithholdingTax() {
                Amount = 4995.57M,
                Name = "string",
            },
        },
    },
    BillId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [UpdateBillRequest](../../Models/Operations/UpdateBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[Models.Operations.UpdateBillResponse](../../Models/Operations/UpdateBillResponse.md)**


## UploadAttachment

The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

For more details on supported file types by integration see [Attachments](https://docs.codat.io/sync-for-payables-api#/schemas/Attachment).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support uploading a bill attachment.


### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.UploadAttachmentAsync(new UploadBillAttachmentRequest() {
    RequestBody = new UploadBillAttachmentRequestBody() {
        Content = "0xE3ABc1980E as bytes <<<>>>",
        FileName = "elegant_producer_electric.jpeg",
    },
    BillId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UploadBillAttachmentRequest](../../Models/Operations/UploadBillAttachmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[UploadBillAttachmentResponse](../../Models/Operations/UploadBillAttachmentResponse.md)**

