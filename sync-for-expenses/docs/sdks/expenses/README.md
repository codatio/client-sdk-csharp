# Expenses
(*Expenses*)

## Overview

Create and update transactions that represent your customers' spend.

### Available Operations

* [Create](#create) - Create expense transaction
* [Update](#update) - Update expense transactions

## Create

The *Create expense* endpoint creates an [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) in the accounting platform for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
    RequestBody = new List<ExpenseTransaction>() {
        new ExpenseTransaction() {
            BankAccountRef = new ExpenseTransactionBankAccountReference() {
                Id = "787dfb37-5707-4dc0-8a86-8d74e4cc78ea",
            },
            ContactRef = new ContactRef() {
                Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                Type = Type.Supplier,
            },
            Currency = "GBP",
            CurrencyRate = 1.18M,
            Id = "a44135b0-6882-489a-83fe-a0c57a4afb19",
            IssueDate = "2021-05-21T00:00:00+00:00",
            Lines = new List<ExpenseTransactionLine>() {
                new ExpenseTransactionLine() {
                    AccountRef = new RecordRef() {
                        Id = "a505cb47-0f7d-4e8b-90aa-9f9c2308b7bc",
                    },
                    InvoiceTo = new InvoiceTo() {
                        DataType = InvoiceToDataType.Customers,
                        Id = "80000002-1674552702",
                    },
                    NetAmount = 110.42M,
                    TaxAmount = 14.43M,
                    TaxRateRef = new RecordRef() {
                        Id = "7e2ccb60-de1a-4c2b-9bd9-2f98a1c6be3f",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            DataType = TrackingRefDataType.TrackingCategories,
                            Id = "31a7e93c-4bb2-474c-b26d-10b2b75f7a25",
                        },
                        new TrackingRef() {
                            DataType = TrackingRefDataType.TrackingCategories,
                            Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                        },
                    },
                },
            },
            MerchantName = "Amazon UK",
            Notes = "amazon purchase",
            PostAsDraft = false,
            Type = Codat.Sync.Expenses.Models.Shared.ExpenseTransactionType.Payment,
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Expenses.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [CreateExpenseTransactionRequest](../../Models/Operations/CreateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[CreateExpenseTransactionResponse](../../Models/Operations/CreateExpenseTransactionResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## Update

The *Update expense* endpoint updates an existing [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) in the accounting platform for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 


**Integration-specific behaviour**

At the moment you can update expenses only for Xero and QuickBooks Online ([Payment](https://docs.codat.io/expenses/sync-process/expense-transactions#transaction-types) transaction type only).

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateExpenseTransactionRequest req = new UpdateExpenseTransactionRequest() {
    UpdateExpenseRequest = new UpdateExpenseRequest() {
        BankAccountRef = new UpdateExpenseRequestBankAccountReference() {
            Id = "787dfb37-5707-4dc0-8a86-8d74e4cc78ea",
        },
        ContactRef = new ContactRef() {
            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
            Type = Type.Supplier,
        },
        Currency = "GBP",
        IssueDate = "2022-06-28T00:00:00.000Z",
        Lines = new List<ExpenseTransactionLine>() {
            new ExpenseTransactionLine() {
                AccountRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                InvoiceTo = new InvoiceTo() {
                    DataType = InvoiceToDataType.Customers,
                    Id = "80000002-1674552702",
                },
                NetAmount = 110.42M,
                TaxAmount = 14.43M,
                TaxRateRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        DataType = TrackingRefDataType.TrackingCategories,
                        Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                    },
                },
            },
        },
        MerchantName = "Amazon UK",
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        Type = "<value>",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
};

var res = await sdk.Expenses.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateExpenseTransactionRequest](../../Models/Operations/UpdateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[UpdateExpenseTransactionResponse](../../Models/Operations/UpdateExpenseTransactionResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,422,429,500,503            | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
