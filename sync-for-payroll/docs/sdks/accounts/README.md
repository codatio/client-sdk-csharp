# Accounts
(*Accounts*)

## Overview

Get, create, and update Accounts.

### Available Operations

* [List](#list) - List accounts
* [Get](#get) - Get account
* [GetCreateModel](#getcreatemodel) - Get create account model
* [Create](#create) - Create account

## List

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountsRequest req = new ListAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListAccountsRequest](../../Models/Requests/ListAccountsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListAccountsResponse](../../Models/Requests/ListAccountsResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503           | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |


## Get

The *Get account* endpoint returns a single account for a given `accountId`.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support getting a specific account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountRequest req = new GetAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Accounts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetAccountRequest](../../Models/Requests/GetAccountRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetAccountResponse](../../Models/Requests/GetAccountResponse.md)**

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
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateAccountsModelRequest req = new GetCreateAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Accounts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetCreateAccountsModelRequest](../../Models/Requests/GetCreateAccountsModelRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[GetCreateAccountsModelResponse](../../Models/Requests/GetCreateAccountsModelResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |


## Create

The *Create account* endpoint creates a new [account](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/sync-for-payroll-api#/schemas/Account) are the categories a business uses to record accounting transactions.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create account model](https://docs.codat.io/sync-for-payroll-api#/operations/get-create-chartOfAccounts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateAccountRequest req = new CreateAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountPrototype = new AccountPrototype() {
        NominalCode = "610",
        Name = "Accounts Receivable",
        Description = "Invoices the business has issued but has not yet collected payment on.",
        FullyQualifiedCategory = "Asset.Current",
        FullyQualifiedName = "Cash On Hand",
        Currency = "EUR",
        CurrentBalance = 0M,
        Type = Codat.Sync.Payroll.Models.Components.AccountType.Asset,
        Status = Codat.Sync.Payroll.Models.Components.AccountStatus.Active,
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

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |
