# BillCreditNotes

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
        Currency = "USD",
        CurrencyRate = 3927.85M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "d151a05d-fc2d-4df7-8c78-ca1ba928fc81",
                    Name = "Tanya Gleason",
                },
                Description = "cum",
                DiscountAmount = 4561.5M,
                DiscountPercentage = 2165.5M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "92059293-96fe-4a75-96eb-10faaa2352c5",
                    Name = "Corey Hane III",
                },
                Quantity = 6342.74M,
                SubTotal = 9883.74M,
                TaxAmount = 9589.5M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 1020.44M,
                    Id = "a3a2fa94-6773-4925-9aa5-2c3f5ad019da",
                    Name = "Johanna Wolf",
                },
                TotalAmount = 5096.24M,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "f097b007-4f15-4471-b5e6-e13b99d488e1",
                            Name = "Kirk Boehm",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "enim",
                        Id = "0ad2abd4-4269-4802-9502-a94bb4f63c96",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
                        Id = "9a3efa77-dfb1-44cd-a6ae-395efb9ba88f",
                        Name = "Sandy Huels",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "97074ba4-469b-46e2-9419-59890afa563e",
                        Name = "Vivian Boyle",
                    },
                },
                UnitAmount = 8919.24M,
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
                    Currency = "USD",
                    CurrencyRate = 7038.89M,
                    TotalAmount = 4479.26M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "11e5b7fd-2ed0-4289-a1cd-dc692601fb57",
                        Name = "Candice Beatty",
                    },
                    Currency = "EUR",
                    CurrencyRate = 166.27M,
                    Id = "d30c5fbb-2587-4053-a02c-73d5fe9b90c2",
                    Note = "blanditiis",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "eaque",
                    TotalAmount = 5772.29M,
                },
            },
        },
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "adipisci", new Dictionary<string, object>() {
                    { "asperiores", "earum" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "49a8d9cb-f486-4333-a3f9-b77f3a410067",
            SupplierName = "quaerat",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 8810.05M,
                Name = "Jan Hodkiewicz",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 542499,
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
    BillCreditNoteId = "sit",
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
    Query = "fugiat",
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
        Currency = "EUR",
        CurrencyRate = 6793.93M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "7a89ebf7-37ae-4420-bce5-e6a95d8a0d44",
                    Name = "Bernadette Torp",
                },
                Description = "a",
                DiscountAmount = 4561.3M,
                DiscountPercentage = 6874.88M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "73cf3be4-53f8-470b-b26b-5a73429cdb1a",
                    Name = "Randall Cole",
                },
                Quantity = 7044.74M,
                SubTotal = 3960.6M,
                TaxAmount = 4631.5M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 5654.21M,
                    Id = "d2322715-bf0c-4bb1-a31b-8b90f3443a11",
                    Name = "Miss Billie Ward",
                },
                TotalAmount = 7851.53M,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "f4b92187-9fce-4953-b73e-f7fbc7abd74d",
                            Name = "Earl Mosciski DVM",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "exercitationem",
                        Id = "d2cff7c7-0a45-4626-9436-813f16d9f5fc",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
                        Id = "c556146c-3e25-40fb-808c-42e141aac366",
                        Name = "Clifton Simonis",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "b1442907-4747-478a-bbd4-66d28c10ab3c",
                        Name = "Salvatore Parker",
                    },
                },
                UnitAmount = 3738.13M,
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
                    CurrencyRate = 2728.22M,
                    TotalAmount = 8920.5M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "523c7e0b-c717-48e4-b96f-2a70c688282a",
                        Name = "Randall Lindgren",
                    },
                    Currency = "USD",
                    CurrencyRate = 1470.14M,
                    Id = "f222e981-7ee1-47cb-a61e-6b7b95bc0ab3",
                    Note = "cumque",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "consequatur",
                    TotalAmount = 7963.92M,
                },
            },
        },
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "sapiente", new Dictionary<string, object>() {
                    { "consectetur", "esse" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "89fd871f-99dd-42ef-9121-aa6f1e674bdb",
            SupplierName = "accusantium",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 3069.86M,
                Name = "Samuel Hermiston",
            },
        },
    },
    BillCreditNoteId = "nisi",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 16328,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateBillCreditNoteRequest](../../models/operations/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.UpdateBillCreditNoteResponse](../../models/operations/UpdateBillCreditNoteResponse.md)**

