# BillCreditNotes
(*BillCreditNotes*)

## Overview

Get, create, and update Bill credit notes.

### Available Operations

* [List](#list) - List bill credit notes
* [Get](#get) - Get bill credit note
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update bill credit note model
* [Create](#create) - Create bill credit note
* [Update](#update) - Update bill credit note

## List

The *List bill credit notes* endpoint returns a list of [bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillCreditNotesRequest req = new ListBillCreditNotesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.BillCreditNotes.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListBillCreditNotesRequest](../../Models/Requests/ListBillCreditNotesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListBillCreditNotesResponse](../../Models/Requests/ListBillCreditNotesResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503               | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Get

The *Get bill credit note* endpoint returns a single bill credit note for a given `billCreditNoteId`.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support getting a specific bill credit note.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetBillCreditNoteRequest req = new GetBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillCreditNoteId = "<value>",
};

var res = await sdk.BillCreditNotes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetBillCreditNoteRequest](../../Models/Requests/GetBillCreditNoteRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetBillCreditNoteResponse](../../Models/Requests/GetBillCreditNoteResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## GetCreateUpdateModel

The *Get create/update bill credit note model* endpoint returns the expected data for the request payload when creating and updating a [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company and integration.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating and updating a bill credit note.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateBillCreditNoteModelRequest req = new GetCreateUpdateBillCreditNoteModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BillCreditNotes.GetCreateUpdateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [GetCreateUpdateBillCreditNoteModelRequest](../../Models/Requests/GetCreateUpdateBillCreditNoteModelRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[GetCreateUpdateBillCreditNoteModelResponse](../../Models/Requests/GetCreateUpdateBillCreditNoteModelResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Create

The *Create bill credit note* endpoint creates a new [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill credit note model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-billCreditNotes-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating a bill credit note.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillCreditNoteRequest req = new CreateBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillCreditNote = new BillCreditNote() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "6a0e9dfb-87b0-47d3-aaaf-9753ae9e757d",
        BillCreditNoteNumber = "14763237",
        SupplierRef = new SupplierRef() {
            Id = "67C6A7A1-5E84-4AC4-B950-24A114E379D0",
            SupplierName = "Chin's Gas and Oil",
        },
        TotalAmount = 693M,
        TotalDiscount = 0M,
        SubTotal = 805.78M,
        TotalTaxAmount = 0M,
        DiscountPercentage = 0M,
        RemainingCredit = 693M,
        Status = Codat.Sync.Payables.V1.Models.Components.BillCreditNoteStatus.Submitted,
        IssueDate = "2019-02-18T16:03:07.268Z",
        AllocatedOnDate = "2022-10-23T00:00:00Z",
        Currency = "USD",
        LineItems = new List<BillCreditNoteLineItem>() {

        },
        PaymentAllocations = new List<PaymentAllocationItems>() {
            new PaymentAllocationItems() {
                Payment = new PaymentAllocationPayment() {
                    Currency = "EUR",
                    PaidOnDate = "2022-10-23T00:00:00Z",
                },
                Allocation = new Allocation() {
                    Currency = "USD",
                    AllocatedOnDate = "2022-10-23T00:00:00Z",
                },
            },
        },
        CreatedFromRefs = new List<RecordReference>() {
            new RecordReference() {
                DataType = "invoice",
            },
        },
        Note = "Track separately",
    },
};

var res = await sdk.BillCreditNotes.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [CreateBillCreditNoteRequest](../../Models/Requests/CreateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[Models.Requests.CreateBillCreditNoteResponse](../../Models/Requests/CreateBillCreditNoteResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Update

The *Update bill credit note* endpoint updates an existing [bill credit note](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) for a given company's connection.

[Bill credit notes](https://docs.codat.io/sync-for-payables-api#/schemas/BillCreditNote) are issued by a supplier for the purpose of recording credit.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bill credit note model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-billCreditNotes-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billCreditNotes) for integrations that support creating a bill credit note.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateBillCreditNoteRequest req = new UpdateBillCreditNoteRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillCreditNoteId = "<value>",
    BillCreditNote = new BillCreditNote() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "6a0e9dfb-87b0-47d3-aaaf-9753ae9e757d",
        BillCreditNoteNumber = "14763237",
        SupplierRef = new SupplierRef() {
            Id = "67C6A7A1-5E84-4AC4-B950-24A114E379D0",
            SupplierName = "Chin's Gas and Oil",
        },
        TotalAmount = 693M,
        TotalDiscount = 0M,
        SubTotal = 805.78M,
        TotalTaxAmount = 0M,
        DiscountPercentage = 0M,
        RemainingCredit = 693M,
        Status = Codat.Sync.Payables.V1.Models.Components.BillCreditNoteStatus.Submitted,
        IssueDate = "2019-02-18T16:03:07.268Z",
        AllocatedOnDate = "2022-10-23T00:00:00Z",
        Currency = "USD",
        LineItems = new List<BillCreditNoteLineItem>() {

        },
        PaymentAllocations = new List<PaymentAllocationItems>() {
            new PaymentAllocationItems() {
                Payment = new PaymentAllocationPayment() {
                    Currency = "GBP",
                    PaidOnDate = "2022-10-23T00:00:00Z",
                },
                Allocation = new Allocation() {
                    Currency = "USD",
                    AllocatedOnDate = "2022-10-23T00:00:00Z",
                },
            },
        },
        CreatedFromRefs = new List<RecordReference>() {
            new RecordReference() {
                DataType = "invoice",
            },
        },
        Note = "Track separately",
    },
};

var res = await sdk.BillCreditNotes.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateBillCreditNoteRequest](../../Models/Requests/UpdateBillCreditNoteRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[Models.Requests.UpdateBillCreditNoteResponse](../../Models/Requests/UpdateBillCreditNoteResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
