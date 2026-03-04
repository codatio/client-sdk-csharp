# Accounts

## Overview

Create accounts and view create account options.

### Available Operations

* [Create](#create) - Create account
* [GetCreateModel](#getcreatemodel) - Get create account model

## Create

The *Create account* endpoint creates a new [account](https://docs.codat.io/sync-for-expenses-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-expenses-api#/schemas/Account) are the categories a business uses to record accounting transactions.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create account model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-chartOfAccounts-model).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create-account" method="post" path="/companies/{companyId}/connections/{connectionId}/push/accounts" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAccountRequest req = new CreateAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountPrototype = new AccountPrototype() {
        NominalCode = "610",
        Name = "Accounts Receivable",
        Description = "Invoices the business has issued but has not yet collected payment on.",
        FullyQualifiedCategory = "Asset.Current",
        FullyQualifiedName = "Cash On Hand",
        Currency = "GBP",
        CurrentBalance = 0M,
        Type = AccountType.Asset,
        Status = AccountStatus.Active,
    },
};

var res = await sdk.Accounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CreateAccountRequest](../../Models/Requests/CreateAccountRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[Models.Requests.CreateAccountResponse](../../Models/Requests/CreateAccountResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetCreateModel

The *Get create account model* endpoint returns the expected data for the request payload when creating an [account](https://docs.codat.io/sync-for-expenses-api#/schemas/Account) for a given company and integration.

[Accounts](https://docs.codat.io/sync-for-expenses-api#/schemas/Account) are the categories a business uses to record accounting transactions.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.

### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-create-chartOfAccounts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/chartOfAccounts" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateChartOfAccountsModelRequest req = new GetCreateChartOfAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetCreateChartOfAccountsModelRequest](../../Models/Requests/GetCreateChartOfAccountsModelRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GetCreateChartOfAccountsModelResponse](../../Models/Requests/GetCreateChartOfAccountsModelResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |