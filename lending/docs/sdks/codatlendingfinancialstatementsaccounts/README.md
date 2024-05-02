# CodatLendingFinancialStatementsAccounts
(*FinancialStatements.Accounts*)

### Available Operations

* [Get](#get) - Get account
* [List](#list) - List accounts

## Get

The *Get account* endpoint returns a single account for a given accountId.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts) for integrations that support getting a specific account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    AccountId = "<value>",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingAccountRequest](../../Models/Operations/GetAccountingAccountRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingAccountResponse](../../Models/Operations/GetAccountingAccountResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## List

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/lending-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingAccountsRequest](../../Models/Operations/ListAccountingAccountsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingAccountsResponse](../../Models/Operations/ListAccountingAccountsResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
