# AccountsSDK
(*Accounts*)

## Overview

Accounts

### Available Operations

* [Create](#create) - Create account
* [Get](#get) - Get account
* [GetCreateModel](#getcreatemodel) - Get create account model
* [List](#list) - List accounts

## Create

The *Create account* endpoint creates a new [account](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create account model](https://docs.codat.io/sync-for-payroll-api#/operations/get-create-chartOfAccounts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support creating an account.


### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Accounts.CreateAsync(new CreateAccountRequest() {
    Account = new Account() {
        Currency = "USD",
        CurrentBalance = 0M,
        Description = "Invoices the business has issued but has not yet collected payment on.",
        FullyQualifiedCategory = "Asset.Current",
        FullyQualifiedName = "Cash On Hand",
        Id = "1b6266d1-1e44-46c5-8eb5-a8f98e03124e",
        Metadata = new AccountMetadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Name = "Accounts Receivable",
        NominalCode = "610",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayroll.Models.Shared.AccountStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "Money", new Dictionary<string, object>() {
                    { "blue", "shred" },
                } },
            },
        },
        Type = CodatSyncPayroll.Models.Shared.AccountType.Asset,
        ValidDatatypeLinks = new List<AccountValidDataTypeLinks>() {
            new AccountValidDataTypeLinks() {
                Links = new List<string>() {
                    "abnormally",
                },
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateAccountRequest](../../models/operations/CreateAccountRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[Models.Operations.CreateAccountResponse](../../models/operations/CreateAccountResponse.md)**


## Get

The *Get account* endpoint returns a single account for a given `accountId`.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support getting a specific account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Accounts.GetAsync(new GetAccountRequest() {
    AccountId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetAccountRequest](../../models/operations/GetAccountRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetAccountResponse](../../models/operations/GetAccountResponse.md)**


## GetCreateModel

The *Get create account model* endpoint returns the expected data for the request payload when creating an [account](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company and integration.
    
[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.
    
**Integration-specific behaviour**
    
See the *response examples* for integration-specific indicative models.
    
Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support creating an account.


### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Accounts.GetCreateModelAsync(new GetCreateAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCreateAccountsModelRequest](../../models/operations/GetCreateAccountsModelRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetCreateAccountsModelResponse](../../models/operations/GetCreateAccountsModelResponse.md)**


## List

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Accounts.ListAsync(new ListAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListAccountsRequest](../../models/operations/ListAccountsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListAccountsResponse](../../models/operations/ListAccountsResponse.md)**

