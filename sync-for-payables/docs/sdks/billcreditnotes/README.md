# billCreditNotes

## Overview

Bill credit notes

### Available Operations

* [Create](#create) - Create bill credit note
* [Get](#get) - Get bill credit note
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update bill credit note model
* [List](#list) - List bill credit notes
* [Update](#update) - Update bill credit note

## Create

The *Create bill credit note* endpoint creates a new [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill credit note model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-billCreditNotes-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating a bill credit note.


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

var res = await sdk.BillCreditNotes.CreateAsync(new CreateBillCreditNoteRequest() {
    BillCreditNote = new BillCreditNote() {
        AllocatedOnDate = "2022-10-23T00:00:00.000Z",
        BillCreditNoteNumber = "91fe2a83-e161-4c21-929d-c5c10c4b07e5",
        Currency = "GBP",
        CurrencyRate = 8700.13F,
        DiscountPercentage = 0F,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "7cc78ca1-ba92-48fc-8167-42cb73920592",
                    Name = "Curtis Morissette",
                },
                Description = "saepe",
                DiscountAmount = 6818.2F,
                DiscountPercentage = 4499.5F,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "596eb10f-aaa2-4352-8595-5907aff1a3a2",
                    Name = "Shaun McCullough",
                },
                Quantity = 4663.11F,
                SubTotal = 4746.97F,
                TaxAmount = 2444.25F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 6235.1F,
                    Id = "251aa52c-3f5a-4d01-9da1-ffe78f097b00",
                    Name = "Mrs. April Wuckert",
                },
                TotalAmount = 4808.94F,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "b5e6e13b-99d4-488e-9e91-e450ad2abd44",
                            Name = "Beth McGlynn Sr.",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "assumenda",
                        Id = "502a94bb-4f63-4c96-9e9a-3efa77dfb14c",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectRef() {
                        Id = "6ae395ef-b9ba-488f-ba66-997074ba4469",
                        Name = "Duane Thiel II",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "959890af-a563-4e25-96fe-4c8b711e5b7f",
                        Name = "Louis Turner Sr.",
                    },
                },
                UnitAmount = 5083.15F,
            },
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "921cddc6-9260-41fb-976b-0d5f0d30c5fb",
                    Name = "Ernest Hayes",
                },
                Description = "eaque",
                DiscountAmount = 3389.85F,
                DiscountPercentage = 1999.96F,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "202c73d5-fe9b-490c-a890-9b3fe49a8d9c",
                    Name = "Toby Hahn",
                },
                Quantity = 2123.9F,
                SubTotal = 2098.43F,
                TaxAmount = 2224.43F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 1861.93F,
                    Id = "3f9b77f3-a410-4067-8ebf-69280d1ba77a",
                    Name = "Arturo Treutel",
                },
                TotalAmount = 4694.97F,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "7ae4203c-e5e6-4a95-98a0-d446ce2af7a7",
                            Name = "Rosalie White",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "accusamus",
                        Id = "453f870b-326b-45a7-b429-cdb1a8422bb6",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectRef() {
                        Id = "d2322715-bf0c-4bb1-a31b-8b90f3443a11",
                        Name = "Miss Billie Ward",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "f4b92187-9fce-4953-b73e-f7fbc7abd74d",
                        Name = "Earl Mosciski DVM",
                    },
                    new TrackingCategoryRef() {
                        Id = "5d2cff7c-70a4-4562-ad43-6813f16d9f5f",
                        Name = "Elbert Jenkins",
                    },
                    new TrackingCategoryRef() {
                        Id = "56146c3e-250f-4b00-8c42-e141aac366c8",
                        Name = "Drew Hoeger I",
                    },
                    new TrackingCategoryRef() {
                        Id = "42907474-778a-47bd-866d-28c10ab3cdca",
                        Name = "Ms. Ruby Hintz II",
                    },
                },
                UnitAmount = 8920.5F,
            },
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "523c7e0b-c717-48e4-b96f-2a70c688282a",
                    Name = "Randall Lindgren",
                },
                Description = "nisi",
                DiscountAmount = 1470.14F,
                DiscountPercentage = 9564.06F,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "222e9817-ee17-4cbe-a1e6-b7b95bc0ab3c",
                    Name = "Elizabeth Schinner",
                },
                Quantity = 2328.65F,
                SubTotal = 4581.39F,
                TaxAmount = 5034.27F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 5909.84F,
                    Id = "fd871f99-dd2e-4fd1-a1aa-6f1e674bdb04",
                    Name = "Samuel Hermiston",
                },
                TotalAmount = 3917.74F,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "82d68ea1-9f1d-4170-9133-9d08086a1840",
                            Name = "Toni Fritsch",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "voluptas",
                        Id = "071f93f5-f064-42da-87af-515cc413aa63",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectRef() {
                        Id = "e8d67864-dbb6-475f-95e6-0b375ed4f6fb",
                        Name = "Dr. Terence Gulgowski",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "317fe35b-60eb-41ea-8265-55ba3c28744e",
                        Name = "Dustin Ferry",
                    },
                },
                UnitAmount = 5553.61F,
            },
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "f3a8d8f5-c0b2-4f2f-b7b1-94a276b26916",
                    Name = "Rogelio Bins V",
                },
                Description = "maiores",
                DiscountAmount = 2748.23F,
                DiscountPercentage = 1484.78F,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "94e3698f-447f-4603-a8b4-45e80ca55efd",
                    Name = "Deborah Turcotte",
                },
                Quantity = 4461.35F,
                SubTotal = 8892.34F,
                TaxAmount = 1046.27F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 5124.52F,
                    Id = "58b6a89f-be3a-45aa-8e48-24d0ab407508",
                    Name = "Ms. Lamar Hessel",
                },
                TotalAmount = 1536.27F,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "65e904f3-b119-44b8-abf6-03a79f9dfe0a",
                            Name = "Ron Schulist",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "mollitia",
                        Id = "50ce187f-86bc-4173-9689-eee9526f8d98",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectRef() {
                        Id = "881ead4f-0e10-4125-a3f9-4e29e973e922",
                        Name = "Leo Kiehn II",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "e3e06080-7e2b-46e3-ab88-45f0597a60ff",
                        Name = "Alberta Harber",
                    },
                    new TrackingCategoryRef() {
                        Id = "31e94764-a3e8-465e-b956-f9251a5a9da6",
                        Name = "Ruth Zulauf",
                    },
                    new TrackingCategoryRef() {
                        Id = "7bfaad4f-9efc-41b4-912c-1032648dc2f6",
                        Name = "Cathy Breitenberg",
                    },
                },
                UnitAmount = 9364.69F,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 9358.33F,
                    TotalAmount = 5962.11F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "fe6c632c-a3ae-4d01-9799-6312fde04771",
                        Name = "Tamara Lang",
                    },
                    Currency = "USD",
                    CurrencyRate = 999.58F,
                    Id = "d0174763-60a1-45db-aa66-0659a1adeaab",
                    Note = "ad",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "enim",
                    TotalAmount = 1104.77F,
                },
            },
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 7758.03F,
                    TotalAmount = 4053.73F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "45b08b61-891b-4aa0-be1a-de008e6f8c5f",
                        Name = "Marion Aufderhar",
                    },
                    Currency = "EUR",
                    CurrencyRate = 8427.77F,
                    Id = "b5a34181-4301-4042-9813-d5208ece7e25",
                    Note = "nesciunt",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "eum",
                    TotalAmount = 4269.43F,
                },
            },
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 3494.4F,
                    TotalAmount = 704.1F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "c6c6e205-e16d-4eab-bfec-9578a6458427",
                        Name = "Lee Larkin IV",
                    },
                    Currency = "EUR",
                    CurrencyRate = 1173.8F,
                    Id = "62309fb0-9299-421a-afb9-f58c4d86e68e",
                    Note = "modi",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "vero",
                    TotalAmount = 329.01F,
                },
            },
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "USD",
                    CurrencyRate = 13.83F,
                    TotalAmount = 938.94F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "3f59da75-7a59-4ecf-af66-ef1caa3383c2",
                        Name = "Lamar Reichert",
                    },
                    Currency = "USD",
                    CurrencyRate = 1940.23F,
                    Id = "73c8d72f-64d1-4db1-b2c4-310661e96349",
                    Note = "earum",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "impedit",
                    TotalAmount = 9758.84F,
                },
            },
        },
        RemainingCredit = 0F,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78F,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "alias", new Dictionary<string, object>() {
                    { "itaque", "velit" },
                    { "laborum", "non" },
                } },
                { "dolor", new Dictionary<string, object>() {
                    { "sit", "doloremque" },
                    { "consequatur", "officia" },
                } },
                { "recusandae", new Dictionary<string, object>() {
                    { "quidem", "voluptas" },
                    { "facilis", "placeat" },
                } },
                { "perspiciatis", new Dictionary<string, object>() {
                    { "deleniti", "a" },
                    { "voluptate", "ullam" },
                    { "unde", "necessitatibus" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "ac55a974-1d31-4135-a965-bb8a72026114",
            SupplierName = "neque",
        },
        TotalAmount = 805.78F,
        TotalDiscount = 0F,
        TotalTaxAmount = 0F,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 9323.94F,
                Name = "Tracy Mills",
            },
            new WithholdingTaxitems() {
                Amount = 8028.94F,
                Name = "Marilyn Heaney",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 115661,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [CreateBillCreditNoteRequest](../../models/operations/CreateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.CreateBillCreditNoteResponse](../../models/operations/CreateBillCreditNoteResponse.md)**


## Get

The *Get bill credit note* endpoint returns a single bill credit note for a given `billCreditNoteId`.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support getting a specific bill credit note.

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

var res = await sdk.BillCreditNotes.GetAsync(new GetBillCreditNoteRequest() {
    BillCreditNoteId = "id",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetBillCreditNoteRequest](../../models/operations/GetBillCreditNoteRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetBillCreditNoteResponse](../../models/operations/GetBillCreditNoteResponse.md)**


## GetCreateUpdateModel

The *Get create/update bill credit note model* endpoint returns the expected data for the request payload when creating and updating a [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company and integration.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating and updating a bill credit note.


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

var res = await sdk.BillCreditNotes.GetCreateUpdateModelAsync(new GetCreateUpdateBillCreditNoteModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetCreateUpdateBillCreditNoteModelRequest](../../models/operations/GetCreateUpdateBillCreditNoteModelRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |


### Response

**[GetCreateUpdateBillCreditNoteModelResponse](../../models/operations/GetCreateUpdateBillCreditNoteModelResponse.md)**


## List

The *List bill credit notes* endpoint returns a list of [bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

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

var res = await sdk.BillCreditNotes.ListAsync(new ListBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "libero",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListBillCreditNotesRequest](../../models/operations/ListBillCreditNotesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ListBillCreditNotesResponse](../../models/operations/ListBillCreditNotesResponse.md)**


## Update

The *Update bill credit note* endpoint updates an existing [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill credit note model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-billCreditNotes-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating a bill credit note.


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

var res = await sdk.BillCreditNotes.UpdateAsync(new UpdateBillCreditNoteRequest() {
    BillCreditNote = new BillCreditNote() {
        AllocatedOnDate = "2022-10-23T00:00:00.000Z",
        BillCreditNoteNumber = "91fe2a83-e161-4c21-929d-c5c10c4b07e5",
        Currency = "USD",
        CurrencyRate = 5546.03F,
        DiscountPercentage = 0F,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "70e1084c-b067-42d1-ad87-9eeb9665b85e",
                    Name = "Mr. Jonathon Swaniawski",
                },
                Description = "fuga",
                DiscountAmount = 9195.08F,
                DiscountPercentage = 340.7F,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "be2d7822-59e3-4ea4-b519-7f92443da7ce",
                    Name = "Phyllis Quitzon",
                },
                Quantity = 3262.69F,
                SubTotal = 8095.94F,
                TaxAmount = 3165.42F,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 2040.72F,
                    Id = "7c6454ef-b0b3-4489-ac3c-a5acfbe2fd57",
                    Name = "Viola Hane",
                },
                TotalAmount = 5678.46F,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "9177deac-646e-4cb5-b340-9e3eb1e5a2b1",
                            Name = "Ms. Kelley Rogahn",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "veritatis",
                        Id = "16db9954-5fc9-45fa-8897-0e189dbb30fc",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectRef() {
                        Id = "3ea055b1-97cd-444e-af52-d82d3513bb6f",
                        Name = "Mattie Raynor",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "bcdb35ff-2e4b-4275-b7a8-cd9e7319c177",
                        Name = "Leon Collier",
                    },
                    new TrackingCategoryRef() {
                        Id = "77b114ee-b52f-4f78-9fc3-7814d4c98e0c",
                        Name = "Candice Rath",
                    },
                },
                UnitAmount = 9222.99F,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 6293.77F,
                    TotalAmount = 8339.82F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "636c6005-03d8-4bb3-9180-f739ae9e057e",
                        Name = "Johnnie Baumbach",
                    },
                    Currency = "GBP",
                    CurrencyRate = 5200.81F,
                    Id = "10331f39-81d4-4c70-8b60-7f3c93c73b9d",
                    Note = "officia",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "tenetur",
                    TotalAmount = 1339.49F,
                },
            },
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 8483.46F,
                    TotalAmount = 6707.62F,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "7e23f225-7411-4faf-8b75-44e472e80285",
                        Name = "Marguerite Hansen",
                    },
                    Currency = "GBP",
                    CurrencyRate = 2667.88F,
                    Id = "63a7d575-f140-40e7-a4ad-7334ec1b781b",
                    Note = "amet",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "fuga",
                    TotalAmount = 53.1F,
                },
            },
        },
        RemainingCredit = 0F,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78F,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "quos", new Dictionary<string, object>() {
                    { "repellendus", "veritatis" },
                    { "quae", "eaque" },
                    { "saepe", "delectus" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "ada200ef-0422-4eb2-964c-f9ab8366c723",
            SupplierName = "reiciendis",
        },
        TotalAmount = 805.78F,
        TotalDiscount = 0F,
        TotalTaxAmount = 0F,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 8611.23F,
                Name = "Mrs. Luther Torp",
            },
            new WithholdingTaxitems() {
                Amount = 9248.4F,
                Name = "Kyle Leffler",
            },
            new WithholdingTaxitems() {
                Amount = 7868.6F,
                Name = "Dr. Shari Roob Sr.",
            },
            new WithholdingTaxitems() {
                Amount = 3178.98F,
                Name = "Ian Auer",
            },
        },
    },
    BillCreditNoteId = "a",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 615058,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateBillCreditNoteRequest](../../models/operations/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.UpdateBillCreditNoteResponse](../../models/operations/UpdateBillCreditNoteResponse.md)**

