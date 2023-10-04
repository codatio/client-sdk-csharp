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
        CurrencyRate = 6384.24M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "<ID>",
                    Name = "innovative blue",
                },
                Description = "Vision-oriented responsive function",
                DiscountAmount = 9510.62M,
                DiscountPercentage = 8915.1M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
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
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                            Name = "Durham after",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "Fay - Durgan",
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Customer,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
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
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 365.21M,
                    TotalAmount = 8424.64M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "<ID>",
                        Name = "though East",
                    },
                    Currency = "GBP",
                    CurrencyRate = 155.52M,
                    Id = "<ID>",
                    Note = "array Edinburg Investor",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "likewise payment 1080p",
                    TotalAmount = 2597.72M,
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
                    { "asperiores", "Indiana" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
            SupplierName = "Toyota Neptunium round",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 1406.49M,
                Name = "meanwhile",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 863813,
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
    Query = "Northeast Metal Canada",
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
        CurrencyRate = 5971.29M,
        DiscountPercentage = 0M,
        Id = "1509398f-98e2-436d-8a5d-c042e0c74ffc",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<BillCreditNoteLineItem>() {
            new BillCreditNoteLineItem() {
                AccountRef = new AccountRef() {
                    Id = "<ID>",
                    Name = "male Metal",
                },
                Description = "Visionary bi-directional analyzer",
                DiscountAmount = 2782.81M,
                DiscountPercentage = 8965.01M,
                ItemRef = new BillCreditNoteLineItemItemReference() {
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
                Tracking = new BillCreditNoteLineItemTracking() {
                    CategoryRefs = new List<TrackingCategoryRef>() {
                        new TrackingCategoryRef() {
                            Id = "<ID>",
                            Name = "guestbook driver users",
                        },
                    },
                    CustomerRef = new BillCreditNoteLineItemTrackingCustomerRef() {
                        CompanyName = "Schroeder - Nienow",
                        Id = "<ID>",
                    },
                    IsBilledTo = CodatSyncPayables.Models.Shared.BilledToType.NotApplicable,
                    IsRebilledTo = CodatSyncPayables.Models.Shared.BilledToType.Unknown,
                    ProjectRef = new BillCreditNoteLineItemTrackingProjectReference() {
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
        Note = "Bill Credit Note with 1 line items, totaling 805.78",
        PaymentAllocations = new List<Items>() {
            new Items() {
                Allocation = new ItemsAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 3297.12M,
                    TotalAmount = 4939.56M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "<ID>",
                        Name = "modulo Kia",
                    },
                    Currency = "USD",
                    CurrencyRate = 8000.94M,
                    Id = "<ID>",
                    Note = "Avon",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "Reactive Global Northeast",
                    TotalAmount = 6090.5M,
                },
            },
        },
        RemainingCredit = 0M,
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.BillCreditNoteStatus.Paid,
        SubTotal = 805.78M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "alias", new Dictionary<string, object>() {
                    { "veritatis", "ADP" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "<ID>",
            SupplierName = "quisquam",
        },
        TotalAmount = 805.78M,
        TotalDiscount = 0M,
        TotalTaxAmount = 0M,
        WithholdingTax = new List<WithholdingTaxitems>() {
            new WithholdingTaxitems() {
                Amount = 8523.4M,
                Name = "pascal Plastic",
            },
        },
    },
    BillCreditNoteId = "magenta",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 639383,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateBillCreditNoteRequest](../../models/operations/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[Models.Operations.UpdateBillCreditNoteResponse](../../models/operations/UpdateBillCreditNoteResponse.md)**

