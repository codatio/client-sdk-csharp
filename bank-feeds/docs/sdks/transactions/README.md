# TransactionsSDK
(*Transactions*)

## Overview

Transactions represent debits and credits from a source account.

### Available Operations

* [Create](#create) - Create bank transactions
* [GetCreateOperation](#getcreateoperation) - Get create operation
* [ListCreateOperations](#listcreateoperations) - List create operations

## Create

﻿The *Create bank transactions* endpoint creates new [bank transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) for a given company's connection.

[Bank transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) are records of monetary amounts that have moved in and out of an SMB's bank account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create bank transaction model](https://docs.codat.io/bank-feeds-api#/operations/get-create-bankTransactions-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankTransactions) for integrations that support creating a bank account transactions.


### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Transactions.CreateAsync(new CreateBankTransactionsRequest() {
    CreateBankTransactions = new CreateBankTransactions() {
        AccountId = "7110701885",
        Transactions = new List<BankTransactions>() {
            new BankTransactions() {
                Amount = 999.99M,
                Balance = -999.99M,
                ClearedOnDate = "2022-10-23T00:00:00.000Z",
                Counterparty = "ACME INC",
                Description = "Debit for Payment Id sdp-1-57379a43-c4b8-49f5-bd7c-699189ee7a60",
                Id = "716422529",
                Reconciled = false,
                Reference = "reference for transaction",
                TransactionType = CodatBankFeeds.Models.Shared.BankTransactionsBankTransactionType.Check,
            },
        },
    },
    AccountId = "EILBDVJVNUAGVKRQ",
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 417458,
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [CreateBankTransactionsRequest](../../models/operations/CreateBankTransactionsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[Models.Operations.CreateBankTransactionsResponse](../../models/operations/CreateBankTransactionsResponse.md)**


## GetCreateOperation

Retrieve push operation.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Transactions.GetCreateOperationAsync(new GetCreateOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "1fb73c31-a851-46c2-ab8a-5ce6e25b57b8",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetCreateOperationRequest](../../models/operations/GetCreateOperationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetCreateOperationResponse](../../models/operations/GetCreateOperationResponse.md)**


## ListCreateOperations

List create operations.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Transactions.ListCreateOperationsAsync(new ListCreateOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "Hassium",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCreateOperationsRequest](../../models/operations/ListCreateOperationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListCreateOperationsResponse](../../models/operations/ListCreateOperationsResponse.md)**

