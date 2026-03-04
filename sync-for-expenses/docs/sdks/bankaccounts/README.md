# BankAccounts

## Overview

Create bank accounts and view create bank account options.

### Available Operations

* [Create](#create) - Create bank account
* [GetCreateModel](#getcreatemodel) - Get create bank account model

## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/sync-for-expenses-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/sync-for-expenses-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update bank account model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-bankAccounts-model).

### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-bank-account" method="post" path="/companies/{companyId}/connections/{connectionId}/push/bankAccounts" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccount = new BankAccount() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        Status = BankAccountStatus.Active,
    },
};

var res = await sdk.BankAccounts.CreateAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="create-bank-account" method="post" path="/companies/{companyId}/connections/{connectionId}/push/bankAccounts" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccount = new BankAccount() {
        AccountName = "GBP Bank Account",
        AccountType = BankAccountType.Debit,
        AccountNumber = "12345678",
        Currency = "GBP",
        Status = BankAccountStatus.Active,
    },
};

var res = await sdk.BankAccounts.CreateAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="create-bank-account" method="post" path="/companies/{companyId}/connections/{connectionId}/push/bankAccounts" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccount = new BankAccount() {
        AccountName = "Xero GBP Bank Account",
        AccountType = BankAccountType.Debit,
        SortCode = "445566",
        AccountNumber = "12345678",
        Currency = "GBP",
        Status = BankAccountStatus.Active,
    },
};

var res = await sdk.BankAccounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateBankAccountRequest](../../Models/Requests/CreateBankAccountRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[Models.Requests.CreateBankAccountResponse](../../Models/Requests/CreateBankAccountResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetCreateModel

The *Get create/update bank account model* endpoint returns the expected data for the request payload when creating and updating a [bank account](https://docs.codat.io/sync-for-expenses-api#/schemas/BankAccount) for a given company and integration.

[Bank accounts](https://docs.codat.io/sync-for-expenses-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.


### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="FreeAgent" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="KashFlow" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-bankAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/bankAccounts" example="Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCreateBankAccountsModelRequest](../../Models/Requests/GetCreateBankAccountsModelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetCreateBankAccountsModelResponse](../../Models/Requests/GetCreateBankAccountsModelResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |