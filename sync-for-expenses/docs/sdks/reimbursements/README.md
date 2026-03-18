# Reimbursements

## Overview

Create and update transactions that represent your customers' repayable spend.

### Available Operations

* [Create](#create) - Create reimbursable expense transaction
* [Update](#update) - Update reimbursable expense transaction

## Create

Use the *Create reimbursable expense* endpoint to submit an employee expense claim in the accounting platform for a given company's connection.

[Reimbursable expense requests](https://docs.codat.io/sync-for-expenses-api#/schemas/ReimbursableExpenseTransactionRequest) are reflected in the accounting software in the form of **Bills** against an employee (who exists as a supplier in the accounting platform).

### Supported Integrations
| Integration           | Supported |
|-----------------------|-----------|
| FreeAgent             | Yes       |
| QuickBooks Desktop    | Yes       |
| QuickBooks Online     | Yes       |
| Oracle NetSuite       | Yes       |
| Zoho Books            | Yes       |
| Sage Intacct          | Yes       |

### Example Usage: Create reimbursable expense

<!-- UsageSnippet language="csharp" operationID="create-reimbursable-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions" example="Create reimbursable expense" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateReimbursableExpenseTransactionRequest req = new CreateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ReimbursableExpenseTransaction>() {
        new ReimbursableExpenseTransaction() {
            Id = "4d7c6929-7770-412b-91bb-44d3bc71d111",
            Reference = "expenses w/c 01/07",
            ContactRef = new ReimbursementContactRef() {
                Id = "752",
            },
            IssueDate = "2024-05-21",
            DueDate = "2024-05-21",
            Currency = "GBP",
            CurrencyRate = 1M,
            Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
            Lines = new List<ReimbursableExpenseTransactionLine>() {
                new ReimbursableExpenseTransactionLine() {
                    Description = "Hotel",
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
        },
    },
};

var res = await sdk.Reimbursements.CreateAsync(req);

// handle response
```
### Example Usage: Example 1

<!-- UsageSnippet language="csharp" operationID="create-reimbursable-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateReimbursableExpenseTransactionRequest req = new CreateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ReimbursableExpenseTransaction>() {
        new ReimbursableExpenseTransaction() {
            Id = "4d7c6929-7770-412b-91bb-44d3bc71d111",
            ContactRef = new ReimbursementContactRef() {
                Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
            },
            ApAccountRef = null,
            IssueDate = "2022-10-23T00:00:00Z",
            DueDate = "2022-10-23T00:00:00Z",
            Currency = "GBP",
            Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
            Lines = new List<ReimbursableExpenseTransactionLine>() {
                new ReimbursableExpenseTransactionLine() {
                    Description = "2-night hotel stay",
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                    AccountRef = new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                    ItemRef = new ItemRef() {
                        Id = "80000002-1675158984",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                        },
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "80000002-1674552702",
                        Type = InvoiceToType.Customer,
                    },
                },
            },
        },
    },
};

var res = await sdk.Reimbursements.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-reimbursable-expense-transaction" method="post" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateReimbursableExpenseTransactionRequest req = new CreateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    RequestBody = new List<ReimbursableExpenseTransaction>() {
        new ReimbursableExpenseTransaction() {
            Id = "4d7c6929-7770-412b-91bb-44d3bc71d111",
            ContactRef = new ReimbursementContactRef() {
                Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
            },
            ApAccountRef = null,
            IssueDate = "2022-10-23T00:00:00Z",
            DueDate = "2022-10-23T00:00:00Z",
            Currency = "GBP",
            Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
            Lines = new List<ReimbursableExpenseTransactionLine>() {
                new ReimbursableExpenseTransactionLine() {
                    Description = "2-night hotel stay",
                    NetAmount = 100M,
                    TaxAmount = 20M,
                    TaxRateRef = new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                    AccountRef = new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                    ItemRef = new ItemRef() {
                        Id = "80000002-1675158984",
                    },
                    TrackingRefs = new List<TrackingRef>() {
                        new TrackingRef() {
                            Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                        },
                    },
                    InvoiceTo = new InvoiceTo() {
                        Id = "80000002-1674552702",
                        Type = InvoiceToType.Customer,
                    },
                },
            },
        },
    },
};

var res = await sdk.Reimbursements.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [CreateReimbursableExpenseTransactionRequest](../../Models/Requests/CreateReimbursableExpenseTransactionRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[CreateReimbursableExpenseTransactionResponse](../../Models/Requests/CreateReimbursableExpenseTransactionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

The *Update reimbursable expense* endpoint updates an existing employee expense claim in the accounting platform for a given company's connection. 

Updating an existing [reimbursable expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/UpdateReimbursableExpenseTransactionRequest) will update the existing **bill** against an employee (who exists as a supplier in the accounting software).

### Supported Integrations
| Integration           | Supported |
|-----------------------|-----------|
| FreeAgent             | Yes       |
| QuickBooks Online     | Yes       |
| Oracle NetSuite       | Yes       |
| Zoho Books            | Yes       |



### Example Usage: Example 1

<!-- UsageSnippet language="csharp" operationID="update-reimbursable-expense-transaction" method="put" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions/{transactionId}" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

Models.Requests.UpdateReimbursableExpenseTransactionRequest req = new Codat.Sync.Expenses.Models.Requests.UpdateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    UpdateReimbursableExpenseTransactionRequestValue = new Codat.Sync.Expenses.Models.Components.UpdateReimbursableExpenseTransactionRequest() {
        ContactRef = new ReimbursementContactRef() {
            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
        },
        ApAccountRef = new ApAccountRef() {
            Id = "8000004C-1724173136",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        Lines = new List<ReimbursableExpenseTransactionLine>() {
            new ReimbursableExpenseTransactionLine() {
                Description = "2-night hotel stay",
                NetAmount = 100M,
                TaxAmount = 20M,
                TaxRateRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                AccountRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                ItemRef = new ItemRef() {
                    Id = "80000002-1675158984",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                    },
                },
                InvoiceTo = new InvoiceTo() {
                    Id = "80000002-1674552702",
                    Type = InvoiceToType.Customer,
                },
            },
        },
    },
};

var res = await sdk.Reimbursements.UpdateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="update-reimbursable-expense-transaction" method="put" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions/{transactionId}" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

Models.Requests.UpdateReimbursableExpenseTransactionRequest req = new Codat.Sync.Expenses.Models.Requests.UpdateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    UpdateReimbursableExpenseTransactionRequestValue = new Codat.Sync.Expenses.Models.Components.UpdateReimbursableExpenseTransactionRequest() {
        ContactRef = new ReimbursementContactRef() {
            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
        },
        ApAccountRef = new ApAccountRef() {
            Id = "8000004C-1724173136",
        },
        IssueDate = "2022-10-23T00:00:00Z",
        DueDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        Lines = new List<ReimbursableExpenseTransactionLine>() {
            new ReimbursableExpenseTransactionLine() {
                Description = "2-night hotel stay",
                NetAmount = 100M,
                TaxAmount = 20M,
                TaxRateRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                AccountRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                ItemRef = new ItemRef() {
                    Id = "80000002-1675158984",
                },
                TrackingRefs = new List<TrackingRef>() {
                    new TrackingRef() {
                        Id = "e9a1b63d-9ff0-40e7-8038-016354b987e6",
                    },
                },
                InvoiceTo = new InvoiceTo() {
                    Id = "80000002-1674552702",
                    Type = InvoiceToType.Customer,
                },
            },
        },
    },
};

var res = await sdk.Reimbursements.UpdateAsync(req);

// handle response
```
### Example Usage: Update reimbursable expense

<!-- UsageSnippet language="csharp" operationID="update-reimbursable-expense-transaction" method="put" path="/companies/{companyId}/sync/expenses/reimbursable-expense-transactions/{transactionId}" example="Update reimbursable expense" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

Models.Requests.UpdateReimbursableExpenseTransactionRequest req = new Codat.Sync.Expenses.Models.Requests.UpdateReimbursableExpenseTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
    UpdateReimbursableExpenseTransactionRequestValue = new Codat.Sync.Expenses.Models.Components.UpdateReimbursableExpenseTransactionRequest() {
        Reference = "expenses w/c 01/07",
        ContactRef = new ReimbursementContactRef() {
            Id = "752",
        },
        IssueDate = "2024-05-21",
        DueDate = "2024-05-21",
        Currency = "GBP",
        CurrencyRate = 1M,
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        Lines = new List<ReimbursableExpenseTransactionLine>() {
            new ReimbursableExpenseTransactionLine() {
                Description = "Hotel",
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
    },
};

var res = await sdk.Reimbursements.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                           | Type                                                                                                                                | Required                                                                                                                            | Description                                                                                                                         |
| ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                           | [Models.Requests.UpdateReimbursableExpenseTransactionRequest](../../Models/Requests/UpdateReimbursableExpenseTransactionRequest.md) | :heavy_check_mark:                                                                                                                  | The request object to use for the request.                                                                                          |

### Response

**[UpdateReimbursableExpenseTransactionResponse](../../Models/Requests/UpdateReimbursableExpenseTransactionResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |