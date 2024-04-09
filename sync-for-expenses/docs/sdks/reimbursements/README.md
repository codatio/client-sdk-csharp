# Reimbursements
(*Reimbursements*)

## Overview

Create reimbursable expense transactions.

### Available Operations

* [Create](#create) - Create reimbursable expense transaction
* [Update](#update) - Update reimbursable expense transaction

## Create

Use the *Create reimbursable expense* endpoint to create a [reimbursement request](https://docs.codat.io/sync-for-expenses-api#/schemas/Reimburseable-Expense-Transactions) in the accounting platform for a given company's connection. 

Employee reimbursement requests are reflected in the accounting system in the form of Bills against an employee, who is a supplier.

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateReimbursableExpenseTransactionRequest req = new CreateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Reimbursements.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [CreateReimbursableExpenseTransactionRequest](../../Models/Operations/CreateReimbursableExpenseTransactionRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |


### Response

**[CreateReimbursableExpenseTransactionResponse](../../Models/Operations/CreateReimbursableExpenseTransactionResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## Update

The *Update reimbursable expense* endpoint updates an existing [reimbursable expense transaction](https://docs.codat.io/sync-for-expenses-api#/operations/create-reimbursable-expense-transaction) in the accounting platform for a given company's connection. 

Employee reimbursement requests are reflected in the accounting system in the form of Bills against an employee, who is a supplier.

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateReimbursableExpenseTransactionRequest req = new UpdateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
};

var res = await sdk.Reimbursements.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [UpdateReimbursableExpenseTransactionRequest](../../Models/Operations/UpdateReimbursableExpenseTransactionRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |


### Response

**[UpdateReimbursableExpenseTransactionResponse](../../Models/Operations/UpdateReimbursableExpenseTransactionResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
