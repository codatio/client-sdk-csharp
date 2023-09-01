# transactionStatus

## Overview

Retrieve the status of transactions within a sync.

### Available Operations

* [Get](#get) - Get Sync Transaction
* [List](#list) - List sync transactions

## Get

Gets the status of a transaction for a sync

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TransactionStatus.GetAsync(new GetSyncTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetSyncTransactionRequest](../../models/operations/GetSyncTransactionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetSyncTransactionResponse](../../models/operations/GetSyncTransactionResponse.md)**


## List

Gets the transactions and status for a sync

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.TransactionStatus.ListAsync(new ListSyncTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListSyncTransactionsRequest](../../models/operations/ListSyncTransactionsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListSyncTransactionsResponse](../../models/operations/ListSyncTransactionsResponse.md)**

