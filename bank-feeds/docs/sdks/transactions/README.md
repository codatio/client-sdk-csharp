# Transactions
(*Transactions*)

## Overview

Create new bank account transactions for a company's connections, and see previous operations.

### Available Operations

* [Create](#create) - Create bank transactions
* [GetCreateModel](#getcreatemodel) - Get create bank transactions model
* [GetCreateOperation](#getcreateoperation) - Get create operation
* [ListCreateOperations](#listcreateoperations) - List create operations

## Create

﻿The *Create bank transactions* endpoint creates new [bank transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) for a given company's connection.

[Bank transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) are records of monetary amounts that have moved in and out of an SMB's bank account.

**Integration-specific behaviour**

The required properties may vary based on the integration. For detailed requirements specific to each accounting software, refer to the API reference examples.
Alternatively, you can view the [Get create bank transaction model](https://docs.codat.io/bank-feeds-api#/operations/get-create-bank-transactions-model) for more information.

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
        AccountId = "EILBDVJVNUAGVKRQ",
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

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503     | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## GetCreateModel

The *Get create bank account transactions model* endpoint returns the expected data for the request payload when creating [bank account transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) for a given company and integration.

[Bank account transactions](https://docs.codat.io/bank-feeds-api#/schemas/BankTransactions) are records of money that has moved in and out of an SMB's bank account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetCreateBankTransactionsModelRequest req = new GetCreateBankTransactionsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Transactions.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetCreateBankTransactionsModelRequest](../../Models/Operations/GetCreateBankTransactionsModelRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[GetCreateBankTransactionsModelResponse](../../Models/Operations/GetCreateBankTransactionsModelResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## GetCreateOperation

The **Get create operation** endpoint returns a specific [write operation](/using-the-api/push) identified by the `pushOperationKey` that was performed on the company.

Write operations are actions that send requests to Codat, enabling the creation, updating, deletion of records, or uploading attachments in the connected accounting software.

For bank feeds, your push operations will only relate to the `bankTransactions` data type.

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
    PushOperationKey = "1b33a562-bac6-42b7-8818-d55dba8df363",
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

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## ListCreateOperations

The **List create operations** endpoint returns a list of [write operations](/using-the-api/push) performed on the company.

Write operations are actions that send requests to Codat, enabling the creation, updating, deletion of records, or uploading attachments in the connected accounting software. 

For bank feeds, use this endpoint to view write operations related to the `bankTransactions` data type.

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

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503     | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |