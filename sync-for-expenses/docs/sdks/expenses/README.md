# Expenses
(*Expenses*)

## Overview

Create expense datasets and upload receipts.

### Available Operations

* [Create](#create) - Create expense transaction
* [Update](#update) - Update expense-transactions
* [UploadAttachment](#uploadattachment) - Upload attachment

## Create

The *Create expense* endpoint creates an [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) in the accounting platform for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 


**Integration-specific behaviour**

Some accounting platforms support the option of pushing transactions to a draft state. This can be done by setting the postAsDraft property on the transaction to true. For platforms without this feature, the postAsDraft property should be ignored or set to false.

| Integration | Draft State | Details                                                                                                      |  
|-------------|-------------|--------------------------------------------------------------------------------------------------------------|
| Dynamics 365 Business Central | Yes   | Setting postAsDraft to true will push the transactions to a drafted state rather than posting directly to the ledger. For transactions in a draft state, they can then be approved and posted within the accounting platform. |
| Quickbooks Online | No | -  |
| Xero | No | - |
| NetSuite | No | - |

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Expenses.CreateAsync(new CreateExpenseTransactionRequest() {
    CreateExpenseRequest = new CreateExpenseRequest() {
        Items = new List<ExpenseTransaction>() {
            new ExpenseTransaction() {
                BankAccountRef = new BankAccountReference() {
                    Id = "787dfb37-5707-4dc0-8a86-8d74e4cc78ea",
                },
                ContactRef = new ContactRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    Type = Type.Supplier,
                },
                Currency = "GBP",
                Id = "4d7c6929-7770-412b-91bb-44d3bc71d111",
                IssueDate = "2022-10-23T00:00:00.000Z",
                Lines = new List<ExpenseTransactionLine>() {
                    new ExpenseTransactionLine() {
                        AccountRef = new RecordRef() {
                            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                        },
                        NetAmount = 110.42M,
                        TaxAmount = 14.43M,
                        TaxRateRef = new RecordRef() {
                            Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                        },
                        TrackingRefs = new List<RecordRef>() {
                            new RecordRef() {
                                Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                            },
                        },
                    },
                },
                MerchantName = "Amazon UK",
                Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
                Type = ExpenseTransactionType.Payment,
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [CreateExpenseTransactionRequest](../../Models/Operations/CreateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[CreateExpenseTransactionResponse](../../Models/Operations/CreateExpenseTransactionResponse.md)**


## Update

The *Update expense* endpoint updates an existing [expense transaction](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) in the accounting platform for a given company's connection. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 


**Integration-specific behaviour**

At the moment you can update expenses only for Xero ([Payment](https://docs.codat.io/expenses/sync-process/expense-transactions#transaction-types) transaction type only).

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Expenses.UpdateAsync(new UpdateExpenseTransactionRequest() {
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
                NetAmount = 110.42M,
                TaxAmount = 14.43M,
                TaxRateRef = new RecordRef() {
                    Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                },
                TrackingRefs = new List<RecordRef>() {
                    new RecordRef() {
                        Id = "40e3e57c-2322-4898-966c-ca41adfd23fd",
                    },
                },
            },
        },
        MerchantName = "Amazon UK",
        Notes = "APPLE.COM/BILL - 09001077498 - Card Ending: 4590",
        Type = "string",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateExpenseTransactionRequest](../../Models/Operations/UpdateExpenseTransactionRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[UpdateExpenseTransactionResponse](../../Models/Operations/UpdateExpenseTransactionResponse.md)**


## UploadAttachment

The *Upload attachment* endpoint uploads an attachment in the accounting software against the given transactionId. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. 

**Integration-specific behaviour**

Each accounting software supports different file formats and sizes.

| Integration | File Size | File Extension                                                                                                      |  
|-------------|-------------|--------------------------------------------------------------------------------------------------------------|
| Xero | 4MB  | 7Z, BMP, CSV, DOC, DOCX, EML, GIF, JPEG, JPG, KEYNOTE, MSG, NUMBERS, ODF, ODS, ODT, PAGES, PDF, PNG, PPT, PPTX, RAR, RTF, TIF, TIFF, TXT, XLS, XLSX, ZIP |
| QuickBooks Online | 100MB | AI, CSV, DOC, DOCX, EPS, GIF, JPEG, JPG, ODS, PAGES, PDF, PNG, RTF, TIF, TXT, XLS, XLSX, XML  |
| NetSuite | 100MB | BMP, CSV, XLS, XLSX, JSON, PDF, PJPG, PJPEG, PNG, TXT, SVG, TIF, TIFF, DOC, DOCX, ZIP |

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Expenses.UploadAttachmentAsync(new UploadExpenseAttachmentRequest() {
    RequestBody = new UploadExpenseAttachmentRequestBody() {
        Content = "0xE3ABc1980E as bytes <<<>>>",
        FileName = "elegant_producer_electric.jpeg",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UploadExpenseAttachmentRequest](../../Models/Operations/UploadExpenseAttachmentRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[UploadExpenseAttachmentResponse](../../Models/Operations/UploadExpenseAttachmentResponse.md)**

