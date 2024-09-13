# Transactions
(*Transactions*)

## Overview

Create new bank account transactions for a company's connections, and see previous operations.

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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateBankTransactionsRequest req = new CreateBankTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
    CreateBankTransactions = new CreateBankTransactions() {
        AccountId = "Checking 0202",
        Transactions = new List<BankTransactions>() {
            new BankTransactions() {
                Id = "716422529",
                Date = "2022-10-23T00:00:00Z",
                Description = "Debit for Payment Id sdp-1-57379a43-c4b8-49f5-bd7c-699189ee7a60",
                Counterparty = "ACME INC",
                Reference = "reference for transaction",
                Reconciled = false,
                Amount = 999.99M,
                Balance = -999.99M,
            },
        },
    },
};

var res = await sdk.Transactions.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [CreateBankTransactionsRequest](../../Models/Operations/CreateBankTransactionsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[Models.Operations.CreateBankTransactionsResponse](../../Models/Operations/CreateBankTransactionsResponse.md)**

### Errors

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503            | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4xx-5xx                                    | */*                                        |


## GetCreateOperation

Retrieve push operation.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetCreateOperationRequest req = new GetCreateOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "1fb73c31-a851-46c2-ab8a-5ce6e25b57b8",
};

var res = await sdk.Transactions.GetCreateOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetCreateOperationRequest](../../Models/Operations/GetCreateOperationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetCreateOperationResponse](../../Models/Operations/GetCreateOperationResponse.md)**

### Errors

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4xx-5xx                                    | */*                                        |


## ListCreateOperations

List create operations.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListCreateOperationsRequest req = new ListCreateOperationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Transactions.ListCreateOperationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCreateOperationsRequest](../../Models/Operations/ListCreateOperationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListCreateOperationsResponse](../../Models/Operations/ListCreateOperationsResponse.md)**

### Errors

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503            | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4xx-5xx                                    | */*                                        |
