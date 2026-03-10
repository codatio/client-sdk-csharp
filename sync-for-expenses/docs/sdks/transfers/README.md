# Transfers

## Overview

Create and update transactions that represent the movement of your customers' money.

### Available Operations

* [Create](#create) - Create transfer transaction

## Create

Use the *Create transfer* endpoint to create or update a [transfer transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/TransferTransactionRequest) in the accounting software for a given company's connection. 

Transfers record the movement of money between two bank accounts, or between a bank account and a nominal account. Use them to represent actions such as topping up a debit card account or a balance transfer to another credit card.

The `from.amount` and `to.amount` fields are in the native currency of the account.

### Supported Integrations
| Integration           | Create transfer  | Update transfer  |
|-----------------------|------------------|------------------|
| Dynamics				| No			   | No				  |
| FreeAgent             | Yes              | Yes              |
| NetSuite              | No               | No               |
| QuickBooks Desktop    | Yes              | No               |
| QuickBooks Online     | Yes              | Yes              |
| Sage Intacct          | No               | No               |
| Xero                  | Yes              | No               |
| Zoho Books            | No               | No               |

### Example Usage: Create transfer

<!-- UsageSnippet language="csharp" operationID="create-transfer-transaction" method="put" path="/companies/{companyId}/sync/expenses/transfer-transactions/{transactionId}" example="Create transfer" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateTransferTransactionRequest req = new CreateTransferTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    TransferTransactionRequest = new TransferTransactionRequest() {
        Description = "Sample transfer description",
        Date = "2021-05-21T00:00:00+00:00",
        From = new From() {
            AccountRef = new AccountReference() {
                Id = "787dfb37-5707-4dc0-8a86-8d74e4cc78ea",
            },
            Amount = 100M,
        },
        To = new To() {
            AccountRef = new TransferTransactionRequestAccountReference() {
                Id = "777dfb37-5506-3dc0-6g86-8d34z4cc78ea",
            },
            Amount = 100M,
        },
    },
};

var res = await sdk.Transfers.CreateAsync(req);

// handle response
```
### Example Usage: Example 1

<!-- UsageSnippet language="csharp" operationID="create-transfer-transaction" method="put" path="/companies/{companyId}/sync/expenses/transfer-transactions/{transactionId}" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateTransferTransactionRequest req = new CreateTransferTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    TransferTransactionRequest = new TransferTransactionRequest() {
        Description = "Transfer from bank account Y to bank account Z",
        Date = "2022-10-23T00:00:00Z",
        From = new From() {
            AccountRef = new AccountReference() {
                Id = "<id>",
            },
            Amount = 7329.18M,
        },
        To = new To() {
            AccountRef = new TransferTransactionRequestAccountReference() {
                Id = "<id>",
            },
            Amount = 522.15M,
        },
    },
};

var res = await sdk.Transfers.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-transfer-transaction" method="put" path="/companies/{companyId}/sync/expenses/transfer-transactions/{transactionId}" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateTransferTransactionRequest req = new CreateTransferTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    TransferTransactionRequest = new TransferTransactionRequest() {
        Description = "Transfer from bank account Y to bank account Z",
        Date = "2022-10-23T00:00:00Z",
        From = new From() {
            AccountRef = new AccountReference() {
                Id = "<id>",
            },
            Amount = 7329.18M,
        },
        To = new To() {
            AccountRef = new TransferTransactionRequestAccountReference() {
                Id = "<id>",
            },
            Amount = 522.15M,
        },
    },
};

var res = await sdk.Transfers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [CreateTransferTransactionRequest](../../Models/Requests/CreateTransferTransactionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[CreateTransferTransactionResponse](../../Models/Requests/CreateTransferTransactionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |