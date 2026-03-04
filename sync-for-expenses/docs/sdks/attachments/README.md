# Attachments

## Overview

Attach receipts to a transaction for a complete audit trail.

### Available Operations

* [Upload](#upload) - Upload attachment

## Upload

The *Upload attachment* endpoint uploads an attachment in the accounting software against the given transactionId. 

[Expense transactions](https://docs.codat.io/sync-for-expenses-api#/schemas/ExpenseTransaction) represent transactions made with a company debit or credit card. Attachments for `Adjustment` and `Transfer` transaction types are not supported for any integrations.

**Integration-specific behavior**

Each accounting software supports different file formats and sizes.

| Integration                       | File size | File extension                                        | Supported transactions |
|-----------------------------------|-----------|-------------------------------------------------------|------------------------|
| **Xero**                          | 3 MB      | 7Z, BMP, CSV, DOC, DOCX, EML, GIF, JPEG, JPG, KEYNOTE, MSG, NUMBERS, ODF,   ODS, ODT, PAGES, PDF, PNG, PPT, PPTX, RAR, RTF, TIF, TIFF, TXT, XLS, XLSX, ZIP | All supported types |
| **QuickBooks Online**             | 100 MB    | AI, CSV, DOC, DOCX, EPS, GIF, JPEG, JPG, ODS, PAGES, PDF, PNG, RTF, TIF, TXT, XLS, XLSX, XML                                                      | `expense-transactions.Payment`, `expense-transactions.Refund`, `reimbursable-expense-transactions` |
| **NetSuite**                      | 100 MB    | BMP, CSV, XLS, XLSX, JSON, PDF, PJPG, PJPEG, PNG, TXT, SVG, TIF, TIFF, DOC, DOCX, ZIP |`expense-transactions.Payment`, `expense-transactions.Refund`                                                                    |
| **Dynamics 365 Business Central** | 350 MB    | [No explicit requirements outlined](https://learn.microsoft.com/en-gb/dynamics365/business-central/ui-how-add-link-to-record#to-attach-a-file-to-a-purchase-invoice) for text, image, and video files. | All supported types
| **QuickBooks Desktop**            | NA        | Does not support attachment upload                     | N/A                    |
| **FreeAgent**                     | 5MB       | PNG, X-PNG, JPEG, PJG, GIF, X-PDF  | `expense-transactions.Payment`, `reimbursable-expense-transactions`
| **Zoho Books**                    | 5MB       | GIF, PNG, JPEG, JPG, BMP, PDF      | `expense-transactions.Payment`, `reimbursable-expense-transactions`        |

### Example Usage

<!-- UsageSnippet language="csharp" operationID="upload-expense-attachment" method="post" path="/companies/{companyId}/sync/expenses/syncs/{syncId}/transactions/{transactionId}/attachments" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UploadExpenseAttachmentRequest req = new UploadExpenseAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SyncId = "6fb40d5e-b13e-11ed-afa1-0242ac120002",
    TransactionId = "336694d8-2dca-4cb5-a28d-3ccb83e55eee",
};

var res = await sdk.Attachments.UploadAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UploadExpenseAttachmentRequest](../../Models/Requests/UploadExpenseAttachmentRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UploadExpenseAttachmentResponse](../../Models/Requests/UploadExpenseAttachmentResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |