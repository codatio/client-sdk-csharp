# Adjustments
(*Adjustments*)

## Overview

Create transactions that represent your adjustments to your customers' spend.

### Available Operations

* [Create](#create) - Create adjustment transaction

## Create

Use the *Create adjustment expense* endpoint to create an [adjustment](https://docs.codat.io/sync-for-expenses-api#/schemas/AdjustmentTransactionRequest) in the accounting software for a given company's connection. 

Adjustments represent write-offs and transaction alterations, such as foreign exchange adjustments, in the form of a journal entry. 

### Supported Integrations

| Integration           | Supported |
|-----------------------|-----------|
| QuickBooks Desktop    | Yes       |

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;
using Codat.Sync.Expenses.Models.Components;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAdjustmentTransactionRequest req = new CreateAdjustmentTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<AdjustmentTransactionRequest>() {
        new AdjustmentTransactionRequest() {
            Id = "7a621cf0-21cd-49cf-8540-3315211a509a",
            Date = "2022-10-23T00:00:00Z",
            Currency = "Netherlands Antillian Guilder",
            Lines = new List<AdjustmentTransactionLine>() {
                new AdjustmentTransactionLine() {
                    Amount = 50M,
                    AccountRef = new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                    Description = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
                    TrackingRefs = new List<TrackingRefAdjustmentTransaction>() {
                        new TrackingRefAdjustmentTransaction() {
                            Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                            DataType = Codat.Sync.Expenses.Models.Components.TrackingRefAdjustmentTransactionDataType.TrackingCategories,
                        },
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "80000002-1674552702",
                        Type = Codat.Sync.Expenses.Models.Components.InvoiceToType.Customer,
                    },
                },
            },
        },
    },
};

var res = await sdk.Adjustments.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [CreateAdjustmentTransactionRequest](../../Models/Requests/CreateAdjustmentTransactionRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[CreateAdjustmentTransactionResponse](../../Models/Requests/CreateAdjustmentTransactionResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
