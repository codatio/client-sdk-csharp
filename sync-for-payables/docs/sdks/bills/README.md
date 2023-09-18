# Bills

## Overview

Bills

### Available Operations

* [Create](#create) - Create bill
* [Delete](#delete) - Delete bill
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
        AmountDue = 6897.68M,
        Currency = "USD",
        CurrencyRate = 583.56M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "b1ea4265-55ba-43c2-8744-ed53b88f3a8d",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "f5c0b2f2-fb7b-4194-a276-b26916fe1f08",
                    Name = "Troy Cormier",
                },
                Description = "necessitatibus",
                DiscountAmount = 2155.29M,
                DiscountPercentage = 4067.33M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "98f447f6-03e8-4b44-9e80-ca55efd20e45",
                    Name = "Cecelia Braun",
                },
                Quantity = 5106.29M,
                SubTotal = 7400.98M,
                TaxAmount = 3868.27M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 6805.15M,
                    Id = "89fbe3a5-aa8e-4482-8d0a-b4075088e518",
                    Name = "Jane Bailey",
                },
                TotalAmount = 9061.72M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "904f3b11-94b8-4abf-a03a-79f9dfe0ab7d",
                            Name = "Max O'Connell DDS",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "repudiandae",
                        Id = "187f86bc-173d-4689-aee9-526f8d986e88",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "ad4f0e10-1256-43f9-8e29-e973e922a57a",
                        Name = "Ana Predovic",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "e060807e-2b6e-43ab-8845-f0597a60ff2a",
                        Name = "Joanne Parisian DVM",
                    },
                },
                UnitAmount = 6072.49M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "molestiae",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 6330.62M,
                    TotalAmount = 2384.13M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "e865e795-6f92-451a-9a9d-a660ff57bfaa",
                        Name = "Edwin Wolf",
                    },
                    Currency = "EUR",
                    CurrencyRate = 7645.62M,
                    Id = "1b4512c1-0326-448d-82f6-15199ebfd0e9",
                    Note = "maiores",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "aliquid",
                    TotalAmount = 7809.31M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "632ca3ae-d011-4799-a312-fde04771778f",
                PurchaseOrderNumber = "reiciendis",
            },
        },
        Reference = "vel",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.Draft,
        SubTotal = 396.5M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "dicta", new Dictionary<string, object>() {
                    { "odio", "tempora" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "76360a15-db6a-4660-a59a-1adeaab5851d",
            SupplierName = "ex",
        },
        TaxAmount = 7758.03M,
        TotalAmount = 4053.73M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 2811.53M,
                Name = "Lula Bartell",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 399660,
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

﻿The *Delete bill* endpoint allows you to delete a specified bill from an accounting platform. 

[Bills](https://docs.codat.io/accounting-api#/schemas/Bill) are itemized records of goods received or services provided to the SMB.

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
> This functionality is currently only supported for our QuickBooks Online abd Oracle NetSuite integrations. Check out our [public roadmap](https://portal.productboard.com/codat/7-public-product-roadmap/tabs/46-accounting-api) to see what we're building next, and to submit ideas for new features.

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
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
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
    BillId = "7110701885",
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
    BillId = "7110701885",
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
    Query = "rerum",
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
    BillId = "7110701885",
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
        AmountDue = 6347.86M,
        Currency = "GBP",
        CurrencyRate = 9591.43M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "1ade008e-6f8c-45f3-90d8-cdb5a3418143",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "10421813-d520-48ec-a7e2-53b668451c6c",
                    Name = "Mrs. Kate Cronin",
                },
                Description = "quasi",
                DiscountAmount = 3925.69M,
                DiscountPercentage = 8711.03M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "eab3fec9-578a-4645-8427-3a8418d16230",
                    Name = "Miss Dominick Rogahn",
                },
                Quantity = 5790.11M,
                SubTotal = 6128.67M,
                TaxAmount = 1700.99M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 813.69M,
                    Id = "aefb9f58-c4d8-46e6-8e4b-e056013f59da",
                    Name = "Ida Kilback",
                },
                TotalAmount = 5718.44M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "ecfef66e-f1ca-4a33-83c2-beb477373c8d",
                            Name = "Christina Wolf",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "quibusdam",
                        Id = "1db1f2c4-3106-461e-9634-9e1cf9e06e3a",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "7000ae6b-6bc9-4b8f-b59e-ac55a9741d31",
                        Name = "Florence Hand",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "65bb8a72-0261-4143-9e13-9dbc2259b1ab",
                        Name = "Oliver Luettgen IV",
                    },
                },
                UnitAmount = 573.2M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "inventore",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 2928.88M,
                    TotalAmount = 7551.06M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "b0672d1a-d879-4eeb-9665-b85efbd02bae",
                        Name = "Mamie Torp",
                    },
                    Currency = "USD",
                    CurrencyRate = 5101.28M,
                    Id = "2259e3ea-4b51-497f-9244-3da7ce52b895",
                    Note = "placeat",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "neque",
                    TotalAmount = 4468.77M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "c6454efb-0b34-4896-83ca-5acfbe2fd570",
                PurchaseOrderNumber = "odio",
            },
        },
        Reference = "minima",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.PartiallyPaid,
        SubTotal = 5678.46M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "dolores", new Dictionary<string, object>() {
                    { "error", "veritatis" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "77deac64-6ecb-4573-809e-3eb1e5a2b12e",
            SupplierName = "nobis",
        },
        TaxAmount = 568.77M,
        TotalAmount = 4973.57M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 9804.86M,
                Name = "Joyce Howe",
            },
        },
    },
    BillId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 578210,
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
        Content = "nemo as bytes <<<>>>",
        RequestBody = "aliquam",
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
| `request`                                                                             | [UploadBillAttachmentRequest](../../models/operations/UploadBillAttachmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[UploadBillAttachmentResponse](../../models/operations/UploadBillAttachmentResponse.md)**

