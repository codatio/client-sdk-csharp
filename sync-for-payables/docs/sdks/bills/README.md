# bills

## Overview

Bills

### Available Operations

* [Create](#create) - Create bill
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
        AmountDue = 2986.13F,
        Currency = "USD",
        CurrencyRate = 4609.09F,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "adc1ac60-0dec-4001-ac80-2e2ec09ff8f0",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "16ff3477-c13e-4902-8141-25b0960a6681",
                    Name = "Amy Murray",
                },
                Description = "magni",
                DiscountAmount = 6463.29F,
                DiscountPercentage = 9650.95F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "923c5949-f83f-4350-8f87-6ffb901c6ecb",
                    Name = "Joel Von",
                },
                Quantity = 1940.58F,
                SubTotal = 7581.94F,
                TaxAmount = 9928.87F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 4598.75F,
                    Id = "89ffafed-a53e-45ae-ae0a-c184c2b9c247",
                    Name = "Isaac Lowe",
                },
                TotalAmount = 2271.56F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "40e1942f-32e5-4505-9756-f5d56d0bd0af",
                            Name = "Elena Zieme I",
                        },
                        new TrackingCategoryRef() {
                            Id = "db4f62cb-a3f8-4941-aebc-0b80a6924d3b",
                            Name = "Eloise Rowe",
                        },
                        new TrackingCategoryRef() {
                            Id = "c8f89501-0f5d-4d3d-afa1-804e54c82f16",
                            Name = "Rex Ernser",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "cumque",
                        Id = "8873e484-380b-41f6-b8ca-275a60a04c49",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "c699171b-51c1-4bdb-9cf4-b888ebdfc4cc",
                        Name = "Lynn Marks",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "7fc0b2dc-e108-473e-82b0-06d678878ba8",
                        Name = "Kay Bradtke",
                    },
                    new TrackingCategoryRef() {
                        Id = "8208c54f-efa9-4c95-b2ea-c5565d307cfe",
                        Name = "Hugh Carroll III",
                    },
                    new TrackingCategoryRef() {
                        Id = "e2813fa4-a41c-4480-93f2-132af03102d5",
                        Name = "Danielle Willms",
                    },
                    new TrackingCategoryRef() {
                        Id = "c6f18bf9-621a-46a4-b77a-87ee3e4be752",
                        Name = "Gilbert Hayes",
                    },
                },
                UnitAmount = 2848.85F,
            },
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "418e3bb9-1c8d-4975-a0e8-419d8f84f144",
                    Name = "Ms. Jimmy Turcotte",
                },
                Description = "facere",
                DiscountAmount = 7890.16F,
                DiscountPercentage = 7690.47F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "4aa5f3ca-bd90-45a9-b2e0-56728227b2d3",
                    Name = "Bobbie Greenfelder MD",
                },
                Quantity = 9565.45F,
                SubTotal = 4630.5F,
                TaxAmount = 6671.69F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 3073.06F,
                    Id = "fa87cf53-5a6f-4ae5-8ebf-60c321f023b7",
                    Name = "Paulette Dibbert",
                },
                TotalAmount = 4939.45F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "e1a0cc8d-f79f-40a3-96d9-0c364b7c15df",
                            Name = "Hubert Russel V",
                        },
                        new TrackingCategoryRef() {
                            Id = "8b1c4ee2-c8c6-4ce6-91fe-eb1c7cbdb6ee",
                            Name = "Jessie Hahn",
                        },
                        new TrackingCategoryRef() {
                            Id = "8ba25317-747d-4c91-9ad2-caf5dd6723dc",
                            Name = "Shawna Heller",
                        },
                        new TrackingCategoryRef() {
                            Id = "2f3a6b70-0878-4756-943f-5a6c98b55554",
                            Name = "Naomi Bauch",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "doloremque",
                        Id = "bcacc6cb-d6b5-4f3e-8909-304f926bad25",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "819b474b-0ed2-40e5-a248-fff639a910ab",
                        Name = "Salvatore Paucek",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "676696e1-ec00-4221-b335-d89acb3ecfda",
                        Name = "Ellis Balistreri",
                    },
                },
                UnitAmount = 3075.32F,
            },
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "9ef03004-978a-461f-a1cf-20688f77c1ff",
                    Name = "Jared Blick",
                },
                Description = "fuga",
                DiscountAmount = 665.96F,
                DiscountPercentage = 4057.89F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "3f2a3c80-a97f-4f33-8cdd-f857a9e61876",
                    Name = "Marc O'Connell Sr.",
                },
                Quantity = 8600.27F,
                SubTotal = 1665.42F,
                TaxAmount = 6180.73F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 8511.99F,
                    Id = "fc94d6fe-cd79-4939-8066-a6d2d0003553",
                    Name = "Billie Schmitt",
                },
                TotalAmount = 390.47F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "6fa21e91-52cb-4311-9167-b8e3c8db0340",
                            Name = "Levi Johns",
                        },
                        new TrackingCategoryRef() {
                            Id = "64ffd455-906d-4126-bd48-e935c2c9e81f",
                            Name = "Elizabeth Roberts",
                        },
                        new TrackingCategoryRef() {
                            Id = "e43202d7-2165-4765-8664-1870d9d21f9a",
                            Name = "Miss Michael Ferry",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "debitis",
                        Id = "cc11a083-6429-4068-b850-2a55e7f73bc8",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "e320a319-f4ba-4df9-87c9-a867bc424266",
                        Name = "Mrs. Geraldine Lueilwitz",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "ca8ef51f-cb4c-4593-ac12-cdaad0ec7afe",
                        Name = "Robin Strosin PhD",
                    },
                    new TrackingCategoryRef() {
                        Id = "f448a47f-9390-4c58-8809-83dabf9ef3ff",
                        Name = "Levi Mohr",
                    },
                    new TrackingCategoryRef() {
                        Id = "f079af4d-3572-44cd-b0f4-d281187d5684",
                        Name = "Eloise Stoltenberg",
                    },
                    new TrackingCategoryRef() {
                        Id = "85a9065e-628b-4dfc-a032-b6c879923b7e",
                        Name = "Rosa Hand",
                    },
                },
                UnitAmount = 9897.65F,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "deserunt",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 7733.55F,
                    TotalAmount = 4013.88F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "891f82ce-1157-4172-b053-77dcfa89df97",
                        Name = "Tasha Dickinson",
                    },
                    Currency = "USD",
                    CurrencyRate = 5228.24F,
                    Id = "6092e9c3-ddc5-4f11-9dea-1026d541a4d1",
                    Note = "omnis",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "sapiente",
                    TotalAmount = 8876F,
                },
            },
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 1127.51F,
                    TotalAmount = 4878.39F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "80bccc0d-bbdd-4b48-8708-fb4e391e6bc1",
                        Name = "Vickie Sauer",
                    },
                    Currency = "GBP",
                    CurrencyRate = 9365.18F,
                    Id = "54599ea3-4226-40e9-b200-ce78a1bd8fb7",
                    Note = "culpa",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "fuga",
                    TotalAmount = 1175.46F,
                },
            },
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 7574.38F,
                    TotalAmount = 8855.23F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "723d4097-fa30-4e9a-b725-b29122030d83",
                        Name = "Dan Nolan",
                    },
                    Currency = "USD",
                    CurrencyRate = 4938.65F,
                    Id = "99d22e8c-1f84-4938-a5fd-c42c876c2c2d",
                    Note = "delectus",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "aliquam",
                    TotalAmount = 7579.62F,
                },
            },
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 756.1F,
                    TotalAmount = 7513.47F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "76230f84-1fb1-4bd2-bfdb-14db6be5a685",
                        Name = "Luther Leuschke",
                    },
                    Currency = "GBP",
                    CurrencyRate = 6715.68F,
                    Id = "e20da16f-c2b2-471a-a89c-57e854e90439",
                    Note = "quibusdam",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "consequuntur",
                    TotalAmount = 1594.69F,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "65694624-0708-44f7-ab37-cef02225194d",
                PurchaseOrderNumber = "quidem",
            },
            new BillPurchaseOrderReference() {
                Id = "55410adc-669a-4f90-a26c-7cdc981f0689",
                PurchaseOrderNumber = "corrupti",
            },
        },
        Reference = "quae",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.PartiallyPaid,
        SubTotal = 7304.37F,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "amet", new Dictionary<string, object>() {
                    { "minus", "hic" },
                } },
                { "similique", new Dictionary<string, object>() {
                    { "consectetur", "labore" },
                    { "laudantium", "cumque" },
                    { "adipisci", "veritatis" },
                } },
                { "nam", new Dictionary<string, object>() {
                    { "magnam", "aperiam" },
                    { "ducimus", "itaque" },
                    { "necessitatibus", "numquam" },
                    { "doloribus", "eligendi" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "f0c42b78-f156-4263-98a0-dc766324ccb0",
            SupplierName = "ea",
        },
        TaxAmount = 7713.21F,
        TotalAmount = 5184.32F,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 6651.83F,
                Name = "Mr. Louise Sipes",
            },
            new BillWithholdingTax() {
                Amount = 1364.32F,
                Name = "Miss Victor Kuhlman",
            },
            new BillWithholdingTax() {
                Amount = 8196.9F,
                Name = "Courtney Conroy",
            },
            new BillWithholdingTax() {
                Amount = 8506.28F,
                Name = "Kirk Heidenreich",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 704665,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateBillRequest](../../models/operations/CreateBillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[Models.Operations.CreateBillResponse](../../models/operations/CreateBillResponse.md)**


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
    Query = "dolore",
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
        AmountDue = 7053.07F,
        Currency = "USD",
        CurrencyRate = 3656.76F,
        DueDate = "2022-10-23T00:00:00.000Z",
        Id = "693352f7-4533-4994-978d-e3b6e9389f5a",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillLineItem>() {
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "7f662550-a283-482a-8483-afd2315bba65",
                    Name = "Debra Kerluke",
                },
                Description = "quae",
                DiscountAmount = 4090.21F,
                DiscountPercentage = 9891.22F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "5bf6ae59-1bc8-4bde-b361-2b63c205fda8",
                    Name = "Sarah Kuhn",
                },
                Quantity = 6839.8F,
                SubTotal = 4359.31F,
                TaxAmount = 5383.68F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 6382.19F,
                    Id = "9a35d086-b6f6-46fe-b020-e9f443b4257b",
                    Name = "Marshall Daugherty",
                },
                TotalAmount = 8301.97F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "da6a61ef-a219-4825-8fd0-a9eba47f7d3e",
                            Name = "Thomas Hahn",
                        },
                        new TrackingCategoryRef() {
                            Id = "40d6a183-1c87-4adf-996f-df1ad837ae80",
                            Name = "Ms. Terry Runolfsson",
                        },
                        new TrackingCategoryRef() {
                            Id = "95ba9986-78fa-43f6-9699-1af388ce0361",
                            Name = "Eva Gleichner",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "voluptate",
                        Id = "977a0ef2-f536-4028-afee-f934152ed7e2",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "f4c157de-aa71-470f-845a-ccf667aaf9bb",
                        Name = "Laurence Blick",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "e431d6bf-5c83-48fb-b8c2-0cb67fc4b425",
                        Name = "Perry Mayert",
                    },
                    new TrackingCategoryRef() {
                        Id = "234c9f7b-79df-4eb7-ba5c-38d4baf91e50",
                        Name = "Olive Windler",
                    },
                    new TrackingCategoryRef() {
                        Id = "0a54b475-f16f-456d-b85a-3c4ac631b99e",
                        Name = "Ella Runolfsdottir",
                    },
                    new TrackingCategoryRef() {
                        Id = "8f9fdb94-10f6-43bb-b817-837b01afdd78",
                        Name = "Chester Daugherty IV",
                    },
                },
                UnitAmount = 6138.48F,
            },
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "eb44873f-5033-4f19-9bf1-25ce4152eab9",
                    Name = "Lionel Klocko",
                },
                Description = "odit",
                DiscountAmount = 1383.06F,
                DiscountPercentage = 2593.74F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "a6a0e123-b784-47ec-99e1-f67f3c4cce4b",
                    Name = "Angel Kris",
                },
                Quantity = 4001.45F,
                SubTotal = 9961.01F,
                TaxAmount = 9570.32F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 2322.09F,
                    Id = "c5747501-357e-444f-91f8-b084c3197e19",
                    Name = "Rosie Conroy",
                },
                TotalAmount = 3088.66F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "7f94874c-2d5c-4c49-b223-3e66bd8fe5d0",
                            Name = "Jeannette Mante",
                        },
                        new TrackingCategoryRef() {
                            Id = "ef203873-2059-40cc-8109-6400313b3e50",
                            Name = "Debbie Windler",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "maiores",
                        Id = "e72dc407-7d0c-4c3f-808e-fc15ceb4d6e1",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "e0f75aed-f2ac-4ab5-8b99-1c926ddb5894",
                        Name = "Joyce Terry",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "1cbe6d95-02f0-4ea9-b0b6-9f7ac2f72f88",
                        Name = "Karen Barrows I",
                    },
                },
                UnitAmount = 5776.22F,
            },
            new BillLineItem() {
                AccountRef = new AccountRef() {
                    Id = "11608207-888e-4c66-983b-fe9659eb40ec",
                    Name = "Loretta Wehner",
                },
                Description = "nihil",
                DiscountAmount = 3452.7F,
                DiscountPercentage = 7023.39F,
                IsDirectCost = false,
                ItemRef = new ItemRef() {
                    Id = "0b532a4d-a37c-4baa-b445-2c4842c9b2ad",
                    Name = "Rose Stoltenberg",
                },
                Quantity = 8968.11F,
                SubTotal = 5316.06F,
                TaxAmount = 981.23F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 6493.73F,
                    Id = "88f44445-73fe-4cd4-b353-f63c8209379a",
                    Name = "Reginald McClure",
                },
                TotalAmount = 3210.07F,
                Tracking = new Tracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "bcf79da1-8a78-422b-b958-94e6861adb55",
                            Name = "Nick Torp",
                        },
                        new TrackingCategoryRef() {
                            Id = "751c9fe8-f750-42bf-9c34-50841f176445",
                            Name = "Wendy Kling",
                        },
                        new TrackingCategoryRef() {
                            Id = "3fb27e21-f862-4657-b36f-c6b9f587ce52",
                            Name = "Brooke Jacobs",
                        },
                        new TrackingCategoryRef() {
                            Id = "41a8312e-5047-4b4c-a1cc-b423abcdc91f",
                            Name = "Rex Rau",
                        },
                    },
                    CustomerRef = new TrackingCustomerRef() {
                        CompanyName = "totam",
                        Id = "8e71f6c4-8252-4d77-b1e7-fd074009ef8d",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new TrackingProjectRef() {
                        Id = "de1dd709-7b5d-4a08-857f-a6c78a216e19",
                        Name = "Pablo Wilkinson",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "61914981-40b6-44ff-8ae1-70ef03b5f37e",
                        Name = "Angie O'Hara",
                    },
                    new TrackingCategoryRef() {
                        Id = "85559667-32aa-45dc-b668-2cb70f8cfd5f",
                        Name = "Brent Weber MD",
                    },
                    new TrackingCategoryRef() {
                        Id = "9a9f7484-6e2c-4330-9db0-536d9e75ca00",
                        Name = "Lana Hauck",
                    },
                },
                UnitAmount = 1500.91F,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "et",
        PaymentAllocations = new List<BillPaymentAllocation>() {
            new BillPaymentAllocation() {
                Allocation = new BillPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 3322.37F,
                    TotalAmount = 6650.82F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "8bf92f97-428a-4d9a-9f8b-f8221125359d",
                        Name = "Guy Feest",
                    },
                    Currency = "EUR",
                    CurrencyRate = 4820.62F,
                    Id = "a79cd72c-d248-44da-a172-9f2ac41ef572",
                    Note = "quis",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "dicta",
                    TotalAmount = 1158.49F,
                },
            },
        },
        PurchaseOrderRefs = new List<BillPurchaseOrderReference>() {
            new BillPurchaseOrderReference() {
                Id = "9ac1e41d-8a23-4c23-a34f-2dfa4a197f6d",
                PurchaseOrderNumber = "recusandae",
            },
            new BillPurchaseOrderReference() {
                Id = "922151fe-1712-4099-853e-9f543d854439",
                PurchaseOrderNumber = "accusamus",
            },
        },
        Reference = "voluptates",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillStatus.Unknown,
        SubTotal = 2805.9F,
        SupplementalData = new BillSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "laboriosam", new Dictionary<string, object>() {
                    { "tempora", "aliquam" },
                } },
                { "dolorem", new Dictionary<string, object>() {
                    { "impedit", "architecto" },
                    { "minima", "magnam" },
                    { "vitae", "quos" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "8c2f56e8-5da7-4832-aabd-617c3b0d51a4",
            SupplierName = "ut",
        },
        TaxAmount = 6942.92F,
        TotalAmount = 9852.65F,
        WithholdingTax = new List<BillWithholdingTax>() {
            new BillWithholdingTax() {
                Amount = 1013.18F,
                Name = "Doug Stiedemann",
            },
        },
    },
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 434330,
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
        Content = "temporibus as bytes <<<>>>",
        RequestBody = "incidunt",
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

