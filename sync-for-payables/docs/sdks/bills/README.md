# Bills

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
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.CreateAsync(new CreateBillRequest() {
    Bill = new Bill() {
        AmountDue = 9167.27M,
        Currency = "EUR",
        CurrencyRate = 1138.16M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "a426555b-a3c2-4874-8ed5-3b88f3a8d8f5",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "0b2f2fb7-b194-4a27-ab26-916fe1f08f42",
                    Name = "Herbert Treutel",
                },
                Description = "occaecati",
                DiscountAmount = 5520.78M,
                DiscountPercentage = 9757.52M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "447f603e-8b44-45e8-8ca5-5efd20e457e1",
                    Name = "Jorge Langosh",
                },
                Quantity = 6805.15M,
                SubTotal = 5300.89M,
                TaxAmount = 6223.85M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 9447.08M,
                    Id = "be3a5aa8-e482-44d0-ab40-75088e518620",
                    Name = "Bernice Ullrich II",
                },
                TotalAmount = 9688.65M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "3b1194b8-abf6-403a-b9f9-dfe0ab7da8a5",
                            Name = "Ms. Alexandra VonRueden",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "asperiores",
                        Id = "86bc173d-689e-4ee9-926f-8d986e881ead",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "0e101256-3f94-4e29-a973-e922a57a15be",
                        Name = "Meghan Batz IV",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "07e2b6e3-ab88-445f-8597-a60ff2a54a31",
                        Name = "Arturo Hagenes",
                    },
                },
                UnitAmount = 2840M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "adipisci",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 4326.06M,
                    TotalAmount = 3679.27M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "e7956f92-51a5-4a9d-a660-ff57bfaad4f9",
                        Name = "Miss Timmy Runolfsdottir",
                    },
                    Currency = "USD",
                    CurrencyRate = 820.57M,
                    Id = "2c103264-8dc2-4f61-9199-ebfd0e9fe6c6",
                    Note = "dolorem",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "cumque",
                    TotalAmount = 6849.35M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "3aed0117-9963-412f-9e04-771778ff61d0",
                PurchaseOrderNumber = "dicta",
            },
        },
        Reference = "odio",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.PartiallyPaid,
        SubTotal = 4037.93M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "consectetur", new Dictionary<string, object>() {
                    { "aliquid", "ipsa" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "a15db6a6-6065-49a1-adea-ab5851d6c645",
            SupplierName = "expedita",
        },
        TaxAmount = 299.5M,
        TotalAmount = 5615.77M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 7372.54M,
                Name = "Doris Lemke MD",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 665678,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateBillRequest](../../models/operations/CreateBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[Models.Operations.CreateBillResponse](../../models/operations/CreateBillResponse.md)**


## Delete

The *Delete bill* endpoint allows you to delete a specified bill from an accounting platform. 

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are itemized records of goods received or services provided to the SMB.

### Process 
1. Pass the `{billId}` to the *Delete bill* endpoint and store the `pushOperationKey` returned.
2. Check the status of the delete operation by checking the status of push operation either via
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
| Oracle NetSuite   | No          | When deleting a bill that's already linked to a bill payment, you must delete the linked bill payment first. |

> **Supported Integrations**
> 
> This functionality is currently supported for our QuickBooks Online, Xero and Oracle NetSuite integrations.

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
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
| `request`                                                         | [DeleteBillRequest](../../models/operations/DeleteBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[DeleteBillResponse](../../models/operations/DeleteBillResponse.md)**


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
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.DeleteAttachmentAsync(new DeleteBillAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [DeleteBillAttachmentRequest](../../models/operations/DeleteBillAttachmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[DeleteBillAttachmentResponse](../../models/operations/DeleteBillAttachmentResponse.md)**


## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support downloading a bill attachment.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
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
| `request`                                                                                 | [DownloadBillAttachmentRequest](../../models/operations/DownloadBillAttachmentRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[DownloadBillAttachmentResponse](../../models/operations/DownloadBillAttachmentResponse.md)**


## Get

The *Get bill* endpoint returns a single bill for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a specific bill.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.GetAsync(new GetBillRequest() {
    BillId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetBillRequest](../../models/operations/GetBillRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[GetBillResponse](../../models/operations/GetBillResponse.md)**


## GetAttachment

The *Get bill attachment* endpoint returns a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support getting a bill attachment.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.GetAttachmentAsync(new GetBillAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetBillAttachmentRequest](../../models/operations/GetBillAttachmentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetBillAttachmentResponse](../../models/operations/GetBillAttachmentResponse.md)**


## GetCreateUpdateModel

﻿The *Get create/update bill model* endpoint returns the expected data for the request payload when creating and updating a [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company and integration.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating and updating a bill.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
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
| `request`                                                                                     | [GetCreateUpdateBillModelRequest](../../models/operations/GetCreateUpdateBillModelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetCreateUpdateBillModelResponse](../../models/operations/GetCreateUpdateBillModelResponse.md)**


## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.ListAsync(new ListBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "fuga",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListBillsRequest](../../models/operations/ListBillsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListBillsResponse](../../models/operations/ListBillsResponse.md)**


## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support listing bill attachments.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
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
| `request`                                                                           | [ListBillAttachmentsRequest](../../models/operations/ListBillAttachmentsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ListBillAttachmentsResponse](../../models/operations/ListBillAttachmentsResponse.md)**


## Update

The *Update bill* endpoint updates an existing [bill](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bills-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support creating a bill.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.UpdateAsync(new UpdateBillRequest() {
    Bill = new Bill() {
        AmountDue = 8913.15M,
        Currency = "GBP",
        CurrencyRate = 12.07M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "e6f8c5f3-50d8-4cdb-9a34-181430104218",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "3d5208ec-e7e2-453b-a684-51c6c6e205e1",
                    Name = "Teri Thiel",
                },
                Description = "sequi",
                DiscountAmount = 9873.49M,
                DiscountPercentage = 9180.92M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "c9578a64-5842-473a-8418-d162309fb092",
                    Name = "Miss Joey Dach",
                },
                Quantity = 9768.02M,
                SubTotal = 7196.2M,
                TaxAmount = 6085.93M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 9663.9M,
                    Id = "58c4d86e-68e4-4be0-9601-3f59da757a59",
                    Name = "Garrett Welch",
                },
                TotalAmount = 4043.06M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "6ef1caa3-383c-42be-b477-373c8d72f64d",
                            Name = "Dr. Muriel Reinger",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "porro",
                        Id = "4310661e-9634-49e1-8f9e-06e3a437000a",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "b6bc9b8f-759e-4ac5-9a97-41d311352965",
                        Name = "Wm Legros",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "20261143-5e13-49db-8225-9b1abda8c070",
                        Name = "Walter Beatty",
                    },
                },
                UnitAmount = 7551.06M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "voluptatem",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 1729.51M,
                    TotalAmount = 8247.98M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "1ad879ee-b966-45b8-9efb-d02bae0be2d7",
                        Name = "Fred Champlin",
                    },
                    Currency = "EUR",
                    CurrencyRate = 2393.37M,
                    Id = "ea4b5197-f924-443d-a7ce-52b895c537c6",
                    Note = "modi",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "magnam",
                    TotalAmount = 9149.71M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "fb0b3489-6c3c-4a5a-8fbe-2fd570757792",
                PurchaseOrderNumber = "error",
            },
        },
        Reference = "veritatis",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.PartiallyPaid,
        SubTotal = 8667.89M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "itaque", new Dictionary<string, object>() {
                    { "similique", "optio" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "646ecb57-3409-4e3e-b1e5-a2b12eb07f11",
            SupplierName = "laboriosam",
        },
        TaxAmount = 8634.71M,
        TotalAmount = 7294.48M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 5665.06M,
                Name = "Maurice Haag",
            },
        },
    },
    BillId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 574032,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [UpdateBillRequest](../../models/operations/UpdateBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[Models.Operations.UpdateBillResponse](../../models/operations/UpdateBillResponse.md)**


## UploadAttachment

The *Upload bill attachment* endpoint uploads an attachment and assigns it against a specific `billId`.

[Bills](https://docs.codat.io/sync-for-payables-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

**Integration-specific behaviour**

For more details on supported file types by integration see [Attachments](https://docs.codat.io/sync-for-payables-api#/schemas/Attachment).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bills) for integrations that support uploading a bill attachment.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Bills.UploadAttachmentAsync(new UploadBillAttachmentRequest() {
    RequestBody = new UploadBillAttachmentRequestBody() {
        Content = "enim as bytes <<<>>>",
        RequestBody = "hic",
    },
    BillId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UploadBillAttachmentRequest](../../models/operations/UploadBillAttachmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[UploadBillAttachmentResponse](../../models/operations/UploadBillAttachmentResponse.md)**

