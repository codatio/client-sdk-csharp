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

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateExpenseTransactionRequest req = new CreateExpenseTransactionRequest() {
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

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateExpenseTransactionRequest req = new UpdateExpenseTransactionRequest() {
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
| Dynamics 365 Business Central | 350 MB | Dynamics do not explicitly outline which file types are supported but they do state <a className="external" href="https://learn.microsoft.com/en-gb/dynamics365/business-central/ui-how-add-link-to-record#to-attach-a-file-to-a-purchase-invoice" target="_blank">here</a> that "You can attach any type of file, such as text, image, or video files". |

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UploadExpenseAttachmentRequest req = new UploadExpenseAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
};

var res = await sdk.Expenses.UploadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UploadExpenseAttachmentRequest](../../Models/Operations/UploadExpenseAttachmentRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[UploadExpenseAttachmentResponse](../../Models/Operations/UploadExpenseAttachmentResponse.md)**

