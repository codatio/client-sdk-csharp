# CodatLendingBankingAccounts
(*Banking.Accounts*)

## Overview

### Available Operations

* [List](#list) - List accounts
* [Get](#get) - Get account

## List

The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/lending-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are financial accounts maintained by a bank or other financial institution.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBankingAccountsRequest req = new ListBankingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Banking.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListBankingAccountsRequest](../../Models/Requests/ListBankingAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListBankingAccountsResponse](../../Models/Requests/ListBankingAccountsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage    | 400, 401, 402, 403, 404, 409, 429, 500, 503 | application/json                            |
| Codat.Lending.Models.Errors.SDKException    | 4XX, 5XX                                    | \*/\*                                       |

## Get

The *Get account* endpoint returns a single account for a given accountId.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are financial accounts maintained by a bank or other financial institution.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetBankingAccountRequest req = new GetBankingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountId = "7110701885",
};

var res = await sdk.Banking.Accounts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetBankingAccountRequest](../../Models/Requests/GetBankingAccountRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetBankingAccountResponse](../../Models/Requests/GetBankingAccountResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |