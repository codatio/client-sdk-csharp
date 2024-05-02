# Accounts
(*Accounts*)

## Overview

Get, create, and update Accounts.

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
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateAccountRequest req = new CreateAccountRequest() {
    AccountPrototype = new AccountPrototype() {
        Currency = "USD",
        CurrentBalance = 0M,
        Description = "Invoices the business has issued but has not yet collected payment on.",
        FullyQualifiedCategory = "Asset.Current",
        FullyQualifiedName = "Cash On Hand",
        Name = "Accounts Receivable",
        NominalCode = "610",
        Status = AccountStatus.Active,
        Type = AccountType.Asset,
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateAccountRequest](../../Models/Operations/CreateAccountRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[Models.Operations.CreateAccountResponse](../../Models/Operations/CreateAccountResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## Get

The *Get account* endpoint returns a single account for a given `accountId`.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support getting a specific account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountRequest req = new GetAccountRequest() {
    AccountId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Accounts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetAccountRequest](../../Models/Operations/GetAccountRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetAccountResponse](../../Models/Operations/GetAccountResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## GetCreateModel

The *Get create account model* endpoint returns the expected data for the request payload when creating an [account](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company and integration.
    
[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.
    
**Integration-specific behaviour**
    
See the *response examples* for integration-specific indicative models.
    
Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCreateAccountsModelRequest req = new GetCreateAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCreateAccountsModelRequest](../../Models/Operations/GetCreateAccountsModelRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetCreateAccountsModelResponse](../../Models/Operations/GetCreateAccountsModelResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |

## List

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountsRequest req = new ListAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListAccountsRequest](../../Models/Operations/ListAccountsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListAccountsResponse](../../Models/Operations/ListAccountsResponse.md)**
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503           | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |
