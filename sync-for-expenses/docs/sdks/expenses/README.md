# Expenses

## Overview

Create and update transactions that represent your customers' spend.

### Available Operations

* [Create](#create) - Create expense transaction
* [Update](#update) - Update expense transactions

## Create

The *Create expense* endpoint creates an [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) in the accounting software for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 

### Supported Integrations

| Integration                   | Supported |
|-------------------------------|-----------|
| Dynamics 365 Business Central | Yes       |
| FreeAgent                     | Yes       |
| QuickBooks Desktop            | Yes       |
| QuickBooks Online             | Yes       |
| Oracle NetSuite               | Yes       |
| Sage Intacct                  | Yes       |
| Xero                          | Yes       |
| Zoho Books                    | Yes       |


### Example Usage: Example 1

<!-- UsageSnippet language="csharp" operationID="create-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/expense-transactions" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ExpenseTransaction>() {
        new ExpenseTransaction() {
            Id = "a44135b0-6882-489a-83fe-a0c57a4afb19",
            Type = Codat.Sync.Expenses.Models.Components.Type.Payment,
            IssueDate = "2024-05-21T00:00:00+00:00",
            Currency = "GBP",
            CurrencyRate = 1M,
            ContactRef = new ExpenseContactRef() {
                Id = "430",
            },
            BankAccountRef = new BankAccountReference() {
                Id = "97",
            },
            MerchantName = "Amazon UK",
            Lines = new List<ExpenseTransactionLine>() {
                new ExpenseTransactionLine() {
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "23_Bills",
                    },
                    AccountRef = new RecordRef() {
                        Id = "35",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "DEPARTMENT_3",
                        },
                        new TrackingRef() {},
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "504",
                        Type = InvoiceToType.Customer,
                    },
                },
            },
            Notes = "amazon purchase",
        },
    },
};

var res = await sdk.Expenses.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/expense-transactions" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ExpenseTransaction>() {
        new ExpenseTransaction() {
            Id = "a44135b0-6882-489a-83fe-a0c57a4afb19",
            Type = Codat.Sync.Expenses.Models.Components.Type.Payment,
            IssueDate = "2024-05-21T00:00:00+00:00",
            Currency = "GBP",
            CurrencyRate = 1M,
            ContactRef = new ExpenseContactRef() {
                Id = "430",
            },
            BankAccountRef = new BankAccountReference() {
                Id = "97",
            },
            MerchantName = "Amazon UK",
            Lines = new List<ExpenseTransactionLine>() {
                new ExpenseTransactionLine() {
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "23_Bills",
                    },
                    AccountRef = new RecordRef() {
                        Id = "35",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "DEPARTMENT_3",
                        },
                        new TrackingRef() {},
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "504",
                        Type = InvoiceToType.Customer,
                    },
                },
            },
            Notes = "amazon purchase",
        },
    },
};

var res = await sdk.Expenses.CreateAsync(req);

// handle response
```
### Example Usage: Payment

<!-- UsageSnippet language="csharp" operationID="create-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/expense-transactions" example="Payment" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ExpenseTransaction>() {
        new ExpenseTransaction() {
            Id = "4d7c6929-7770-412b-91bb-44d3bc71d111",
            Type = Codat.Sync.Expenses.Models.Components.Type.Payment,
            IssueDate = "2024-05-21T00:00:00+00:00",
            Currency = "GBP",
            CurrencyRate = 1M,
            ContactRef = new ExpenseContactRef() {
                Id = "430",
            },
            BankAccountRef = new BankAccountReference() {
                Id = "97",
            },
            MerchantName = "Amazon UK",
            Lines = new List<ExpenseTransactionLine>() {
                new ExpenseTransactionLine() {
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "23_Bills",
                    },
                    AccountRef = new RecordRef() {
                        Id = "35",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "DEPARTMENT_5",
                        },
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "504",
                        Type = InvoiceToType.Customer,
                    },
                },
            },
            Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        },
    },
};

var res = await sdk.Expenses.CreateAsync(req);

// handle response
```
### Example Usage: Refund

<!-- UsageSnippet language="csharp" operationID="create-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/expense-transactions" example="Refund" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ExpenseTransaction>() {
        new ExpenseTransaction() {
            Id = "7008d3f2-aeb4-11ed-afa1-0242ac120002",
            Type = Codat.Sync.Expenses.Models.Components.Type.Refund,
            IssueDate = "2024-02-17T00:00:00+00:00",
            Currency = "GBP",
            ContactRef = new ExpenseContactRef() {
                Id = "430",
            },
            BankAccountRef = new BankAccountReference() {
                Id = "97",
            },
            MerchantName = "Amazon UK",
            Lines = new List<ExpenseTransactionLine>() {
                new ExpenseTransactionLine() {
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "23_Bills",
                    },
                    AccountRef = new RecordRef() {
                        Id = "42",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "DEPARTMENT_6",
                        },
                    },
                },
            },
            Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        },
    },
};

var res = await sdk.Expenses.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [CreateExpenseTransactionRequest](../../Models/Requests/CreateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[CreateExpenseTransactionResponse](../../Models/Requests/CreateExpenseTransactionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

The *Update expense* endpoint updates an existing [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/UpdateExpenseRequest) in the accounting software for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/UpdateExpenseRequest) represent transactions made with a company debit or credit card. 

### Supported integrations
The following integrations are supported for the [Payment](https://docs.codat.io/expenses/sync-process/expense-transactions#transaction-types) transaction `type` only: 
| Integration           | Supported |
|-----------------------|-----------|
| FreeAgent             | Yes       |
| QuickBooks Desktop    | Yes       |
| QuickBooks Online     | Yes       |
| Oracle NetSuite       | Yes       |
| Sage Intacct          | Yes       |
| Xero                  | Yes       |
| Zoho Books            | Yes       |

#### Integration-specific behavior

| Integration           | Specifics |
|-----------------------|-----------|
| Sage Intacct          | To sync **debit card expenses**, map the debit card to a Credit Card with the account type set to `Debit`.|

### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="update-expense-transaction" method="put" path="/companies/{companyId}/sync/expenses/expense-transactions/{transactionId}" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateExpenseTransactionRequest req = new UpdateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    UpdateExpenseRequest = new UpdateExpenseRequest() {
        Type = UpdateExpenseRequestType.Payment,
        IssueDate = "2022-06-28T00:00:00.000Z",
        Currency = "GBP",
        ContactRef = new ExpenseContactRef() {
            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
        },
        BankAccountRef = new UpdateExpenseRequestBankAccountReference() {
            Id = "787dfb37-5707-4dc0-8a86-8d74e4cc78ea",
        },
        MerchantName = "Amazon UK",
        Lines = new List<ExpenseTransactionLine>() {
            new ExpenseTransactionLine() {
                NetAmount = 100M,
                TaxAmount = 20M,
                TaxRateRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                AccountRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                ItemRef = null,
                TrackingRefs = null,
                InvoiceTo = null,
            },
        },
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
    },
};

var res = await sdk.Expenses.UpdateAsync(req);

// handle response
```
### Example Usage: Payment

<!-- UsageSnippet language="csharp" operationID="update-expense-transaction" method="put" path="/companies/{companyId}/sync/expenses/expense-transactions/{transactionId}" example="Payment" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateExpenseTransactionRequest req = new UpdateExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    UpdateExpenseRequest = new UpdateExpenseRequest() {
        Type = UpdateExpenseRequestType.Payment,
        IssueDate = "2024-05-21T00:00:00+00:00",
        Currency = "GBP",
        CurrencyRate = 1M,
        ContactRef = new ExpenseContactRef() {
            Id = "430",
        },
        BankAccountRef = new UpdateExpenseRequestBankAccountReference() {
            Id = "97",
        },
        MerchantName = "Amazon UK",
        Lines = new List<ExpenseTransactionLine>() {
            new ExpenseTransactionLine() {
                NetAmount = 100M,
                TaxAmount = 20M,
                TaxRateRef = new RecordRef() {
                    Id = "23_Bills",
                },
                AccountRef = new RecordRef() {
                    Id = "35",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "DEPARTMENT_5",
                    },
                },
                InvoiceTo = new InvoiceTo() {
                    Id = "504",
                    Type = InvoiceToType.Customer,
                },
            },
        },
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
    },
};

var res = await sdk.Expenses.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UpdateExpenseTransactionRequest](../../Models/Requests/UpdateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[UpdateExpenseTransactionResponse](../../Models/Requests/UpdateExpenseTransactionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 422, 429              | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |