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
        Currency = "GBP",
        CurrencyRate = 3834.41M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "cc8796ed-151a-405d-bc2d-df7cc78ca1ba",
                    Name = "Wayne Lind",
                },
                Description = "totam",
                DiscountAmount = 1059.07M,
                DiscountPercentage = 4146.62M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "742cb739-2059-4293-96fe-a7596eb10faa",
                    Name = "Ernest Ebert",
                },
                Quantity = 7506.86M,
                SubTotal = 3154.28M,
                TaxAmount = 6078.31M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 3637.11M,
                    Id = "5907aff1-a3a2-4fa9-8677-39251aa52c3f",
                    Name = "Mr. Alberta Schuster",
                },
                TotalAmount = 8379.45M,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "a1ffe78f-097b-4007-8f15-471b5e6e13b9",
                            Name = "Ervin Gleason",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "voluptates",
                        Id = "1e91e450-ad2a-4bd4-8269-802d502a94bb",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
                        Id = "63c969e9-a3ef-4a77-9fb1-4cd66ae395ef",
                        Name = "Rene Reinger",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "8f3a6699-7074-4ba4-869b-6e2141959890",
                        Name = "Abel O'Hara",
                    },
                },
                UnitAmount = 2212.62M,
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
                    CurrencyRate = 972.6M,
                    TotalAmount = 4358.65M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "fe4c8b71-1e5b-47fd-aed0-28921cddc692",
                        Name = "Donna Bernhard",
                    },
                    Currency = "USD",
                    CurrencyRate = 4535.43M,
                    Id = "6b0d5f0d-30c5-4fbb-a587-053202c73d5f",
                    Note = "recusandae",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "facilis",
                    TotalAmount = 5966.56M,
                },
            },
        },
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "porro", new Dictionary<string, object>() {
                    { "consequuntur", "blanditiis" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "909b3fe4-9a8d-49cb-b486-33323f9b77f3",
            SupplierName = "dolorum",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 2543.56M,
                Name = "Melissa Bednar",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 311796,
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
    BillCreditNoteId = "accusamus",
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
    Query = "quidem",
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
        CurrencyRate = 6176.58M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "80d1ba77-a89e-4bf7-b7ae-4203ce5e6a95",
                    Name = "Dr. Jimmie Murphy",
                },
                Description = "tempora",
                DiscountAmount = 4254.51M,
                DiscountPercentage = 7980.47M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "e2af7a73-cf3b-4e45-bf87-0b326b5a7342",
                    Name = "Simon Stracke MD",
                },
                Quantity = 5173.79M,
                SubTotal = 2768.94M,
                TaxAmount = 1320.68M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 1749.09M,
                    Id = "bb679d23-2271-45bf-8cbb-1e31b8b90f34",
                    Name = "Mr. Josephine Pagac V",
                },
                TotalAmount = 9295.3M,
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "0adcf4b9-2187-49fc-a953-f73ef7fbc7ab",
                            Name = "Allan Greenholt",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "sequi",
                        Id = "9c0f5d2c-ff7c-470a-8562-6d436813f16d",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Project,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
                        Id = "5fce6c55-6146-4c3e-a50f-b008c42e141a",
                        Name = "Clark Franecki",
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "c8dd6b14-4290-4747-8778-a7bd466d28c1",
                        Name = "Amelia Predovic",
                    },
                },
                UnitAmount = 8472.76M,
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
                    CurrencyRate = 1783.67M,
                    TotalAmount = 3738.13M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "1904e523-c7e0-4bc7-978e-4796f2a70c68",
                        Name = "Eugene Leuschke",
                    },
                    Currency = "USD",
                    CurrencyRate = 2775.96M,
                    Id = "82562f22-2e98-417e-a17c-be61e6b7b95b",
                    Note = "eligendi",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "culpa",
                    TotalAmount = 7313.98M,
                },
            },
        },
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "cumque", new Dictionary<string, object>() {
                    { "consequuntur", "consequatur" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "c4f3789f-d871-4f99-9d2e-fd121aa6f1e6",
            SupplierName = "in",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 2586.84M,
                Name = "Mrs. Gilberto Roberts",
            },
        },
    },
    BillCreditNoteId = "dicta",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 355369,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateBillCreditNoteRequest](../../models/operations/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.UpdateBillCreditNoteResponse](../../models/operations/UpdateBillCreditNoteResponse.md)**

