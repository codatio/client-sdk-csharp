# TransactionStatus
(*TransactionStatus*)

## Overview

Monitor the status of individual transactions in data syncs.

### Available Operations

* [Get](#get) - Get sync transaction
* [List](#list) - List sync transactions

## Get

Gets the status of a transaction for a sync

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetSyncTransactionRequest req = new GetSyncTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
};

var res = await sdk.TransactionStatus.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetSyncTransactionRequest](../../Models/Operations/GetSyncTransactionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetSyncTransactionResponse](../../Models/Operations/GetSyncTransactionResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                    | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## List

Gets the transactions and status for a sync

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListSyncTransactionsRequest req = new ListSyncTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
};

var res = await sdk.TransactionStatus.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListSyncTransactionsRequest](../../Models/Operations/ListSyncTransactionsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListSyncTransactionsResponse](../../Models/Operations/ListSyncTransactionsResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
