# Adjustments

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

### Example Usage: Create adjustment

<!-- UsageSnippet language="csharp" operationID="create-adjustment-transaction" method="post" path="/companies/{companyId}/sync/expenses/adjustment-transactions" example="Create adjustment" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAdjustmentTransactionRequest req = new CreateAdjustmentTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<AdjustmentTransactionRequest>() {
        new AdjustmentTransactionRequest() {
            Id = "3357b3df-5f2e-465d-b9ba-226519dbb8f1",
            Date = "2024-05-21T00:00:00+00:00",
            Currency = "USD",
            CurrencyRate = 1M,
            Reference = "test reference",
            Lines = new List<AdjustmentTransactionLine>() {
                new AdjustmentTransactionLine() {
                    Amount = 50M,
                    AccountRef = new RecordRef() {
                        Id = "80000018-1671793811",
                    },
                    Description = "debit line",
                    TrackingRefs = new List<TrackingRefAdjustmentTransaction>() {
                        new TrackingRefAdjustmentTransaction() {
                            Id = "80000003-1674553958",
                        },
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "80000002-1674552702",
                        Type = InvoiceToType.Customer,
                    },
                },
                new AdjustmentTransactionLine() {
                    Amount = -50M,
                    AccountRef = new RecordRef() {
                        Id = "80000028-1671794219",
                    },
                    Description = "credit line",
                    TrackingRefs = new List<TrackingRefAdjustmentTransaction>() {
                        new TrackingRefAdjustmentTransaction() {
                            Id = "80000003-1674553958",
                        },
                    },
                },
            },
        },
    },
};

var res = await sdk.Adjustments.CreateAsync(req);

// handle response
```
### Example Usage: Example 1

<!-- UsageSnippet language="csharp" operationID="create-adjustment-transaction" method="post" path="/companies/{companyId}/sync/expenses/adjustment-transactions" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAdjustmentTransactionRequest req = new CreateAdjustmentTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<AdjustmentTransactionRequest>() {
        new AdjustmentTransactionRequest() {
            Id = "6a13b8cf-d482-4389-9f93-08d52faa3dc0",
            Date = "2022-10-23T00:00:00Z",
            Currency = "Lilangeni",
            Lines = new List<AdjustmentTransactionLine>() {},
        },
    },
};

var res = await sdk.Adjustments.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-adjustment-transaction" method="post" path="/companies/{companyId}/sync/expenses/adjustment-transactions" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAdjustmentTransactionRequest req = new CreateAdjustmentTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<AdjustmentTransactionRequest>() {
        new AdjustmentTransactionRequest() {
            Id = "6a13b8cf-d482-4389-9f93-08d52faa3dc0",
            Date = "2022-10-23T00:00:00Z",
            Currency = "Lilangeni",
            Lines = new List<AdjustmentTransactionLine>() {},
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |