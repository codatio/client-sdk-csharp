# Expenses
(*Expenses*)

## Overview

Create expense datasets and upload receipts.

### Available Operations

* [Create](#create) - Create expense transaction
* [Update](#update) - Update expense-transactions
* [UploadAttachment](#uploadattachment) - Upload attachment

## Create

Create an expense transaction

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

Update an expense transaction

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

Creates an attachment in the accounting software against the given transactionId

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

