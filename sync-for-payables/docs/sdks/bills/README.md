# BillsSDK
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
        AmountDue = 4865.89M,
        Currency = "USD",
        CurrencyRate = 6384.24M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "<ID>",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "<ID>",
                    Name = "South",
                },
                Description = "Vision-oriented responsive function",
                DiscountAmount = 9510.62M,
                DiscountPercentage = 8915.1M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "<ID>",
                    Name = "deposit",
                },
                Quantity = 3015.1M,
                SubTotal = 899.64M,
                TaxAmount = 7150.4M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 7926.2M,
                    Id = "<ID>",
                    Name = "Gasoline Screen mobile",
                },
                TotalAmount = 6562.56M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                            Name = "Durham after",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "Fay - Durgan",
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "<ID>",
                        Name = "Fiat",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "<ID>",
                        Name = "Grocery Borders Northwest",
                    },
                },
                UnitAmount = 6519.85M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "animated Minivan",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 808.14M,
                    TotalAmount = 2006.64M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "<ID>",
                        Name = "West",
                    },
                    Currency = "USD",
                    CurrencyRate = 3379.66M,
                    Id = "<ID>",
                    Note = "Towels",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "payment 1080p",
                    TotalAmount = 2597.72M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "<ID>",
                PurchaseOrderNumber = "silver Indiana",
            },
        },
        Reference = "Toyota Neptunium round",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.Open,
        SubTotal = 9057.54M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "in", new Dictionary<string, object>() {
                    { "pariatur", "Dollar" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
            SupplierName = "South",
        },
        TaxAmount = 4914.27M,
        TotalAmount = 2663.33M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 4904.2M,
                Name = "markets",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 924484,
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
    BillId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
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
    BillId = "EILBDVJVNUAGVKRQ",
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
    Query = "Northeast Metal Canada",
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
        AmountDue = 8574.78M,
        Currency = "GBP",
        CurrencyRate = 5971.29M,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "<ID>",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "<ID>",
                    Name = "dock Quality redundant",
                },
                Description = "Visionary bi-directional analyzer",
                DiscountAmount = 2782.81M,
                DiscountPercentage = 8965.01M,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "<ID>",
                    Name = "withdrawal extend",
                },
                Quantity = 2494.4M,
                SubTotal = 3668.07M,
                TaxAmount = 1395.79M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 6447.13M,
                    Id = "<ID>",
                    Name = "syndicate East Baht",
                },
                TotalAmount = 6298.17M,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                            Name = "guestbook driver users",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "Schroeder - Nienow",
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new TrackingProjectReference() {
                        Id = "<ID>",
                        Name = "Wooden Internal",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "<ID>",
                        Name = "Dodge brightly",
                    },
                },
                UnitAmount = 7115.64M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "frictionless haptic",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 8238.97M,
                    TotalAmount = 5143.61M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "<ID>",
                        Name = "Diesel Avon",
                    },
                    Currency = "GBP",
                    CurrencyRate = 8941.07M,
                    Id = "<ID>",
                    Note = "male hack",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "absolve West",
                    TotalAmount = 182.83M,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "<ID>",
                PurchaseOrderNumber = "quisquam",
            },
        },
        Reference = "deliverables Ergonomic Money",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.Paid,
        SubTotal = 4173.15M,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "repellat", new Dictionary<string, object>() {
                    { "voluptatibus", "Latvian" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
            SupplierName = "Chips Omnigender tremendously",
        },
        TaxAmount = 9620.25M,
        TotalAmount = 6952.8M,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 3189.59M,
                Name = "Benz",
            },
        },
    },
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 523103,
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
        Content = "v/ghW&IC$x as bytes <<<>>>",
        RequestBody = "Elegant Producer Electric",
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

