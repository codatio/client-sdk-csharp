# BillCreditNotesSDK
(*BillCreditNotes*)

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
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {},
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "<ID>",
                },
                Quantity = 8592.13M,
                TaxRateRef = new TaxRateRef() {},
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
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
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
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
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "abnormally", new Dictionary<string, object>() {
                    { "deposit", "evolve" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 7150.4M,
                Name = "SUV quantify Polestar",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
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
    BillCreditNoteId = "Northeast Hatchback Kia",
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
        Currency = "GBP",
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {},
                ItemRef = new BillCreditNoteLineItemItemReference() {
                    Id = "<ID>",
                },
                Quantity = 156.52M,
                TaxRateRef = new TaxRateRef() {},
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
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
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
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
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "Arizona", new Dictionary<string, object>() {
                    { "Cotton", "extend" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 2494.4M,
                Name = "Carolina syndicate",
            },
        },
    },
    BillCreditNoteId = "implement JBOD",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateBillCreditNoteRequest](../../models/operations/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.UpdateBillCreditNoteResponse](../../models/operations/UpdateBillCreditNoteResponse.md)**

